using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool err = false;
            int[] expect = { 0, 30, 60, 90, 120, 150, 180, 150, 120, 90, 60, 30, 0 };
            for (int hour = 0; hour < 24; hour++)
            {
                var actual = Expr3_Task.GetAngle(hour);
                if (actual != expect[hour % 12])
                {
                    var message = "Error Hour " + hour + Environment.NewLine + "Actual : " + actual + Environment.NewLine + "Expect : " + expect[hour % 12];
                    Application.Run(new Form2(message));
                    err = true;
                    break;
                }
            }
            if (err == false)
            {
                Application.Run(new Form1());
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
