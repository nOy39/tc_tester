using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tc_tester
{
    static class Program
    {
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!connectionStatus)
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            }
            
        }
        public static void getIp(String ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
            {
                throw new ArgumentException("Ip can't be empty.", nameof(ip));
            } else
            {
                
            }
   
        }

        private static bool connectionStatus;

        public static bool GetConnectionStatus()
        {
            return connectionStatus;
        }

        public static void SetConnectionStatus(bool value)
        {
            connectionStatus = value;
        }

    }
}
