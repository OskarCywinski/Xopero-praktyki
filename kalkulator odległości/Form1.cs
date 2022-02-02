using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_odległości
{
    public partial class Form1 : Form
    {

        public int drogaprzebyta;
        public float zaplata;
        float przelicznik = 0.39F;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (stanpoczatkowy.Value < stankoncowy.Value)
            {
                drogaprzebyta = (int)stankoncowy.Value - (int)stanpoczatkowy.Value;
                zaplata = (float)drogaprzebyta * przelicznik;
                kwota.Text = zaplata.ToString() + " zł";
            }
            else
            {
                MessageBox.Show("Stan początkowy musi być mniejszy niż końcowy");
            }
        }
    }
}
