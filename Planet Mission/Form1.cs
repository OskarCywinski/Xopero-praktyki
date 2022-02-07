using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planet_Mission
{
    public partial class Form1 : Form
    {
        Mars mars;
        Venus venus;

        private string comboBoxText;
        public Form1()
        {
            InitializeComponent();
            venus = new Venus();
            mars = new Mars();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxText = comboBox1.Text;
            if (comboBoxText == "Venus")
                MessageBox.Show(venus.FuelNeeded());
            else
                MessageBox.Show(mars.FuelNeeded());
        }
    }
}
