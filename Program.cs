using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TopSolid.Kernel.Automating;
using TopSolid.Cad.Design.Automating;
using TopSolid.Cad.Drafting.Automating;

namespace MyAutomationApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //connect
            TopSolidHost.Connect();
            TopSolidDesignHost.Connect();
            TopSolidDraftingHost.Connect();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //disconnect
            TopSolidHost.Disconnect();
            TopSolidDesignHost.Disconnect();
            TopSolidDraftingHost.Disconnect();
        }
    }
}
