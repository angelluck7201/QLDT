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

namespace QLDT.FormControls.KhachHangForms
{
    public partial class UcKhachHang : BaseUserControl
    {
        private  KhachHang _domainData;

        public UcKhachHang(Define.LoaiKhachHangEnum loaiKhachHang, KhachHang data = null)
        {
            _domainData = data;

            if (_domainData == null)
            {
                _domainData = new KhachHang();
            }
            _domainData.LoaiKhachHang = loaiKhachHang.ToString();

            InitializeComponent();
            Init(_domainData);
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
            CRUD.DbContext.KhachHangs.AddOrUpdate(_domainData);
            CRUD.DbContext.SaveChanges();

            ReturnObject = _domainData;
            return true;
        }

        public string ValidateInput()
        {
            if (string.IsNullOrEmpty(KhachHang_Ten.Text))
            {
                return string.Format("{0} {1}!", "Không được phép để trống", lblTen.Text);
            }

            return string.Empty;
        }
    }
}
