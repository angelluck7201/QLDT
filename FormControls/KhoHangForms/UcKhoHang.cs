using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace QLDT.FormControls.KhoHangForms
{
    public partial class UcKhoHang : BaseUserControl
    {
        private KhoHang _domainData;

        public UcKhoHang(long defaultSelected, KhoHang data = null)
        {
            InitializeComponent();

            var selectedLoaiHang = data?.LoaiHangId ?? -1;

            KhoHang_LoaiHangId.DisplayMember = "Ten";
            KhoHang_LoaiHangId.ValueMember = "Id";
            var lstLoaiHang =
                CRUD.DbContext.DanhMucs.Where(s => (s.IsActived || s.Id == selectedLoaiHang)
                && s.Loai == Define.LoaiDanhMucEnum.DienThoai.ToString())
                    .ToList();
            KhoHang_LoaiHangId.DataSource = new BindingSource(lstLoaiHang, null);

            _domainData = data;
            if (_domainData == null)
            {
                _domainData = new KhoHang();
                _domainData.LoaiHangId = defaultSelected;
                _domainData.IsActived = true;
            }
            Init(_domainData);

            btnNgungKinhDoanh.Text = _domainData.IsActived ? "Ngưng Kinh Doanh" : "Tiếp Tục Kinh Doanh";
        }

        public override bool SaveData()
        {
            var validateResult = ValidateInput();
            if (!string.IsNullOrEmpty(validateResult))
            {
                MessageBox.Show(validateResult);
                return false;
            }

            CRUD.DecorateSaveData(_domainData);
            _domainData.DonViTinh = Define.DVTEnum.Cai.ToString();
            CRUD.DbContext.KhoHangs.AddOrUpdate(_domainData);
            CRUD.DbContext.SaveChanges();

            ReturnObject = _domainData;

            return true;
        }

        public string ValidateInput()
        {
            if (string.IsNullOrEmpty(KhoHang_TenHang.Text))
            {
                return string.Format("Không được phép để trống {0}!", lblTenHang.Text);
            }
            if (string.IsNullOrEmpty(KhoHang_GiaBan.Text))
            {
                return string.Format("Không được phép để trống {0}!", lblGiaBan.Text);
            }
            if (KhoHang_LoaiHangId.SelectedValue == null)
            {
                return string.Format("Giá trị ở {0} không hợp lệ!", lblLoaiHangId.Text);
            }
            if (CheckDuplicate(KhoHang_TenHang.Text))
            {
                return string.Format("{0} đã tồn tại trong hệ thống!", KhoHang_TenHang.Text);
            }

            return string.Empty;
        }

        private bool CheckDuplicate(string tenHang)
        {
            var checkData = tenHang.Trim();
            if (_domainData != null)
            {
                return CRUD.DbContext.KhoHangs.Any(s => s.Id != _domainData.Id && s.TenHang == checkData);
            }
            return CRUD.DbContext.KhoHangs.Any(s => s.TenHang == checkData);
        }

        private void btnNgungKinhDoanh_Click(object sender, System.EventArgs e)
        {
            if (_domainData.IsActived)
            {
                var confirmDialog = MessageBox.Show(
                    string.Format(Define.MESSAGE_NGUNG_KINH_DOANH, _domainData.TenHang),
                    Define.MESSAGE_NGUNG_KINH_DOANH_TITLE, MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    _domainData.IsActived = false;
                    btnSave.PerformClick();
                }
            }
            else
            {
                _domainData.IsActived = true;
                btnSave.PerformClick();
            }

        }
    }
}
