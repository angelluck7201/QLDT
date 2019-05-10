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
            EndDate.Value = TimeHelper.CurentDateTime();
            StartDate.Value = EndDate.Value.AddYears(-1);
            ReloadData();
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                var startDate = StartDate.Value;
                var endDate = EndDate.Value;
                gridControlHangHoa.DataSource = CRUD.DbContext.ChiTietHangHoas.Where(s=>s.ChiTietDonHang.DonHang.NgayLap >= startDate 
                                                                                            && s.ChiTietDonHang.DonHang.NgayLap <= endDate).ToList();
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
                    FormBehavior.GenerateForm(new UcDonHang(loaiDonHang, info), data.LoaiPhieu, this.ParentForm, this.Name);
                }
            });
        }

        private void btnNhapKhoLoc_Click(object sender, System.EventArgs e)
        {
            ReloadData();
        }
    }
}
