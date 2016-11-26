using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLDT.FormControls.DonHangForms;

namespace QLDT.FormControls.TheKhoForms
{
    public partial class UcTheKho : UserControl
    {
        public UcTheKho()
        {
            InitializeComponent();
            ReloadData();
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                CRUD.DisposeDb();
                gridControlHangHoa.DataSource = CRUD.DbContext.ChiTietHangHoas.ToList();
            });
        }

        private void gridViewHangHoa_DoubleClick(object sender, System.EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewHangHoa.GetRow(gridViewHangHoa.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.DonHangs.Find(data.DonHangId);
                    var loaiDonHang = PrimitiveConvert.StringToEnum<Define.LoaiDonHangEnum>(info.LoaiDonHang);
                    FormBehavior.GenerateForm(new UcDonHang(loaiDonHang, info), data.LoaiPhieu, this.ParentForm);
                }
            });
        }

        private void btnNhapKhoLoc_Click(object sender, System.EventArgs e)
        {
            var startDate = TimeHelper.StringToTimeStamp(StartDate.Text);
            var endDate = TimeHelper.StringToTimeStamp(EndDate.Text) + TimeHelper.MILISECOND_PER_DAY - 1;
            gridViewHangHoa.ActiveFilterString = string.Format("[NgayLap] >= '{0}' AND [NgayLap] <= '{1}'", startDate, endDate);
            btnNhapKhoLoc.Appearance.BackColor = Color.Silver;
        }

        private void btnNhapKhoBoLoc_Click(object sender, System.EventArgs e)
        {
            gridViewHangHoa.ActiveFilterString = "";
            btnNhapKhoLoc.Appearance.BackColor = SystemColors.MenuHighlight;
        }
    }
}
