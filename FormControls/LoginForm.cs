using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.FormControls
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AutoScaleDimensions = new SizeF(6f, 13f);

            txtUserName.Focus();
            txtPass.Properties.PasswordChar = '*';
        }


        private void ShowMainForm()
        {
            FormBehavior.MainForm.InitLogin();
            this.Dispose();
        }

        private void CheckLogin()
        {
            var userName = txtUserName.Text;
            var pass = txtPass.Text;
            var isLoginOk = Authorization.CheckLogin(userName, pass);
            if (isLoginOk)
            {
                ShowMainForm();
                lblErrorMessage.Visible = false;
            }
            else
            {
                lblErrorMessage.Visible = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckLogin();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckLogin();
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckLogin();
            }
        }
    }
}
