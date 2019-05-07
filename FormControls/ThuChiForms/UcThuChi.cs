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

namespace QLDT.FormControls.ThuChiForms
{
    public partial class UcThuChi : BaseUserControl
    {
        private readonly ThuChi _domainData;

        public UcThuChi(long noiDungId, ThuChi data = null)
        {
            InitializeComponent();

            ThuChi_NoiDungId.DisplayMember = "Ten";
            ThuChi_NoiDungId.ValueMember = "Id";
            ThuChi_NoiDungId.DataSource = new BindingSource(CRUD.DbContext.DanhMucs.Where(s => s.Loai == Define.LoaiDanhMucEnum.ThuChi.ToString() && s.IsActived).ToList(), null);

            ThuChi_Loai.DisplayMember = "Value";
            ThuChi_Loai.ValueMember = "Key";
            ThuChi_Loai.DataSource = new BindingSource(Define.LoaiThuChiDict, null);

            _domainData = data;
            if (_domainData == null)
            {
                _domainData = new ThuChi();
                _domainData.NgayLap = TimeHelper.CurentDateTime();
                _domainData.Loai = Define.LoaiThuChiEnum.Thu.ToString();
                _domainData.NoiDungId = noiDungId;
            }

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
            CRUD.DbContext.ThuChis.AddOrUpdate(_domainData);
            CRUD.DbContext.SaveChanges();

            ReturnObject = _domainData;

            return true;
        }

        public string ValidateInput()
        {
            if (_domainData.NoiDungId <= 0)
            {
                ThuChi_NoiDungId.Focus();
                return "Chưa Nhập Nội Dung";
            }

            if (string.IsNullOrEmpty(_domainData.Loai))
            {
                ThuChi_Loai.Focus();
                return "Chưa Chọn Loại Thu Chi";
            }
            return string.Empty;
        }
    }
}
