using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class Form1 : Form
    {
        Farmer farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15,30);
            numericUpDown1.Value = farmer.NumberOfCows;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Potrzebuję " + farmer.BagsOfFeed + " worków paszy do wykarmienia " + farmer.NumberOfCows + " krów");
        }

    }
}
