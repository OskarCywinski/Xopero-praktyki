using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obsluga_artykulow
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
            database.CreateDataBase();
            database.GetDataToDisplay();
            SetCheckBoxes();
            checkedListBox1.SendToBack();
        }
        Label[] id = new Label[100];
        private void SetCheckBoxes()
        {
            for (int i = 0; i < database.ID.Count; i++)
            {
                checkedListBox1.Items.Add(database.Name[i]);
                Rectangle r = checkedListBox1.GetItemRectangle(i);
                id[i] = new Label();
                id[i].Location = new Point(200, 145+r.Top);
                id[i].Text = database.ID[i];
                id[i].BringToFront();
                id[i].BackColor = Color.White;
                id[i].AutoSize = true;
                this.Controls.Add(id[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Uzupełnij wszystkie pola");
            else
                database.AddData(textBox1.Text, textBox2.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), textBox3.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkBox1.Checked)
                    checkedListBox1.SetItemChecked(i, true);
                else
                    checkedListBox1.SetItemChecked(i, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.Items.Count-1; i >=0 ; i--)
                if (checkedListBox1.GetItemChecked(i) == true)
                    checkedListBox1.Items.RemoveAt(i);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0 ; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemChecked(i) == true)
                    MessageBox.Show("",checkedListBox1.Items[i].ToString());
        }
    }
}
