using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using System.Transactions;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using ComboBox = System.Windows.Forms.ComboBox;

namespace QLDT.FormControls.DonHangForms
{
    public partial class UcDonHang : BaseUserControl{
        private readonly DonHang _domainData;
        private readonly Define.LoaiDonHangEnum _loaiDonHang;
        private readonly BindingList<ChiTietDonHang> _chiTietDonhang = new BindingList<ChiTietDonHang>();
        private bool _isUsd;

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

            DonHang_LoaiTienTe.DisplayMember = "Value";
            DonHang_LoaiTienTe.ValueMember = "Key";
            DonHang_LoaiTienTe.DataSource = new BindingSource(Define.LoaiTienTeDict, null);

            _loaiDonHang = loaiDonHang;
            _domainData = data;
            if (_domainData == null)
            {
                _domainData = new DonHang();
                _domainData.NgayLap = TimeHelper.CurentDateTime();
                _domainData.LoaiDonHang = loaiDonHang.ToString();
                _domainData.TrangThai = Define.TrangThaiDonHang.Moi.ToString();
                _domainData.LoaiTienTe = Define.LoaiTienTeEnum.VND.ToString();
                _domainData.TyGia = 1;

                btnDelete.Visible = false;
                btnIn.Visible = false;
                GenerateMaDH();
            }
            else
            {
                _chiTietDonhang = new BindingList<ChiTietDonHang>(_domainData.ChiTietDonHangs.ToList());
                if (_domainData.KhachHangId == Define.KhachLeId)
                {
                    var khachLe = lstKhachHang.FirstOrDefault(s => s.Id == Define.KhachLeId);
                    if (khachLe != null)
                    {
                        khachLe.Ten = _domainData.Ten;
                    }
                }
                btnDelete.Visible = true;

                _chiTietDonhang.ForEach(s => s.ListChiTietHangHoa = s.ChiTietHangHoas.ToList());

                if (_domainData.TrangThai == Define.TrangThaiDonHang.ThanhToan.ToString())
                {
                    btnSave.Enabled = false;
                    btnDelete.Visible = false;
                    _domainData.ThanhToan += _domainData.CongNoes.Where(l => l.IsActived).Sum(l => l.ThanhToan);
                }
            }

            Init(_domainData);

            // Get list hang hoa
            var dataSource = CRUD.DbContext.KhoHangs
                .Where(s => s.IsActived 
                    && (loaiDonHang == Define.LoaiDonHangEnum.NhapKho || s.SoLuong > 0))
                .Select(s => new { s.TenHang, s.Id })
                .Union(CRUD.DbContext.ChiTietDonHangs
                    .Where(s=>_domainData.Id == s.DonHangId)
                    .Join(CRUD.DbContext.KhoHangs, ctdh => ctdh.HangHoaId, kh => kh.Id, 
                (ctdh, kh)=> new {kh.TenHang, kh.Id})).ToList();
            
            FormBehavior.DecoreateLookEdit(listHangHoa, dataSource, "TenHang");
            listHangHoa.EditValueChanged += listHangHoa_EditValueChanged;

            gridControlChiTiet.DataSource = _chiTietDonhang;
            gridViewChiTiet.ActiveFilterString = string.Format("[IsActived] = '{0}'", true);

            CheckDonHangUSD();

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

            // Check chot donhang
            if (_domainData.TrangThai == Define.TrangThaiDonHang.Moi.ToString())
            {
                var confirmChotDhDialog = MessageBox.Show(Define.MESSAGE_CHOT_HOA_DON, Define.MESSAGE_CHOT_HOA_DON_TITLE, MessageBoxButtons.YesNo);
                if (confirmChotDhDialog == DialogResult.Yes)
                {
                    _domainData.TrangThai = Define.TrangThaiDonHang.ThanhToan.ToString();
                }
            }

            using (var transaction = new TransactionScope())
            {
                // Save Don Hang
                CRUD.DecorateSaveData(_domainData);
                CRUD.DbContext.DonHangs.AddOrUpdate(_domainData);

                // Save chi tiet Don Hang
                foreach (var chiTietDonHang in _chiTietDonhang)
                {
                    CRUD.DecorateSaveData(chiTietDonHang);
                    chiTietDonHang.DonHangId = _domainData.Id;
                    CRUD.DbContext.ChiTietDonHangs.AddOrUpdate(chiTietDonHang);
                    CRUD.DbContext.SaveChanges();

                    // Cap nhat hang trong kho
                    if (_domainData.TrangThai == Define.TrangThaiDonHang.ThanhToan.ToString()
                        && chiTietDonHang.IsActived)
                    {
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
                if (_domainData.TrangThai == Define.TrangThaiDonHang.ThanhToan.ToString())
                {
                    var congNo = (long)DonHang_No.EditValue;
                    if (congNo > 0)
                    {
                        // Add Cong no moi
                        var congNoHienTai = new CongNo();
                        congNoHienTai.No = Math.Abs(congNo);

                        CRUD.DecorateSaveData(congNoHienTai);
                        congNoHienTai.DonHangId = _domainData.Id;
                        congNoHienTai.KhachHangId = _domainData.KhachHangId;
                        congNoHienTai.NgayLap = _domainData.NgayLap;
                        congNoHienTai.LoaiDonHang = _domainData.LoaiDonHang;
                        congNoHienTai.GhiChu = _domainData.GhiChu;
                        congNoHienTai.LoaiTienTe = _domainData.LoaiTienTe;
                        CRUD.DbContext.CongNoes.AddOrUpdate(congNoHienTai);
                        CRUD.DbContext.SaveChanges();
                    }
                }

                CRUD.DbContext.SaveChanges();
                transaction.Complete();
            }

            //if (_domainData.TrangThai == Define.TrangThaiDonHang.ThanhToan.ToString())
            //{
            //    var confirmDialog = MessageBox.Show(Define.MESSAGE_IN_HOA_DON, Define.MESSAGE_IN_HOA_DON_TITLE, MessageBoxButtons.YesNo);
            //    if (confirmDialog == DialogResult.Yes)
            //    {
            //        InHoaDon();
            //    }
            //}

            // Update grid view
            ReturnObject = _domainData;

            return true;
        }

        public string ValidateInput()
        {
            if (_domainData == null) return "Chưa có dữ liệu";

            if (string.IsNullOrEmpty(DonHang_KhachHangId.Text))
            {
                return string.Format("Không được phép để trống {0}!", lblKhachHangId.Text);
            }
            if (string.IsNullOrEmpty(DonHang_LoaiTienTe.Text))
            {
                return string.Format("Không được phép để trống {0}!", lblLoaiTienTe.Text);
            }
            if (_chiTietDonhang.Count(s=>s.IsActived) == 0)
            {
                return "Chưa nhập hàng hóa cho đơn hàng";
            }

            foreach (var chiTietDonHang in _chiTietDonhang)
            {
                if (!chiTietDonHang.IsActived) continue;
                if (chiTietDonHang.HangHoaId == 0)
                {
                    return "Không được để trống hàng hóa";
                }
                if (chiTietDonHang.SoLuong <= 0)
                {
                    return "Số lượng phải > 0";
                }
                if (_loaiDonHang == Define.LoaiDonHangEnum.XuatKho)
                {
                    if (chiTietDonHang.SoLuongTon < chiTietDonHang.SoLuong)
                    {
                        return string.Format("Không đủ hàng. Chỉ còn {0} {1} trong kho", chiTietDonHang.SoLuongTon, chiTietDonHang.TenHangHoa);
                    }
                }
                if (_domainData.TrangThai == Define.TrangThaiDonHang.Moi.ToString()
                    && !chiTietDonHang.KhoHang.IsActived)
                {
                    return string.Format("{0} hiện đã ngưng kinh doanh.", chiTietDonHang.TenHangHoa);
                }
            }

            //if (_domainData.ThanhToan > 0)
            //{
            //    var congNoDangThanhToan = _domainData.CongNoes.Any(s => s.ThanhToanCongNoes.Any());
            //    if (congNoDangThanhToan)
            //    {
            //        return string.Format("Đơn hàng này đang trong quá trình thanh toán nên không thể chỉnh sửa!");
            //    }
            //}

            if (_domainData.ThanhToan > _domainData.TongCong)
            {
                return "Số tiền thanh toán lớn hơn giá trị đơn hàng.";
            }

            if (_domainData.KhachHangId == Define.KhachLeId
                && _domainData.ThanhToan < _domainData.TongCong)
            {
                return "Khách lẻ không được nợ tiền";
            }

            return string.Empty;
        }

        private void UpdateTongTien()
        {
            var thanhTien = _chiTietDonhang.Where(s=>s.IsActived).Sum(s => s.ThanhTien);
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

            _domainData.TongCong = (long)(thanhTien + thanhTien * thue / 100f - thanhTien * chietKhau / 100f);
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
            var index = gridViewChiTiet.GetFocusedDataSourceRowIndex();
            if (_chiTietDonhang.Count > 0)
            {
                var data = _chiTietDonhang[index];
                if (data.Id == 0)
                {
                    _chiTietDonhang.Remove(data);
                }
                else
                {
                    data.IsActived = false;
                }
                UpdateTongTien();
                gridControlChiTiet.Refresh();
            }
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
            if (lookupEdit != null)
            {
                var hangHoaId = lookupEdit.Properties.KeyValue;
                var row = gridViewChiTiet.GetFocusedRow() as ChiTietDonHang;
                if (row == null) return;
                var hangHoa = CRUD.DbContext.KhoHangs.Find(hangHoaId);

                if (hangHoa == null) return;
                row.KhoHang = hangHoa;
                if (!_isUsd)
                {
                    row.DonGia = hangHoa.GiaBan;
                }
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
                if (khachHangInfo != null && _domainData != null)
                {
                    _domainData.KhachHangId = selectedValue;
                    _domainData.DiaChi = khachHangInfo.DiaChi;
                    _domainData.Dienthoai = khachHangInfo.Dienthoai;
                    _domainData.GhiChu = khachHangInfo.GhiChu;
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

        public void InHoaDon()
        {
            if (_domainData == null) return;
            var report = new ReportDonHang();
            var dataSource = _domainData
                                .ChiTietDonHangs.Where(s=>s.IsActived)
                                .SelectMany(s => s.ChiTietHangHoas.Where(c=>c.IsActived)).ToList();
            report.DataSource = dataSource;
            report.ShowPreviewDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_domainData != null)
            {
                var confirmDialog = MessageBox.Show(Define.MESSAGE_XOA_HOA_DON, Define.MESSAGE_XOA_HOA_DON_TITLE, MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    DeleteDonhang(_domainData);
                    ReturnObject = _domainData;
                    CloseForm();
                }
            }
        }

        public void DeleteDonhang(DonHang donHang)
        {
            using (var transaction = new TransactionScope())
            {
                donHang.IsActived = false;

                if (donHang.TrangThai == Define.TrangThaiDonHang.ThanhToan.ToString())
                {
                    // Update hang hoa
                    foreach (var chiTietDonHang in donHang.ChiTietDonHangs)
                    {
                        chiTietDonHang.IsActived = false;
                        var sign = donHang.LoaiDonHang == "NhapKho" ? -1 : 1;
                        chiTietDonHang.KhoHang.SoLuong = Math.Max(chiTietDonHang.KhoHang.SoLuong + sign * chiTietDonHang.SoLuong, 0);

                        foreach (var chiTietHangHoa in chiTietDonHang.ChiTietHangHoas)
                        {
                            chiTietHangHoa.IsActived = false;
                        }
                    }

                    // Update CongNo
                    foreach (var congNo in donHang.CongNoes)
                    {
                        congNo.IsActived = false;
                        foreach (var thanhToanCongNo in congNo.ThanhToanCongNoes)
                        {
                            thanhToanCongNo.IsActived = false;
                        }
                    }
                }
                
                CRUD.DbContext.SaveChanges();
                transaction.Complete();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (_domainData != null)
            {
                InHoaDon();
            }
        }

        private void GenerateMaDH()
        {
            if(_domainData != null && string.IsNullOrEmpty(_domainData.MaDH))
            {
                var currentDatetime = TimeHelper.CurentDateTime();
                var year = currentDatetime.ToString("yy");
                var month = currentDatetime.ToString("MM");
                var date = currentDatetime.ToString("dd");
                var hour = currentDatetime.ToString("HH");
                var minute = currentDatetime.ToString("mm");
                var second = currentDatetime.ToString("ss");
                _domainData.MaDH = string.Format("{0}{1}{2}{3}{4}{5}", year, month, date, hour, minute, second);
            }
        }

        private void gridViewChiTiet_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var data = gridViewChiTiet.GetRow(e.RowHandle) as ChiTietDonHang;
            if (data != null)
            {
                data.IsActived = true;
                data.DonHang = _domainData;
            }
        }

        private void DonHang_LoaiTienTe_SelectedValueChanged(object sender, EventArgs e)
        {
            CheckDonHangUSD();
        }

        private void CheckDonHangUSD()
        {
            if (DonHang_LoaiTienTe.SelectedValue != null)
            {
                _isUsd = DonHang_LoaiTienTe.SelectedValue.ToString() == Define.LoaiTienTeEnum.USD.ToString();
                DonHang_TyGia.Enabled = _isUsd;
                gridViewChiTiet.Columns["ThanhTienVND"].Visible = _isUsd;
                if (_domainData != null && _domainData.TyGia == 0)
                {
                    _domainData.TyGia = 1;
                }
            }
        }

        private void DonHang_TyGia_EditValueChanged(object sender, EventArgs e)
        {
            gridViewChiTiet.RefreshData();
        }
    }
}
