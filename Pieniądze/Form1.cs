using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Pieniądze
{
    public partial class Form1 : Form
    {

        public int bank = 100;

        Guy Bob;
        Guy Joe;

        public void UpdateForm()
        {
            label1.Text = Joe.Name + " ma " + Joe.Cash + " zł";
            label2.Text = Bob.Name + " ma " + Bob.Cash + " zł";
            label3.Text = "Bank ma " + bank + " zł";
        }

        public Form1()
        {
            InitializeComponent();
            Bob = new Guy() { Name = "Bob", Cash = 100 };
            Joe = new Guy() { Name = "Joe", Cash = 50 };
            UpdateForm();
        }

        public void BankGivesJoe()
        {
            bank -= 10;
            Joe.Cash += 10;
        }

        public void BobGivesBank()
        {
            Bob.Cash -= 5;
            bank += 5;
        }
        
        public void JoeGivesBob()
        {
            Joe.Cash -= 10;
            Bob.Cash += 10;
        }

        public void BobGivesJoe()
        {
            Bob.Cash -= 5;
            Joe.Cash += 5;
        }

        private void BankToJoe_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                BankGivesJoe();
                UpdateForm();
            }
            else 
            {
                MessageBox.Show("W banku nie ma wystarczająco pieniędzy");
            }
        }

        private void BobToBank_Click(object sender, EventArgs e)
        {
            if (Bob.Cash >= 5)
            {
                BobGivesBank();
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob nie ma wystarczająco pieniędzy");
            }
        }

        private void JoeToBob_Click(object sender, EventArgs e)
        {
            if (Joe.Cash >= 10)
            {
                JoeGivesBob();
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe nie ma wystarczająco pieniędzy");
            }
        }

        private void BobToJoe_Click(object sender, EventArgs e)
        {
            if (Bob.Cash >= 5)
            {
                BobGivesJoe();
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe nie ma wystarczająco pieniędzy");
            }
        }
    }
}
