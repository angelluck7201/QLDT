using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using System.Transactions;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using ComboBox = System.Windows.Forms.ComboBox;

namespace QLDT.FormControls.DonHangForms
{
    public partial class UcDonHang : BaseUserControl
    {
        private readonly DonHang _domainData;
        private readonly Define.LoaiDonHangEnum _loaiDonHang;
        private readonly BindingList<ChiTietDonHang> _chiTietDonhang = new BindingList<ChiTietDonHang>();
        private readonly List<ChiTietDonHang> _deletedDonHangs = new List<ChiTietDonHang>();

        public UcDonHang(Define.LoaiDonHangEnum loaiDonHang, DonHang data = null)
        {
            InitializeComponent();

            DonHang_KhachHangId.DisplayMember = "Ten";
            DonHang_KhachHangId.ValueMember = "Id";
            var lstKhachHang = new List<KhachHang>();
            if (loaiDonHang == Define.LoaiDonHangEnum.XuatKho)
            {
                lstKhachHang = CRUD.DbContext.KhachHangs.Where(s => s.LoaiKhachHang != Define.LoaiKhachHangEnum.NhaCungCap.ToString()).ToList();
                lblKhachHangId.Text = "Khách Hàng";
            }
            else
            {
                lstKhachHang = CRUD.DbContext.KhachHangs.Where(s => s.LoaiKhachHang == Define.LoaiKhachHangEnum.NhaCungCap.ToString()).ToList();
            }
            DonHang_KhachHangId.DataSource = new BindingSource((lstKhachHang), null);
            _domainData = data;
            _loaiDonHang = loaiDonHang;
            Init(data);
            if (data != null)
            {
                _chiTietDonhang = new BindingList<ChiTietDonHang>(data.ChiTietDonHangs.ToList());
                if (data.KhachHangId == Define.KhachLeId)
                {
                    var khachLe = lstKhachHang.FirstOrDefault(s => s.Id == Define.KhachLeId);
                    if (khachLe != null)
                    {
                        khachLe.Ten = data.Ten;
                    }
                }
                btnDelete.Visible = true;

                _chiTietDonhang.ForEach(s => s.ListChiTietHangHoa = s.ChiTietHangHoas.ToList());
            }
            else
            {
                btnDelete.Visible = false;
                DonHang_NgayLap.Text = TimeHelper.TimestampToString(TimeHelper.CurrentTimeStamp());
            }


            var dataSource = CRUD.DbContext.KhoHangs.Select(s => new { s.TenHang, s.Id }).ToList();
            FormBehavior.DecoreateLookEdit(listHangHoa, dataSource, "TenHang");
            listHangHoa.EditValueChanged += listHangHoa_EditValueChanged;

            gridControlChiTiet.DataSource = _chiTietDonhang;
            btnDeleteRow.ButtonClick += btnDeleteRow_ButtonClick;

            UpdateTongTien();
            UpdateNo();
        }

        public override bool SaveData()
        {
            var validateResult = ValidateInput();
            if (!string.IsNullOrEmpty(validateResult))
            {
                MessageBox.Show(validateResult);
                return false;
            }


            // Save Don Hang
            var saveData = CRUD.GetFormObject<DonHang>(FormControls);
            CRUD.DecorateSaveData(saveData, _domainData);
            saveData.LoaiDonHang = _loaiDonHang.ToString();
            saveData.ThanhToan = Math.Min(PrimitiveConvert.StringToInt(DonHang_ThanhToan.Text), PrimitiveConvert.StringToInt(DonHang_TongCong.Text));

            // Ten cho khach mua le
            if (DonHang_KhachHangId.SelectedValue == null || (long)DonHang_KhachHangId.SelectedValue == Define.KhachLeId)
            {
                saveData.KhachHangId = Define.KhachLeId;
                saveData.Ten = DonHang_KhachHangId.Text;
            }

            using (var transaction = new TransactionScope())
            {

                if (_domainData != null)
                {
                    // Remove chi tiet don hang cu
                    DeleteChiTietDonHang(_domainData);

                    saveData.Id = _domainData.Id;
                    CRUD.DbContext.DonHangs.AddOrUpdate(saveData);
                }
                else
                {
                    CRUD.DbContext.DonHangs.AddOrUpdate(saveData);
                    CRUD.DbContext.SaveChanges();
                }


                // Save chi tiet Don Hang
                foreach (var chiTietDonHang in _chiTietDonhang)
                {
                    CRUD.DecorateSaveData(chiTietDonHang);
                    chiTietDonHang.DonHangId = saveData.Id;
                    CRUD.DbContext.ChiTietDonHangs.AddOrUpdate(chiTietDonHang);
                    CRUD.DbContext.SaveChanges();

                    // Cap nhat hang trong kho
                    var hangHoa = CRUD.DbContext.KhoHangs.Find(chiTietDonHang.HangHoaId);
                    if (hangHoa != null)
                    {
                        if (_loaiDonHang == Define.LoaiDonHangEnum.NhapKho)
                        {
                            hangHoa.SoLuong += chiTietDonHang.SoLuong;
                        }
                        else
                        {
                            hangHoa.SoLuong -= chiTietDonHang.SoLuong;
                        }
                        CRUD.DbContext.KhoHangs.AddOrUpdate(hangHoa);
                    }

                    // Save chi tiet hang hoa
                    foreach (var chiTietHangHoa in chiTietDonHang.ListChiTietHangHoa)
                    {
                        CRUD.DecorateSaveData(chiTietHangHoa);
                        chiTietHangHoa.ChiTietDonHangId = chiTietDonHang.Id;
                        CRUD.DbContext.ChiTietHangHoas.AddOrUpdate(chiTietHangHoa);
                    }
                }

                // Save cong no neu co
                var congNo = (long)DonHang_No.EditValue;
                if (congNo > 0)
                {
                    // Add Cong no moi
                    var congNoHienTai = new CongNo();
                    if (_domainData != null && _domainData.CongNoes.FirstOrDefault() != null)
                    {
                        congNoHienTai = _domainData.CongNoes.FirstOrDefault();
                        congNoHienTai.No = congNoHienTai.NoDonHang - congNoHienTai.DaThanhToan;
                    }
                    else
                    {
                        congNoHienTai.No = Math.Abs(congNo);
                    }
                    CRUD.DecorateSaveData(congNoHienTai);
                    congNoHienTai.DonHangId = saveData.Id;
                    congNoHienTai.KhachHangId = saveData.KhachHangId;
                    congNoHienTai.NgayLap = saveData.NgayLap;
                    congNoHienTai.LoaiDonHang = saveData.LoaiDonHang;
                    congNoHienTai.GhiChu = saveData.GhiChu;
                    CRUD.DbContext.CongNoes.AddOrUpdate(congNoHienTai);
                    CRUD.DbContext.SaveChanges();

                    // Add chi tiet thanh toanh
                    if (saveData.ThanhToan > 0)
                    {
                        var thanhToan = new ThanhToanCongNo();
                        CRUD.DecorateSaveData(thanhToan);
                        thanhToan.CongNoId = congNoHienTai.Id;
                        thanhToan.ThanhToan = saveData.ThanhToan;
                        thanhToan.NgayThanhToan = saveData.NgayLap;
                        CRUD.DbContext.ThanhToanCongNoes.AddOrUpdate(thanhToan);
                    }
                }
                CRUD.DbContext.SaveChanges();
                transaction.Complete();
            }

            var confirmDialog = MessageBox.Show(Define.MESSAGE_IN_HOA_DON, Define.MESSAGE_IN_HOA_DON_TITLE, MessageBoxButtons.YesNo);
            if (confirmDialog == DialogResult.Yes)
            {
                InHoaDon(saveData.Id);
            }

            return true;
        }

        public string ValidateInput()
        {
            if (string.IsNullOrEmpty(DonHang_KhachHangId.Text))
            {
                return string.Format("Không được phép để trống {0}!", DonHang_KhachHangId.Text);
            }
            if (_chiTietDonhang.Count == 0)
            {
                return "Chưa nhập hàng hóa cho đơn hàng";
            }
            else
            {
                foreach (var chiTietDonHang in _chiTietDonhang)
                {
                    if (chiTietDonHang.HangHoaId == 0)
                    {
                        return "Không được để trống hàng hóa";
                    }
                    if (chiTietDonHang.DonGia <= 0)
                    {
                        return "Đơn giá phải > 0";
                    }
                    if (chiTietDonHang.SoLuong <= 0)
                    {
                        return "Số lượng phải > 0";
                    }
                    if (_loaiDonHang == Define.LoaiDonHangEnum.XuatKho)
                    {
                        var khoHang = CRUD.DbContext.KhoHangs.Find(chiTietDonHang.HangHoaId);
                        if (khoHang.SoLuong < chiTietDonHang.SoLuong)
                        {
                            return string.Format("Không đủ hàng. Chỉ còn {0} {1} trong kho", khoHang.SoLuong, khoHang.TenHang);
                        }
                    }
                }
            }

            var thanhToan = PrimitiveConvert.StringToInt(DonHang_ThanhToan.Text);
            if (_domainData != null && thanhToan > 0)
            {
                var congNoDangThanhToan = _domainData.CongNoes.Any(s => s.ThanhToanCongNoes.Any());
                if (congNoDangThanhToan)
                {
                    return string.Format("Đơn hàng này đang trong quá trình thanh toán nên không thể chỉnh sửa!");
                }
            }

            if (DonHang_KhachHangId.SelectedValue == null)
            {
                var no = PrimitiveConvert.StringToInt(DonHang_No.EditValue);
                if (no != 0)
                {
                    return "Khách lẻ không được nợ tiền";
                }
            }

            return string.Empty;
        }

        private void UpdateTongTien()
        {
            var thanhTien = _chiTietDonhang.Sum(s => s.ThanhTien);
            var chietKhau = 0L;
            if (!string.IsNullOrEmpty(DonHang_ChietKhau.Text))
            {
                chietKhau = PrimitiveConvert.StringToInt(DonHang_ChietKhau.Text);
            }

            var thue = 0L;
            if (!string.IsNullOrEmpty(DonHang_Thue.Text))
            {
                thue = PrimitiveConvert.StringToInt(DonHang_Thue.Text);
            }

            var tongTien = thanhTien + thanhTien * thue / 100f - thanhTien * chietKhau / 100f;
            DonHang_TongCong.EditValue = tongTien;
            UpdateNo();
        }

        private void UpdateNo()
        {
            var tongTien = PrimitiveConvert.StringToInt(DonHang_TongCong.Text);
            var thanhToan = PrimitiveConvert.StringToInt(DonHang_ThanhToan.Text);
            var conLai = thanhToan - tongTien;
            if (conLai < 0)
            {
                lblCongNo.Text = "Nợ:";
            }
            else
            {
                lblCongNo.Text = "Tiền Thừa:";
            }
            DonHang_No.EditValue = Math.Abs(conLai);
        }

        private void btnDeleteRow_ButtonClick(object sender, EventArgs e)
        {
            dynamic data = gridViewChiTiet.GetRow(gridViewChiTiet.FocusedRowHandle);
            if (data != null && data.Id != 0)
            {
                _deletedDonHangs.Add(data);
            }
            gridViewChiTiet.DeleteRow(gridViewChiTiet.FocusedRowHandle);
            UpdateTongTien();
        }

        private void DonHang_Thue_TextChanged(object sender, EventArgs e)
        {
            UpdateTongTien();
        }

        private void DonHang_ChietKhau_TextChanged(object sender, EventArgs e)
        {
            UpdateTongTien();
        }

        private void gridViewChiTiet_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            UpdateTongTien();
        }


        private void listHangHoa_EditValueChanged(object sender, EventArgs e)
        {
            var lookupEdit = sender as LookUpEdit;
            var hangHoaId = lookupEdit.Properties.KeyValue;
            var hangHoa = CRUD.DbContext.KhoHangs.Find(hangHoaId);
            if (hangHoa != null)
            {
                var row = gridViewChiTiet.GetFocusedRow() as ChiTietDonHang;
                row.DonGia = hangHoa.GiaBan;
            }
        }


        private void DonHang_ThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            UpdateNo();
        }

        private void DonHang_NhaCungCapId_SelectedValueChanged(object sender, EventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox != null && combobox.SelectedValue != null)
            {
                var selectedValue = (long)combobox.SelectedValue;
                var khachHangInfo = CRUD.DbContext.KhachHangs.Find(selectedValue);
                if (khachHangInfo != null)
                {
                    DonHang_DiaChi.Text = khachHangInfo.DiaChi;
                    DonHang_Dienthoai.Text = khachHangInfo.Dienthoai;
                    DonHang_GhiChu.Text = khachHangInfo.GhiChu;
                }
            }
        }

        private void gridViewChiTiet_DoubleClick(object sender, EventArgs e)
        {
            var chitiet = gridViewChiTiet.GetRow(gridViewChiTiet.FocusedRowHandle) as ChiTietDonHang;
            if (chitiet != null)
            {
                var hangHoa = CRUD.DbContext.KhoHangs.Find(chitiet.HangHoaId);
                FormBehavior.GeneratePopupForm(new UcChiTietHangHoa(hangHoa.TenHang, chitiet, UpdateTongTien), "Chi Tiết IMEI", this.ParentForm);
            }
        }

        public void InHoaDon(long donHangId)
        {
            var report = new ReportDonHang();
            var donHang = CRUD.DbContext.DonHangs.Find(donHangId);
            if (donHang != null)
            {
                var dataSource = donHang.ChiTietDonHangs.SelectMany(s => s.ChiTietHangHoas).ToList();
                report.DataSource = dataSource;
                report.ShowPreviewDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_domainData != null)
            {
                var confirmDialog = MessageBox.Show(Define.MESSAGE_XOA_HOA_DON, Define.MESSAGE_XOA_HOA_DON_TITLE, MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    DeleteDonhang(_domainData);
                    var parentForm = this.ParentForm;
                    if (parentForm != null) parentForm.Close();
                }
            }
        }

        public void DeleteDonhang(DonHang donHang)
        {
            using (var transaction = new TransactionScope())
            {
                DeleteCongNo(donHang);
                DeleteChiTietDonHang(donHang);
                CRUD.DbContext.DonHangs.Remove(donHang);
                CRUD.DbContext.SaveChanges();
                transaction.Complete();
            }
        }

        private void DeleteCongNo(DonHang donHang)
        {
            var listCongNo = donHang.CongNoes.ToList();
            foreach (var congNo in listCongNo)
            {
                DeleteThanhToanCongNo(congNo);
                CRUD.DbContext.CongNoes.Remove(congNo);
            }
            CRUD.DbContext.SaveChanges();
        }

        private void DeleteThanhToanCongNo(CongNo congNo)
        {
            var listThanhToan = congNo.ThanhToanCongNoes.ToList();
            foreach (var thanhToanCongNo in listThanhToan)
            {
                CRUD.DbContext.ThanhToanCongNoes.Remove(thanhToanCongNo);
            }
            CRUD.DbContext.SaveChanges();
        }

        private void DeleteChiTietDonHang(DonHang donHang)
        {
            var listChiTiet = donHang.ChiTietDonHangs.ToList();
            foreach (var chiTietDonHang in listChiTiet)
            {
                UpdateTonKho(chiTietDonHang);
                DeleteChiTietHangHoa(chiTietDonHang);
                CRUD.DbContext.ChiTietDonHangs.Remove(chiTietDonHang);
            }
            CRUD.DbContext.SaveChanges();
        }

        private void DeleteChiTietHangHoa(ChiTietDonHang chitiet)
        {
            var listChiTiet = chitiet.ChiTietHangHoas.ToList();
            foreach (var hangHoa in listChiTiet)
            {
                CRUD.DbContext.ChiTietHangHoas.Remove(hangHoa);
            }
            CRUD.DbContext.SaveChanges();
        }

        private void UpdateTonKho(ChiTietDonHang chitiet)
        {
            var loaiPhieu = chitiet.DonHang.LoaiDonHang;
            var hangHoa = chitiet.KhoHang;
            if (hangHoa != null)
            {
                var soluongThayDoi = chitiet.ChiTietHangHoas.Count;
                if (Define.LoaiDonHangEnum.NhapKho.ToString() == loaiPhieu)
                {
                    hangHoa.SoLuong -= soluongThayDoi;
                }
                else
                {
                    hangHoa.SoLuong += soluongThayDoi;
                }
                CRUD.DbContext.KhoHangs.AddOrUpdate(hangHoa);
                CRUD.DbContext.SaveChanges();
            }

        }

    }
}
