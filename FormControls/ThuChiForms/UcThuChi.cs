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

        public UcThuChi(ThuChi data = null)
        {
            InitializeComponent();

            ThuChi_NoiDungId.DisplayMember = "Ten";
            ThuChi_NoiDungId.ValueMember = "Id";
            ThuChi_NoiDungId.DataSource = new BindingSource(CRUD.DbContext.DanhMucs.Where(s => s.Loai == Define.LoaiDanhMucEnum.ThuChi.ToString()).ToList(), null);

            ThuChi_Loai.DisplayMember = "Value";
            ThuChi_Loai.ValueMember = "Key";
            ThuChi_Loai.DataSource = new BindingSource(Define.LoaiThuChiDict, null);

            Init(data);
            if (data != null)
            {
                ThuChi_Loai.SelectedValue = PrimitiveConvert.StringToEnum<Define.LoaiThuChiEnum>(data.Loai);
            }

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

            var saveData = CRUD.GetFormObject<ThuChi>(FormControls);
            CRUD.DecorateSaveData(saveData, _domainData);
            CRUD.DbContext.ThuChis.AddOrUpdate(saveData);
            CRUD.DbContext.SaveChanges();

            return true;
        }

        public string ValidateInput()
        {
            return string.Empty;
        }
    }
}
