using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Geometriemodul
{
    public partial class Geometrierechner : Form
    {
        public Geometrierechner()
        {
            InitializeComponent();
        }
        double circumference;
        double area;

        private void BtnGeoDreieck_Click(object sender, EventArgs e)
        {

        }

        private void BtnGeoKreis_Click(object sender, EventArgs e)
        {
            circle_circumference(double radius);
            circle_area(double radius);
        }

        private void BtnGeoParallelogramm_Click(object sender, EventArgs e)
        {

        }

        private void BtnGeoEinstellungen_Click(object sender, EventArgs e)
        {
            //var EinstellungGUI = new Rechnermodul_JustForYou.Einstellungen();
            //EinstellungGUI.ShowDialog();
        }

        private void BtnGeoSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private double cirumfrence_triangle(double side_a, double side_b, double side_c)
        {
            circumference = side_a + side_b + side_c;
            return circumference;
        }
        private double area_triangle(double g, double h)
        {
            area = (float)(0.5 * g * h);
            return area;
        }
        private double para_circumference(double side_a, double side_b)
        {
            circumference = 2 * (side_a + side_b);
            return circumference;
        }
        private double para_area(double side_a, double side_b, double angel)
        {
            area = side_a * height_a;
            return area;
        }
        private double circle_circumference(double radius)
        {
            circumference = 3.1415926535897931 * 2 * radius;
            return circumference;
        }
        private double circle_area(double radius)
        {
            area = (float)(3.1415926535897931 * radius * radius);
            return area;
        }
    }
}
