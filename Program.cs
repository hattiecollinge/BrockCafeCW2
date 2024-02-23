using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrockCafeCW
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
            Application.Run(new frmStats());
        }
    }
}
//WHEN ORDER IS COMPLETED ADD TO FLOW LAYOUT PANEL THEN DELETE WHEN ITEM IS COLLECTED 