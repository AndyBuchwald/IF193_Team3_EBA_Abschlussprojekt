using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Informatikmodul;

namespace Rechnermodul_JustForYou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInformatik_Click(object sender, EventArgs e)
        {
            var informatikGUI = new Informatikmodul.Informatikrechner();
            informatikGUI.ShowDialog();
        }
    }
}
