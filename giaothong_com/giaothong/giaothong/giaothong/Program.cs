using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using traffic.Properties;
namespace traffic
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new lable_reset()); // Đổi Form1 thành tên class bạn đã đặt
        }
    }
}
