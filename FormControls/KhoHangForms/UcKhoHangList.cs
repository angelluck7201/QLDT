using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.FormControls.KhoHangForms
{
    public partial class UcKhoHangList : UserControl
    {
        private List<DanhMuc> _danhMucs = new List<DanhMuc>();
        private List<KhoHang> _khoHangs = new List<KhoHang>();

        public UcKhoHangList()
        {
            InitializeComponent();
            InitAuthorize();
            ReloadData();
            ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, ReloadData);
        }

        private void InitAuthorize()
        {
            if (!Authorization.IsHavePermission(Define.FeatureEnum.KhoHang.ToString(), Define.PermissionEnum.Write.ToString()))
            {
                btnAddHangHoa.Visible = false;
                btnAddNhomHang.Visible = false;
            }

            btnRefresh.Visible = false;
            if (Authorization.LoginUser.LoaiNguoiDung == Define.LoaiNguoiDung.Admin.ToString())
            {
                btnRefresh.Visible = true;
            }
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                CRUD.DisposeDb();

                _danhMucs = CRUD.DbContext.DanhMucs.Where(s => s.IsActived && s.Loai == Define.LoaiDanhMucEnum.DienThoai.ToString()).ToList();
                _danhMucs.Add(new DanhMuc() { Ten = "Tất cả"});
                _danhMucs.Add(new DanhMuc() { Ten = "Ngưng Kinh Doanh" });
                
                _khoHangs = CRUD.DbContext.KhoHangs.ToList();

                gridControlLoaiHang.DataSource = _danhMucs;
                gridControlHangHoa.DataSource = _khoHangs;
            });
        }

        private void btnAddNhomHang_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcNhomHang(Define.LoaiDanhMucEnum.DienThoai), "Nhóm Hàng", this.ParentForm);
        }

        private void btnAddHangHoa_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcKhoHang(), "Kho Hàng", this.ParentForm);
        }

        private void gridViewLoaiHang_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewLoaiHang.GetRow(gridViewLoaiHang.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.DanhMucs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcNhomHang(Define.LoaiDanhMucEnum.DienThoai, info), "Nhóm Hàng", this.ParentForm);
                }
            });
        }


        private void gridViewHangHoa_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewHangHoa.GetRow(gridViewHangHoa.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.KhoHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcKhoHang(info), "Kho Hàng", this.ParentForm);
                }
            });
        }

        private void gridViewLoaiHang_Click(object sender, EventArgs e)
        {
            dynamic data = gridViewLoaiHang.GetRow(gridViewLoaiHang.FocusedRowHandle);
            if (data != null && data.Id != null)
            {
                if (data.Ten == "Tất cả")
                {
                    gridViewHangHoa.ActiveFilterString = string.Format("[IsActived] = '{0}'", true);
                }
                else if (data.Ten == "Ngưng Kinh Doanh")
                {
                    gridViewHangHoa.ActiveFilterString = string.Format("[IsActived] = '{0}'", false);
                }
                else
                {
                    gridViewHangHoa.ActiveFilterString = string.Format("[LoaiHangId] = '{0}' && [IsActived] = '{1}'", data.Id, true);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                var chitietHangHoa = CRUD.DbContext.ChiTietDonHangs.ToList();
                foreach (var khoHang in _khoHangs)
                {
                    var tongNhap = chitietHangHoa.Where(s => s.IsActived && s.HangHoaId == khoHang.Id && s.DonHang.LoaiDonHang == Define.LoaiDonHangEnum.NhapKho.ToString()).Sum(s=>s.SoLuong);
                    var tongXuat = chitietHangHoa.Where(s => s.IsActived && s.HangHoaId == khoHang.Id && s.DonHang.LoaiDonHang == Define.LoaiDonHangEnum.XuatKho.ToString()).Sum(s => s.SoLuong);
                    khoHang.SoLuong = tongNhap - tongXuat;
                    CRUD.DbContext.KhoHangs.AddOrUpdate(khoHang);
                }
                CRUD.DbContext.SaveChanges();
            });
        }
    }
}
