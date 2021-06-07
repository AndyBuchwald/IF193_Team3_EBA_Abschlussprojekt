using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnermodul_JustForYou.Eingabemodul
{
    public partial class Eingabemodul : Form
    {
        public string Rueckgabe;

        public Eingabemodul()
        {
            InitializeComponent();
        }

        public string[] Uebergabe()
        {

        }
        private void btnLöschen_Click(object sender, EventArgs e)
        {

        }

        private void btnGrundrechner_Click(object sender, EventArgs e)
        {

        }

        private void btnBestätigen_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (char charecter in TbEinAnzeige.Text)
            {
                if (charecter == ',')
                    counter++;
                if (counter > 1)
                {
                    MessageBox.Show(caption: "Üngültige Eingabe", text: "Eingabe mit mehreren Kommas", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    TbEinAnzeige.Text = String.Empty;
                    break;
                }

            }
            Rueckgabe = TbEinAnzeige.Text;

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "7";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "4";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "0";
        }

        private void btnKomma_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + ",";
        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text.Remove(TbEinAnzeige.Text.Length - 1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TbEinAnzeige.Text = TbEinAnzeige.Text + "9";
        }

        private void btnEinstellungen_Click(object sender, EventArgs e)
        {

        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
