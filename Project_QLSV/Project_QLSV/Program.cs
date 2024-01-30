using Project_QLSV.Class_Sinh_Viên;
using Project_QLSV.Học_Bổng;
using Project_QLSV.Khen_Thưởng;
using Project_QLSV.Kỷ_Luật;
using Project_QLSV.RútHS;
using Project_QLSV.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLSV
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain()); // set from chạy đầu tiên
        }
    }
}
