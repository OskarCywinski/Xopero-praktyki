using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json;

namespace KursyWalut
{
    public partial class Form1 : Form
    {
        List<Json> json;
        Json json1;


        public Form1()
        {
            InitializeComponent();
        }

        public void DownloadFile(string table,string code)
        {
            string kursy;
            WebClient webclient = new WebClient();
            if(waluta.Text.Length < 1)
            {
                kursy = webclient.DownloadString($"http://api.nbp.pl/api/exchangerates/tables/{table}");
                json = JsonConvert.DeserializeObject<List<Json>>(kursy);
            }
            else
            {
                kursy = webclient.DownloadString($"http://api.nbp.pl/api/exchangerates/rates/{table}/{code}");
                json1 = JsonConvert.DeserializeObject<Json>(kursy);
            }
        }

        private void tabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            waluta.Items.Clear();
            DownloadFile(tabela.Text,waluta.Text);
            for(int i = 0; i < json[0].rates.Count; i++)
            {
                waluta.Items.Add(json[0].rates[i].code);
            }

        }

        private void waluta_SelectedIndexChanged(object sender, EventArgs e)
        {
            DownloadFile(tabela.Text,waluta.Text);
            Kurs.Text = json1.rates[0].mid.ToString() + " zł";
            label2.Text = "Kurs: " + waluta.Text;
        }
    }
}
