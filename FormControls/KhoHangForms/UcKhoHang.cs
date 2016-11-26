using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace QLDT.FormControls.KhoHangForms
{
    public partial class UcKhoHang : BaseUserControl
    {
        private readonly KhoHang _domainData;

        public UcKhoHang(KhoHang data = null)
        {
            InitializeComponent();

            KhoHang_LoaiHangId.DisplayMember = "Ten";
            KhoHang_LoaiHangId.ValueMember = "Id";
            KhoHang_LoaiHangId.DataSource = new BindingSource(CRUD.DbContext.DanhMucs.Where(s => s.Loai == Define.LoaiDanhMucEnum.DienThoai.ToString()).ToList(), null);

            Init(data);

            _domainData = data;
        }

        public override bool SaveData()
        {
            var validateResult = ValidateInput();
            if (!string.IsNullOrEmpty(validateResult))
            {
                MessageBox.Show(validateResult);
                return false;
            }

            using (var dbContext = new QLDTEntities())
            {
                var saveData = CRUD.GetFormObject<KhoHang>(FormControls);
                CRUD.DecorateSaveData(saveData, _domainData);
                if (_domainData != null)
                {
                    saveData.Id = _domainData.Id;
                    saveData.SoLuong = _domainData.SoLuong;
                }
                else
                {
                    saveData.SoLuong = 0;
                }

                saveData.DonViTinh = Define.DVTEnum.Cai.ToString();
                dbContext.KhoHangs.AddOrUpdate(saveData);
                dbContext.SaveChanges();
            }
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
    }
}
