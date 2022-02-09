using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Interpreter_BrainFuck
{
    public partial class Form1 : Form
    {
        Interpreter inter;
        public Form1()
        {
            InitializeComponent();
        }
        string tekst;
        string file;
        private void button1_Click(object sender, EventArgs e)
        {
            tekst = File.ReadAllText($@"C:\Users\Oskar\Desktop\Praktyki-Xopero\BrainFuck Interpreter\{file}.txt");
            inter = new Interpreter(tekst);
            BrainCode.Text = tekst;
            inter.input = tekst.ToCharArray();
        }
        private void NazwaPliku_TextChanged(object sender, EventArgs e)
        {
            file = NazwaPliku.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inter = new Interpreter(tekst);
            inter.Run();
            Wynik.Text = inter.wynik;
        }

        public static string ToBinary(string tekst)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in tekst.ToCharArray())
            {
                sb.Append(Convert.ToString(ch, 2).PadLeft(8, '0'));
            }
            return sb.ToString();

        }

        private void convertBinary_Click(object sender, EventArgs e)
        {
           
            string nazwa = Zapis.Text;

            //using (BinaryWriter writer = new BinaryWriter(File.Open($@"C:\Users\Oskar\Desktop\Praktyki-Xopero\Interpreter BrainFuck\{nazwa}.bin", FileMode.Create)))
            //{
            //   writer.Write(tekst);
            //}

            //File.WriteAllText($@"C:\Users\Oskar\Desktop\Praktyki-Xopero\BrainFuck Interpreter\{nazwa}.bin");
        }
    }
}
