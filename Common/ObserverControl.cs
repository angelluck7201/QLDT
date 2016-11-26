using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class ObserverControl
    {
        private static List<EventObserver> RegisterList = new List<EventObserver>();

        public static void Regist(string register, string publisher, Define.ActionTypeEnum registAction, Action callBackAction)
        {
            var currentRegister = RegisterList.FirstOrDefault(s => s.Register == register && s.RegistAction == registAction && s.Publisher == publisher);
            if (currentRegister == null)
            {
                currentRegister = new EventObserver(register, registAction, publisher, callBackAction);
                RegisterList.Add(currentRegister);
            }
            else
            {
                currentRegister.Action = callBackAction;
            }
        }

        public static void Regist(string register, string publisher, Define.ActionTypeEnum registAction, Action<object> callBackAction)
        {
            var currentRegister = RegisterList.FirstOrDefault(s => s.Register == register && s.RegistAction == registAction && s.Publisher == publisher);
            if (currentRegister == null)
            {
                currentRegister = new EventObserver(register, registAction, publisher, callBackAction);
                RegisterList.Add(currentRegister);
            }
            else
            {
                currentRegister.ActionParam = callBackAction;
            }
        }


        public static void Clear()
        {
            RegisterList.Clear();
        }

        public static void Detacth(string registerName)
        {
            RegisterList.RemoveAll(s => s.Register == registerName);
        }

        public static void PulishAction(string publish, Define.ActionTypeEnum publishAction, object data = null)
        {
            var listAction = RegisterList.Where(s => s.Publisher == publish && s.RegistAction == publishAction).ToList();
            foreach (var item in listAction)
            {
                if (data == null)
                {
                    item.Action();
                }
                else
                {
                    item.ActionParam(data);
                }
            }      
        }

        private class EventObserver
        {
            public string Register;
            public Define.ActionTypeEnum RegistAction;
            public string Publisher;
            public Action Action;
            public Action<object> ActionParam;

            public EventObserver(string register, Define.ActionTypeEnum registAction, string publisher, Action action)
            {
                Register = register;
                RegistAction = registAction;
                Publisher = publisher;
                Action = action;
            }

            public EventObserver(string register, Define.ActionTypeEnum registAction, string publisher, Action<object> action)
            {
                Register = register;
                RegistAction = registAction;
                Publisher = publisher;
                ActionParam = action;
            }
        }

       
    }
}
