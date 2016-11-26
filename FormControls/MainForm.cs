using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.DashboardCommon.Native;
using DevExpress.XtraBars.Navigation;
using QLDT.FormControls.KhoHangForms;
using QLDT.FormControls.NhapKhoForms;
using QLDT.FormControls.TheKhoForms;
using QLDT.FormControls.ThongKeForms;
using QLDT.FormControls.ThuChiForms;
using QLDT.FormControls.UserAccountForms;
using QLDT.FormControls.XuatKhoForms;

namespace QLDT.FormControls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AutoScaleDimensions = new SizeF(6f, 13f);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // Disable main form
            this.Enabled = false;

            // Check login
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        public void InitLogin()
        {
            var loginUser = Authorization.LoginUser;
            this.Text = string.Format("{0} - {1} - {2}", "Minh Phát", loginUser.TenNhanVien, loginUser.LoaiNguoiDung);
            navResetPass.Caption = string.Format("{0} - {1}", loginUser.TenNguoiDung, loginUser.TenNhanVien);
            var isInitFirstForm = false;
            foreach (NavButton button in tileNavPane1.Buttons)
            {
                var featureName = button.Name.Replace("nav", "");
                if (!Authorization.IsHavePermission(featureName, Define.PermissionEnum.View.ToString()))
                {
                    button.Visible = false;
                }
                else if (!isInitFirstForm)
                {
                    isInitFirstForm = true;
                    var methods = typeof(NavButton).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault(s => s.Name == "OnElementClick");
                    if (methods != null) methods.Invoke(button, new object[] { true});

                }
            }

            this.Enabled = true;

        }

        private void AddControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            splitContainerControl1.Panel2.Controls.Clear();
            splitContainerControl1.Panel2.Controls.Add(userControl);
        }

        private void navKhoHang_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddControl(new UcKhoHangList());
        }

        private void navNhapKho_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddControl(new UcNhapKho());
        }

        private void navXuatKho_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddControl(new UcXuatKho());
        }

        private void navThongKe_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddControl(new UcThongKe());
        }

        private void navTheKho_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddControl(new UcTheKho());
        }

        private void navThuChi_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddControl(new UcThuChiList());
        }

        private void navUserAccont_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            AddControl(new UcUserAccountList());
        }

        private void navResetPass_ElementClick(object sender, NavElementEventArgs e)
        {
            FormBehavior.GenerateForm(new UcResetPass(), "Thông Tin Người Dùng", this);
        }


    }
}