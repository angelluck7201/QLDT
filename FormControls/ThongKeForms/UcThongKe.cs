using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace QLDT.FormControls.ThongKeForms
{
    public partial class UcThongKe : UserControl
    {
        private string _curPage = "tabTKHangHoa";
        private List<ThongKeViewModel> _lstThongKe = new List<ThongKeViewModel>();
        Dictionary<Define.LoaiThongKeEnum, object> _cacheThongKe = new Dictionary<Define.LoaiThongKeEnum, object>();
        private Define.LoaiThongKeEnum _loaiThongKe;

        private bool _isLoaded = false;
        public UcThongKe()
        {
            InitializeComponent();

            var currentDate = TimeHelper.CurentDateTime();

            EndDate.Value = currentDate;
            StartDate.Value = currentDate.AddYears(-1);

            GenerateFormatRuleByValue(gridViewHangHoa, colLoiNhuan, 0, FormatCondition.LessOrEqual, Color.Wheat, Color.Red);
            GenerateFormatRuleByValue(gridViewHangHoa, colLoiNhuan, 0, FormatCondition.Greater, Color.Honeydew, Color.Green);
        }

        public void GenerateFormatRuleByValue(GridView gridView, GridColumn column, object value, FormatCondition condition, Color backColor, Color fontColor)
        {
            GridFormatRule gridFormatRule = new GridFormatRule();
            gridFormatRule.Column = column;
            gridFormatRule.ApplyToRow = true;
            FormatConditionRuleValue formatConditionRuleValue = new FormatConditionRuleValue();
            formatConditionRuleValue.PredefinedName = value.ToString();
            formatConditionRuleValue.Condition = condition;
            formatConditionRuleValue.Value1 = value.ToString();
            formatConditionRuleValue.Appearance.BackColor = backColor;
            formatConditionRuleValue.Appearance.ForeColor = fontColor;
            formatConditionRuleValue.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue.Appearance.Options.UseForeColor = true;
            gridFormatRule.Rule = formatConditionRuleValue;
            gridView.FormatRules.Add(gridFormatRule);
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                _lstThongKe = new List<ThongKeViewModel>();

                var thongKeDonHang = CRUD.DbContext.ChiTietDonHangs
                    .Where(s=> s.IsActived && s.DonHang.IsActived && s.DonHang.NgayLap >= StartDate.Value && s.DonHang.NgayLap <=EndDate.Value).ToList();
                _lstThongKe.AddRange(thongKeDonHang.Select(s => new ThongKeViewModel(s)));

                var thongKeThuChi = CRUD.DbContext.ThuChis.Where(s=>s.NgayLap >= StartDate.Value && s.NgayLap <=EndDate.Value).ToList();
                _lstThongKe.AddRange(thongKeThuChi.Select(s => new ThongKeViewModel(s)));
                _isLoaded = true;
            });
        }

        private void HideReportColumn()
        {
            gridViewHangHoa.Columns[Define.LoaiThongKeEnum.Ngay.ToString()].UnGroup();
            gridViewHangHoa.Columns[Define.LoaiThongKeEnum.Ngay.ToString()].Visible = false;

            gridViewHangHoa.Columns[Define.LoaiThongKeEnum.Thang.ToString()].UnGroup();
            gridViewHangHoa.Columns[Define.LoaiThongKeEnum.Thang.ToString()].Visible = false;

            gridViewHangHoa.Columns[Define.LoaiThongKeEnum.Nam.ToString()].UnGroup();
            gridViewHangHoa.Columns[Define.LoaiThongKeEnum.Nam.ToString()].Visible = false;

            gridViewHangHoa.Columns[Define.LoaiThongKeEnum.Quy.ToString()].UnGroup();
            gridViewHangHoa.Columns[Define.LoaiThongKeEnum.Quy.ToString()].Visible = false;
        }

        private void ThongKe(Define.LoaiThongKeEnum thongKe)
        {
            if (!_isLoaded)
            {
                ReloadData();
            }

            // Reset all group
            HideReportColumn();

            gridViewHangHoa.Columns[thongKe.ToString()].Visible = true;
            gridViewHangHoa.Columns[thongKe.ToString()].Group();

            if (!_cacheThongKe.ContainsKey(thongKe))
            {
                var result = new List<object>();

                var groupBy = _lstThongKe.GroupBy(s => s.Ngay.ToString());
                if (thongKe == Define.LoaiThongKeEnum.Thang)
                {
                    groupBy = _lstThongKe.GroupBy(s => s.Thang.ToString());
                }
                if (thongKe == Define.LoaiThongKeEnum.Nam)
                {
                    groupBy = _lstThongKe.GroupBy(s => s.Nam.ToString());
                }
                if (thongKe == Define.LoaiThongKeEnum.Quy)
                {
                    groupBy = _lstThongKe.GroupBy(s => s.Quy);
                }

                foreach (var thoigian in groupBy)
                {
                    var groupByNoiDung = thoigian.GroupBy(s => s.NoiDung).ToList();
                    var groupByTime = thoigian.FirstOrDefault();
                    foreach (var noiDung in groupByNoiDung)
                    {
                        var grouped = noiDung.First().Clone();
                        grouped.SoLuongNhap = noiDung.Sum(s => s.SoLuongNhap);
                        grouped.SoLuongXuat = noiDung.Sum(s => s.SoLuongXuat);
                        grouped.Thu = noiDung.Sum(s => (long)s.Thu);
                        grouped.Chi = noiDung.Sum(s => (long)s.Chi);
                        grouped.NgaySort = groupByTime.NgaySort;
                        result.Add(grouped);
                    }
                }
                _cacheThongKe.Add(thongKe, result);
            }

            gridControlHangHoa.DataSource = _cacheThongKe[thongKe];
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            _isLoaded = false;
            _cacheThongKe.Clear();
            ThongKe(_loaiThongKe);
        }

        private void tileItemNgay_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _loaiThongKe = Define.LoaiThongKeEnum.Ngay;
            ThongKe(_loaiThongKe);
        }

        private void tileItemThang_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _loaiThongKe = Define.LoaiThongKeEnum.Thang;
            ThongKe(_loaiThongKe);
        }

        private void tileItemQuy_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _loaiThongKe = Define.LoaiThongKeEnum.Nam;
            ThongKe(_loaiThongKe);
        }

        private void tileItemNam_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            _loaiThongKe = Define.LoaiThongKeEnum.Quy;
            ThongKe(_loaiThongKe);
        }
    }
}
