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
using System.IO.Compression;
using Newtonsoft.Json;

namespace Interpreter_BrainFuck
{
    public partial class Form1 : Form
    {
        Interpreter inter;
        public Form1()
        {
            InitializeComponent();
        }
        byte[] tekst;
        string file;
        private void NazwaPliku_LostFocus(object sender, EventArgs e)
        {
            file = NazwaPliku.Text;
            tekst = File.ReadAllBytes($@"C:\Users\Oskar\Desktop\Praktyki-Xopero\Interpreter BrainFuck\{file}");
            BrainCode.Text = Encoding.UTF8.GetString(tekst);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            inter = new Interpreter(BrainCode.Text);
            inter.Run();
            Wynik.Text = inter.wynik;
        }
        DirectoryInfo directorySelected = new DirectoryInfo(@"C:\Users\Oskar\Desktop\Praktyki-Xopero\Interpreter BrainFuck\");
        private void convertBinary_Click(object sender, EventArgs e)
        {
            byte[] compressed = CompressBF(BrainCode.Text);
            foreach (var b in compressed)
                Console.Write(b);

            using (FileStream s = File.Create($@"C:\Users\Oskar\Desktop\Praktyki-Xopero\Interpreter BrainFuck\{file}.bfcp"))
            {
                s.Write(compressed);
            }

        }

        public byte[] CompressBF(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            using (MemoryStream output = new MemoryStream())
            {
                using (DeflateStream compressor = new DeflateStream(output, CompressionMode.Compress))
                {
                    compressor.Write(bytes, 0, bytes.Length);
                }
                return output.ToArray();
            }

        }

        public string DecompressBF(byte[] data)
        {
            using (MemoryStream input = new MemoryStream(data))
            {
                using (DeflateStream decompressor = new DeflateStream(input, CompressionMode.Decompress))
                {
                    using (StreamReader reader = new StreamReader(decompressor))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }

        private void dekommpresuj_Click(object sender, EventArgs e)
        {
          BrainCode.Text = DecompressBF(File.ReadAllBytes($@"C:\Users\Oskar\Desktop\Praktyki-Xopero\Interpreter BrainFuck\{file}"));
        }
    }
}
