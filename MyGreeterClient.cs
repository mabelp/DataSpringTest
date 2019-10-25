using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSpringWinForm
{
    public class MyGreeterClient
    {

        #region Instance

        private static MyGreeterClient _instance;
        private static object _syncobject = new object();

        public static MyGreeterClient Instance
        {
            get
            {
                if (_instance == null)
                    lock (_syncobject)
                    {
                        if (_instance == null)
                            _instance = new MyGreeterClient();
                    }
                return _instance;
            }
        }
        #endregion


        public string GetGreetingMessage()
        {
            string retultMsg = string.Empty;

            int hour = DateTime.Now.Hour;

            if (hour >= 0 && hour < 12)
            {
                retultMsg = "Good morning";
            }
            else if (hour < 18)
            {
                retultMsg = "Good afternoon";
            }
            else
            {
                retultMsg = "Good evening";
            }

            return retultMsg;
        }
    }
}
