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

namespace QLDT.FormControls.UserAccountForms
{
    public partial class UcResetPass : BaseUserControl
    {
        public UcResetPass()
        {
            InitializeComponent();
            Init(Authorization.LoginUser);
        }

        public override bool SaveData()
        {
            var validateResult = ValidateInput();
            if (!string.IsNullOrEmpty(validateResult))
            {
                MessageBox.Show(validateResult);
                return false;
            }

            Authorization.LoginUser.MatKhau = txtNewPass.Text.Trim();
            CRUD.DbContext.UserAccounts.AddOrUpdate(Authorization.LoginUser);
            CRUD.DbContext.SaveChanges();

            return true;
        }

        public string ValidateInput()
        {
            if (string.IsNullOrEmpty(txtOldPass.Text))
            {
                return string.Format("{0} {1}!", "Không được phép để trống", lblOldPass.Text);
            }
            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                return string.Format("{0} {1}!", "Không được phép để trống", lblNewPass.Text);
            }
            if (txtOldPass.Text.Trim() != Authorization.LoginUser.MatKhau)
            {
                return string.Format("{0} {1}!", lblOldPass.Text, "không chính xác");
            }

            return string.Empty;
        }


    }
}
