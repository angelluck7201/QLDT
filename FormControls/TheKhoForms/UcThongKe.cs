using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public UcThongKe()
        {
            InitializeComponent();
            ReloadData();

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
                var thongKeDonHang = CRUD.DbContext.ChiTietDonHangs.ToList();
                _lstThongKe.AddRange(thongKeDonHang.Select(s => new ThongKeViewModel(s)));

                var thongKeThuChi = CRUD.DbContext.ThuChis.ToList();
                _lstThongKe.AddRange(thongKeThuChi.Select(s => new ThongKeViewModel(s)));
                ThongKe(Define.LoaiThongKeEnum.Thang);
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
            btnAll.PerformClick();

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
                    foreach (var noiDung in groupByNoiDung)
                    {
                        var grouped = noiDung.First().Clone();
                        grouped.SoLuongNhap = noiDung.Sum(s => s.SoLuongNhap);
                        grouped.SoLuongXuat = noiDung.Sum(s => s.SoLuongXuat);
                        grouped.Thu = noiDung.Sum(s => (long)s.Thu);
                        grouped.Chi = noiDung.Sum(s => (long)s.Chi);
                        grouped.NgaySort = TimeHelper.StringToTimeStamp(grouped.Ngay);
                        result.Add(grouped);
                    }
                }
                _cacheThongKe.Add(thongKe, result);
            }

            gridControlHangHoa.DataSource = _cacheThongKe[thongKe];
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var startDate = TimeHelper.StringToTimeStamp(StartDate.Text);
            var endDate = TimeHelper.StringToTimeStamp(EndDate.Text);
            gridViewHangHoa.ActiveFilterString = string.Format("[NgaySort] >= '{0}' AND [NgaySort] <= '{1}'", startDate, endDate);

            btnTim.Appearance.BackColor = Color.Silver;
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            gridViewHangHoa.ActiveFilterString = "";

            btnTim.Appearance.BackColor = SystemColors.MenuHighlight;
        }

        private void tileItemNgay_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ThongKe(Define.LoaiThongKeEnum.Ngay);
        }

        private void tileItemThang_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ThongKe(Define.LoaiThongKeEnum.Thang);
        }

        private void tileItemQuy_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ThongKe(Define.LoaiThongKeEnum.Quy);
        }

        private void tileItemNam_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ThongKe(Define.LoaiThongKeEnum.Nam);
        }
    }
}
