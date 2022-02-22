using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;


namespace BitBucket
{
    public partial class Form1 : Form
    {
        List<Repositories> Repo;
        HttpClient client;
        string ID,username;
        int maxReposList = 100,ReposPage=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.Items.Count > 0)
                checkedListBox1.Items.Clear();
            getRepositories();
            for (int i = 0; i <= 1; i++)
            {
                if (checkedListBox1.Items.Count == maxReposList)
                {
                    ReposPage += 1;
                    maxReposList += 100;
                    i = 0;
                    getRepositories();
                }
            }
        }
        private void getUserID()
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + textBox1.Text);
                var response = client.GetAsync($"https://api.bitbucket.org/2.0/user").Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    deserializeJSONID(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }
        }
        private void deserializeJSONID(string json)
        {
            UserID jsonObj = JsonSerializer.Deserialize<UserID>(json);

            label2.Text = ("Użytkownik: " + jsonObj.username);
            ID = jsonObj.account_id.ToString();
            username = jsonObj.username;

        }
        private void getRepositories()
        {
            getUserID();
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + textBox1.Text);
                var response = client.GetAsync($"https://api.bitbucket.org/2.0/repositories/{username}?page={ReposPage}&per_page=100").Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    deserializeJSONRepositories(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }
        }

        private void deserializeJSONRepositories(string json)
        {
            Repositories RepoObj;
            RepoObj = JsonSerializer.Deserialize<Repositories>(json);

            for (int i = 0; i < RepoObj.values.Count; i++)
            {
                checkedListBox1.Items.Add(RepoObj.values[i].slug);
            }
        }
        private void createRepo(string name, int length)
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + textBox1.Text);
                var repo_slug = textBox2.Text;
                for (int i = 0; i < length; i++)
                {
                    var values = new List<KeyValuePair<string, string>>();
                    //values.Add(new KeyValuePair<string, string>("slug", name + i.ToString()));
                    var content = new FormUrlEncodedContent(values);
                    var responsePost = client.PostAsync($"https://api.bitbucket.org/2.0/repositories/{username}/{repo_slug}", content).Result;
                    if (responsePost.IsSuccessStatusCode)
                    {
                        MessageBox.Show("działa " + i + " " + responsePost.StatusCode);

                    }
                    else
                    {
                        MessageBox.Show("działa nie " + responsePost.StatusCode);

                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createRepo(textBox2.Text, (int)numericUpDown1.Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
