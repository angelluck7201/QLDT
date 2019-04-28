using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.FormControls
{
    public partial class DefaultForm : Form
    {
        public object ReturnObject;
        public DefaultForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
        }

        public virtual void DefaultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormBehavior.Close(this);
            ObserverControl.PulishAction(this.Name, Define.ActionTypeEnum.Close, ReturnObject);
        }


    }
}
