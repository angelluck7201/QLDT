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
        private readonly KhachHang _domainData;
        private readonly Define.LoaiKhachHangEnum _loaiKhachHang;

        public UcKhachHang(Define.LoaiKhachHangEnum loaiKhachHang, KhachHang data = null)
        {
            InitializeComponent();

            Init(data);

            _loaiKhachHang = loaiKhachHang;
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

            var saveData = CRUD.GetFormObject<KhachHang>(FormControls);
            CRUD.DecorateSaveData(saveData, _domainData);
            saveData.LoaiKhachHang = _loaiKhachHang.ToString();
            if (_domainData != null)
            {
                saveData.Id = _domainData.Id;
            }
            CRUD.DbContext.KhachHangs.AddOrUpdate(saveData);
            CRUD.DbContext.SaveChanges();
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
