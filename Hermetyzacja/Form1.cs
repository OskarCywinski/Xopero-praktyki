using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermetyzacja
{
    public partial class Form1 : Form
    {
        SecretAgent agent;
        public Form1()
        {
            InitializeComponent();
            agent = new SecretAgent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = agent.AgentGreeting(textBox1.Text);
            label3.Text = name;
        }
    }
}
