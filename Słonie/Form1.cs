using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Słonie
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        }

        private void Lloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void Lucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void change_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Obiekty zamienione");
        }
    }
}
