using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TopSolid.Kernel.Automating;
using TopSolid.Cad.Design.Automating;
using TopSolid.Cad.Drafting.Automating;

namespace MyAutomationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checks TopSolid is connected before performing any action
            if (TopSolidHost.IsConnected)
            {
                //fetch topsolid version from application interface
                string currentTopSolidVersion = TopSolidHost.Application.Version.ToString();

                //display the value into a message box
                MessageBox.Show(currentTopSolidVersion, "TopSolid Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
