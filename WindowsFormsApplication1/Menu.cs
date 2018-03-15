using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberMachine
{
    public partial class Menu : Form
    {
        IncDec incDec;

        public Menu()
        {
            InitializeComponent();
        }
        
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close our application
        }

        private void btnIncDec_Click(object sender, EventArgs e)
        {
            incDec = new IncDec();
            incDec.Show();
            incDec.Focus();
            this.Close();
        }
    }
}
