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
        Database db = new Database();
        public Form1()
        {
            InitializeComponent();
            db.CreateDataBase();
            db.GetDataToDisplay();
            DisplayData();
        }
        Label[] id = new Label[100];
        private void DisplayData()
        {
            for (int i = 0; i < db.ID.Count; i++)
            {
                dataGridView1.Rows.Add(false,db.ID[i],db.Name[i],db.Category[i],db.CreationDate[i],db.ModificationDate[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Uzupełnij wszystkie pola");
            else
            {
                db.AddData(textBox1.Text, textBox2.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), textBox3.Text);
                ReloadDataGrid();
            }
        }

        public void ReloadDataGrid()
        {
            dataGridView1.Rows.Clear();
            db.EmptyLists();
            db.GetDataToDisplay();
            DisplayData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (checkBox1.Checked)
                    dataGridView1.Rows[i].Cells[0].Value = true;
                else
                    dataGridView1.Rows[i].Cells[0].Value = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count-1; i >= 0; i--)
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                    db.DeleteData(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
            ReloadDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                    MessageBox.Show(db.Text[i].ToString(),"Treść " + dataGridView1.Rows[i].Cells[2].Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                        MessageBox.Show("Uzupełnij wszystkie pola");
                    else
                        db.UpdateData(textBox1.Text, textBox2.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), textBox3.Text, Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
            ReloadDataGrid();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID - Rosnąco")
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            else if (comboBox1.Text == "ID - Malejąco")
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            else if (comboBox1.Text == "Nazwie - Rosnąco")
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
            else if (comboBox1.Text == "Nazwie - Malejąco")
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
            else if (comboBox1.Text == "Kategorii - Rosnąco")
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            else if (comboBox1.Text == "Kategorii - Malejąco")
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
            else if (comboBox1.Text == "Dacie utworzenia - Rosnąco")
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            else if (comboBox1.Text == "Dacie utworzenia - Malejąco")
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            else if (comboBox1.Text == "Dacie modyfikacji - Rosnąco")
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
            else if (comboBox1.Text == "Dacie modyfikacji - Malejąco")
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
        }
    }
}
