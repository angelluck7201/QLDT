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

namespace QLDT.FormControls.UserAccountForms
{
    public partial class UcUserAccount : BaseUserControl
    {
        private UserAccount _domainData;
        private BindingList<PhanQuyenNguoiDung> phanQuyenNguoiDungs = new BindingList<PhanQuyenNguoiDung>();

        public UcUserAccount(UserAccount data = null)
        {
            InitializeComponent();
            Init(data);
            if (data != null)
            {
                phanQuyenNguoiDungs = new BindingList<PhanQuyenNguoiDung>(data.PhanQuyenNguoiDungs.ToList());
                UserAccount_TenNguoiDung.Enabled = false;
                if (!(bool)data.IsActived)
                {
                    btnLock.Text = "Mở Khóa";
                }
            }
            else
            {
                phanQuyenNguoiDungs = new BindingList<PhanQuyenNguoiDung>(InitPhanQuyen());
                btnLock.Visible = false;
                btnReset.Visible = false;
            }
            FormBehavior.DecoreateLookEdit(listPermission, Define.PermissionDict, "Value", "Key");
            gridControlPermission.DataSource = phanQuyenNguoiDungs;

            _domainData = data;
        }

        public List<PhanQuyenNguoiDung> InitPhanQuyen()
        {
            var lstPhanQuyen = new List<PhanQuyenNguoiDung>();
            foreach (var value in Enum.GetValues(typeof(Define.FeatureEnum)))
            {
                var permission = new PhanQuyenNguoiDung();
                permission.Permission = Define.PermissionEnum.None.ToString();
                permission.Feature = value.ToString();
                lstPhanQuyen.Add(permission);
            }

            return lstPhanQuyen;
        }

        public override bool SaveData()
        {
            var validateResult = ValidateInput();
            if (!string.IsNullOrEmpty(validateResult))
            {
                MessageBox.Show(validateResult);
                return false;
            }

            using (var transaction = new TransactionScope())
            {
                var saveData = CRUD.GetFormObject<UserAccount>(FormControls);
                CRUD.DecorateSaveData(saveData, _domainData);
                if (_domainData == null)
                {
                    saveData.MatKhau = Define.DefaultPassword;
                    saveData.IsActived = true;
                }
                else
                {
                    saveData.MatKhau = _domainData.MatKhau;
                    saveData.IsActived = _domainData.IsActived;
                }

                if (_domainData == null || string.IsNullOrEmpty(_domainData.LoaiNguoiDung))
                {
                    saveData.LoaiNguoiDung = Define.LoaiNguoiDung.Normal.ToString();
                }
                else
                {
                    saveData.LoaiNguoiDung = _domainData.LoaiNguoiDung;
                }
                CRUD.DbContext.UserAccounts.AddOrUpdate(saveData);
                CRUD.DbContext.SaveChanges();

                foreach (var phanQuyenNguoiDung in phanQuyenNguoiDungs)
                {
                    CRUD.DecorateSaveData(phanQuyenNguoiDung);
                    phanQuyenNguoiDung.UserAccountId = saveData.Id;
                    CRUD.DbContext.PhanQuyenNguoiDungs.AddOrUpdate(phanQuyenNguoiDung);
                }
                CRUD.DbContext.SaveChanges();

                transaction.Complete();
            }


            return true;
        }

        public string ValidateInput()
        {
            if (string.IsNullOrEmpty(UserAccount_TenNguoiDung.Text))
            {
                return string.Format("{0} {1}!", "Không được phép để trống", lblTenNguoiDung.Text);
            }
            if (string.IsNullOrEmpty(UserAccount_TenNguoiDung.Text))
            {
                return string.Format("{0} {1}!", "Không được phép để trống", lblTenNhanVien.Text);
            }

            return string.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_domainData != null)
            {
                var confirmDialog = MessageBox.Show(Define.MESSAGE_RESET_PASS, Define.MESSAGE_RESET_PASS_TITLE, MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    _domainData.MatKhau = Define.DefaultPassword;
                    CRUD.DbContext.UserAccounts.AddOrUpdate(_domainData);
                    CRUD.DbContext.SaveChanges();
                    var parentForm = this.ParentForm;
                    if (parentForm != null) parentForm.Close();
                }
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (_domainData != null)
            {
                var confirmDialog = MessageBox.Show(Define.MESSAGE_LOCK_USER, Define.MESSAGE_LOCK_USER_TITLE, MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    _domainData.IsActived = !_domainData.IsActived;
                    CRUD.DbContext.UserAccounts.AddOrUpdate(_domainData);
                    CRUD.DbContext.SaveChanges();
                    var parentForm = this.ParentForm;
                    if (parentForm != null) parentForm.Close();
                }
            }
        }
    }
}
