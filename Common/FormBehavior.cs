using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using QLDT.FormControls;

namespace QLDT
{
    public static class FormBehavior
    {
        private static MainForm _mainForm;
        public static MainForm MainForm
        {
            get
            {
                if (_mainForm == null)
                {
                    _mainForm = new MainForm();
                }
                return _mainForm;
            }
        }

        private static Dictionary<Form, Form> ShowingForms = new Dictionary<Form, Form>();

        public static void CustomShow(this Form formControl, Form parenForm)
        {
            if (ShowingForms.ContainsKey(parenForm))
            {
                ShowingForms[parenForm] = formControl;
            }
            else
            {
                ShowingForms.Add(parenForm, formControl);
            }

            parenForm.Enabled = false;
            formControl.Show();
            formControl.Focus();
        }

        public static void Close(Form formControl)
        {
            var parentForms = ShowingForms.Where(s => s.Value == formControl).ToList();
            foreach (var keyValuePair in parentForms)
            {
                keyValuePair.Key.Enabled = true;
                ShowingForms.Remove(keyValuePair.Key);
            }

//            CRUD.DisposeDb();
        }

        public static void GenerateForm(UserControl userControl, 
            string title, 
            Form parentForm,
            string register)
        {
            var defaultForm = new DefaultForm();
            defaultForm.Height = userControl.Height + 70;
            defaultForm.Width = userControl.Width + 15;
            defaultForm.Controls.Add(userControl);
            defaultForm.Text = title;
            userControl.Dock = DockStyle.Fill;
            defaultForm.RegisterName = register;
            defaultForm.CustomShow(parentForm);
        }

        public static void GeneratePopupForm(UserControl userControl, string title, Form parentForm)
        {
            var defaultForm = new PopupForm();
            defaultForm.Height = userControl.Height + 50;
            defaultForm.Width = userControl.Width + 15;

            defaultForm.Controls.Add(userControl);
            defaultForm.Text = title;
            userControl.Dock = DockStyle.Fill;
            defaultForm.CustomShow(parentForm);
        }

        public static void DecoreateLookEdit(RepositoryItemLookUpEdit lookEdit, object dataSource, string displayMember, string valueMember = "Id")
        {
            lookEdit.Properties.DisplayMember = displayMember;
            lookEdit.Properties.ValueMember = valueMember;
            lookEdit.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            lookEdit.Properties.DataSource = dataSource;
            lookEdit.PopulateColumns();
            lookEdit.ShowHeader = false;
            lookEdit.Columns[valueMember].Visible = false;
            lookEdit.NullText = "";
        }

        public static void RefreshGrid<T>(GridView grid, T data)
        {
            var gridDataSource = grid.DataSource as List<T>;
            var existedData = gridDataSource.FindIndex(s => ((dynamic)s).Id == ((dynamic)data).Id);
            if (existedData >= 0)
            {
                if (((dynamic) data).IsActived == false)
                {
                    gridDataSource.RemoveAt(existedData);
                }
                else
                {
                    gridDataSource[existedData] = data;
                }
            }
            else
            {
                gridDataSource.Add(data);
            }

            grid.RefreshData();
        }

        public static void GenerateFormatRuleByValue(GridView gridView, GridColumn column, object value, FormatCondition condition, Color backColor, Color fontColor)
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
    }
}
