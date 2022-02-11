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




        	Dictionary<char, byte> bfChars = new Dictionary<char, byte>()
            {
                { '+', 0 },
                { '-', 1 },
                { '<', 2 },
                { '>', 3 },
                { '.', 4 },
                { ',', 5 },
                { '[', 6 },
                { ']', 7 },

            };
            Dictionary<byte, char> bfCharsReverse = new Dictionary<byte, char>()
            {
                { 0, '+' },
                { 1, '-' },
                { 2, '<' },
                { 3, '>' },
                { 4, '.' },
                { 5, ',' },
                { 6, '[' },
                { 7, ']' },

            };

        public byte[] CompressBF(string input)
        {
            List<byte> bytes = new List<byte>();

            foreach (char c in input.ToCharArray())
                bytes.Add(bfChars[c]);

            List<byte> compressedBytes = new List<byte>();

            for (int i = 0; i < bytes.Count - 1; i += 2)
            {
                byte b1 = bytes[i];
                byte b2 = bytes[i + 1];

                byte pair = (byte)((b1 << 3) | b2);
                compressedBytes.Add(pair);
            }

            if (bytes.Count % 2 == 1)
            {
                compressedBytes.Add(bytes[bytes.Count - 1]);
            }

            return compressedBytes.ToArray();
        }

        public string DecompressBF(byte[] input)
        {
            string decompressed = "";

            for (int i = 0; i < input.Length; i++)
            {
                byte b1 = (byte)(input[i] >> 3);
                byte b2 = (byte)(input[i] & 0b00000111);
                byte lastbyte = (byte)(input[i]);
 
                decompressed += bfCharsReverse[b1];
                decompressed += bfCharsReverse[b2];




            }

            return decompressed;
        }

        private void dekommpresuj_Click(object sender, EventArgs e)
        {
          BrainCode.Text = DecompressBF(File.ReadAllBytes($@"C:\Users\Oskar\Desktop\Praktyki-Xopero\Interpreter BrainFuck\{file}"));
        }
    }
}
