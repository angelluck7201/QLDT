using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.FormControls.UserAccountForms
{
    public partial class UcUserAccountList : UserControl
    {
        public UcUserAccountList()
        {
            InitializeComponent();
            ReloadData();
            ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, ReloadData);
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                CRUD.DisposeDb();
                gridControlUser.DataSource = CRUD.DbContext.UserAccounts.ToList();
            });
        }

        private void gridViewUser_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewUser.GetRow(gridViewUser.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.UserAccounts.Find(data.Id);
                    FormBehavior.GenerateForm(new UcUserAccount(info), "Thông Tin Người Dùng", this.ParentForm);
                }
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcUserAccount(), "Thông Tin Người Dùng", this.ParentForm);
        }
    }
}
