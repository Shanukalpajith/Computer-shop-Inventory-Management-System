using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIMS
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
             //Application.Run(new OderManage(1));
             //Application.Run(new CustomerManage(7));
             //Application.Run(new ItemManage(4));
            // Application.Run(new CategorieManage(2));
             //Application.Run(new UserManage(1));
             Application.Run(new Form1());
             //Application.Run(new ReportForm());

             //NN12345678
             //17421


        }
    }
}
