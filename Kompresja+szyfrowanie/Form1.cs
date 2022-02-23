using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Security.Cryptography;

namespace Kompresja_szyfrowanie
{
    public partial class Form1 : Form
    {

        string file,text;
 
  
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
        public string Encryptxx(string text)
        {

            byte[] src = Encoding.UTF8.GetBytes(text);
            byte[] key = Encoding.ASCII.GetBytes("0123456789abcdef");
            RijndaelManaged aes = new RijndaelManaged();
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;
            aes.KeySize = 128;

            using (ICryptoTransform encrypt = aes.CreateEncryptor(key, null))
            {
                byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);
                encrypt.Dispose();
                return Convert.ToBase64String(dest);
            }
        }

        public string Decryptxx(string text)
        {
            byte[] src = Convert.FromBase64String(text);
            RijndaelManaged aes = new RijndaelManaged();
            byte[] key = Encoding.ASCII.GetBytes("0123456789abcdef");
            aes.KeySize = 128;
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.ECB;
            using (ICryptoTransform decrypt = aes.CreateDecryptor(key, null))
            {
                byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                decrypt.Dispose();
                return Encoding.UTF8.GetString(dest);
            }
        }


        public Form1()
        {
            InitializeComponent();

        }

        private void szyfruj_Click(object sender, EventArgs e)
        {
            textBox4.Text = Encryptxx(text);
            
        }

        private void odszyfruj_Click(object sender, EventArgs e)
        {
            textBox4.Text = Decryptxx(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] compressed = CompressBF(textBox3.Text);

            using (FileStream s = File.Create(Application.StartupPath+$@"\{file}.bfcp"))
            {
                s.Write(compressed);
                textBox4.Text = Encoding.UTF8.GetString(compressed); 
            }

        }

        private void Dekompresuj_Click(object sender, EventArgs e)
        {
            textBox4.Text = DecompressBF(File.ReadAllBytes(Application.StartupPath+$@"\{file}"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string encrypted = Encryptxx(text);
            byte[] compressed = CompressBF(Encryptxx(text));

            using (FileStream s = File.Create(Application.StartupPath + $@"\compressed{file}.bfcp"))
            {
                s.Write(compressed);
            }
                textBox4.Text = "Tekst zaszyfrowany: \r\n " + encrypted + "\r\n" + "Tekst skompresowany: \r\n" + Encoding.UTF8.GetString(compressed);

        }

        private void button3_Click(object sender, EventArgs e)
        {
           string decompress =  DecompressBF(File.ReadAllBytes(Application.StartupPath + $@"\{file}"));
           string decrypt = Decryptxx(decompress);
           textBox4.Text = "Tekst zdekompresowany: \r\n" + decompress + "\r\n" + "Tekst odszyfrowany: \r\n" + decrypt;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            file = textBox1.Text;
            text = File.ReadAllText(Application.StartupPath+$@"\{file}");
            textBox3.Text = text;
        }
    }
}
