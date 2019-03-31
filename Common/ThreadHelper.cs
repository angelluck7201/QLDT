using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QLDT.FormControls;

namespace QLDT
{
    public static class ThreadHelper
    {
        public static void LoadForm(Action action, System.Windows.Forms.Form form = null)
        {
            if (form == null)
            {
                form = FormBehavior.MainForm;
            }

            try
            {
                CloseWaitingForm();
                SplashScreenManager.ShowDefaultWaitForm(form, true, true, true, 250, "Đợi xíu nhé");
                action();
            }
            catch (Exception e)
            {
                CloseWaitingForm();
                XtraMessageBox.Show("Đã xảy ra lỗi trong hệ thống. Làm ơn thử lại!", "Thông báo lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                //throw;
            }
            finally
            {
                CloseWaitingForm();
            }
        }

        public static void CloseWaitingForm()
        {
            if (SplashScreenManager.Default != null) SplashScreenManager.CloseDefaultWaitForm();
        }

        public static void RunBackground(Action task, Action callback = null, Action<Exception> errorAction = null)
        {
            ThreadPool.QueueUserWorkItem((a) =>
            {
                try
                {
                    task();
                }
                catch (Exception e)
                {
                    if (errorAction != null)
                    {
                        errorAction(e);
                    }
                    else
                    {
                        throw e;
                    }
                }
                finally
                {
                    if (callback != null)
                    {
                        callback();
                    }
                }
            });
        }
    }
}
