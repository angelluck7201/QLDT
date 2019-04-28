using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace QLDT.FormControls.CongNoForms
{
    public partial class UcCongNo : BaseUserControl
    {
        private KhachHang _domainData;
        private List<ThanhToanCongNo> _thanhToanCongNoes = new List<ThanhToanCongNo>();
        private List<CongNo> _congNoes = new List<CongNo>();

        public UcCongNo(Define.LoaiDonHangEnum loaiDonHang, Define.LoaiTienTeEnum loaiTienTe, KhachHang data)
        {
            InitializeComponent();
            Init(data);

            _domainData = data;
            _domainData.LoaiTienTe = loaiTienTe.ToString();
            if (loaiDonHang == Define.LoaiDonHangEnum.XuatKho)
            {
                lblKhachHangId.Text = "Khách Hàng";
            }

            // Khoi tao thong tin khach hang
            KhachHang.Text = data.Ten;
            GhiChu.Text = _domainData.GhiChu;

            _congNoes = data.CongNoes.Where(l => l.IsActived && l.ConLai > 0 && l.LoaiTienTe == _domainData.LoaiTienTe).ToList();

            TongCong.EditValue = _congNoes.Sum(l=>l.ConLai);
            gridControlChiTiet.DataSource = _congNoes;

            _thanhToanCongNoes = _domainData.ThanhToanCongNoes.Where(l=>l.IsActived && l.CongNo.LoaiTienTe == _domainData.LoaiTienTe).ToList();
            gridControlNhatKy.DataSource = _thanhToanCongNoes;
        }

        public override bool SaveData()
        {
            var validateResult = ValidateInput();
            if (!string.IsNullOrEmpty(validateResult))
            {
                MessageBox.Show(validateResult, "Không hợp lệ.",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var ghichu = ThanhToanCongNo_GhiChu.Text;
            var ngayThanhToan = ThanhToanCongNo_NgayThanhToan.Value;
            var khachHangId = _domainData.Id;
            using (var transaction = new TransactionScope())
            {
                foreach (var congNo in _congNoes)
                {
                    if (congNo.ThanhToanNo > 0)
                    {
                        var thanhToanCongNo = new ThanhToanCongNo();
                        thanhToanCongNo.ThanhToan = congNo.ThanhToanNo;
                        thanhToanCongNo.KhachHangId = khachHangId;
                        thanhToanCongNo.NgayThanhToan = ngayThanhToan;
                        thanhToanCongNo.GhiChu = ghichu;
                        thanhToanCongNo.CongNoId = congNo.Id;
                        CRUD.DecorateSaveData(thanhToanCongNo);
                        CRUD.DbContext.ThanhToanCongNoes.AddOrUpdate(thanhToanCongNo);

                        congNo.ThanhToan += congNo.ThanhToanNo;
                        congNo.ThanhToanNo = 0;

                        CRUD.DecorateSaveData(congNo);
                        CRUD.DbContext.CongNoes.AddOrUpdate(congNo);
                    }
                }
                CRUD.DbContext.SaveChanges();
                transaction.Complete();
            }
            ReturnObject = _domainData;

            return true;
        }

       
        public string ValidateInput()
        {
            if (string.IsNullOrEmpty(ThanhToanCongNo_ThanhToan.Text))
            {
                return string.Format("Không được phép để trống {0}!", lblThanhToan.Text);
            }
            var thanhToan = PrimitiveConvert.StringToInt(ThanhToanCongNo_ThanhToan.Text);
            if (thanhToan <= 0)
            {
                return string.Format("Chưa nhập {0}!", lblThanhToan.Text);
            }

            var no = _congNoes.Sum(s => s.No);

            if (thanhToan > no)
            {
                return string.Format("Số tiền thanh toán {0} lớn hơn số tiền nợ {1}!",thanhToan.ToString("n0"), no.ToString("n0"));
            }

            var tienChuaPhanBo = PrimitiveConvert.StringToInt(txtConLai.Text);
            if (tienChuaPhanBo > 0)
            {
                return string.Format("Còn {0} tiền chưa được phân bổ!", tienChuaPhanBo.ToString("n0"));
            }

            return string.Empty;
        }

        private void gridViewChiTiet_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            var grid = sender as GridView;
            var row = grid.GetRow(e.RowHandle) as CongNo;

            if (row.ThanhToanNo < 0)
            {
                grid.SetColumnError(grid.Columns["ThanhToanNo"], "Không được nhập nhỏ hơn 0.", ErrorType.Critical);
                e.Valid = false;
                return;
            }

            if (row.ThanhToanNo > row.ConLai)
            {
                grid.SetColumnError(grid.Columns["ThanhToanNo"], "Không được nhập lớn hơn nợ còn lại.", ErrorType.Critical);
                e.Valid = false;
                return;
            }

            UpdateThongTin();
        }

        private void gridViewChiTiet_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void ThanhToanCongNo_ThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            UpdateThongTin();
        }

        private void UpdateThongTin()
        {
            var thanhToan = PrimitiveConvert.StringToInt(ThanhToanCongNo_ThanhToan.Text);
            var thanhToanNo = _congNoes.Sum(l => l.ThanhToanNo);
            var conLai = thanhToan - thanhToanNo;
            txtTienKhachTra.Text = thanhToan.ToString("n0");
            txtDaThanhToan.Text = thanhToanNo.ToString("n0");
            txtConLai.Text = conLai.ToString("n0");
        }
    }
}
