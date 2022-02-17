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
using System.Text.Json.Serialization;
using System.Text.Json;

namespace GitLabIssues
{
    public partial class Form1 : Form
    {
        List<JSON> Json;
        List<Issues> Issue;
        List<IssuesComments> Comment;
        string ID, projectID, issueID, note;
        int projectPage = 1, issuePage = 1, commentPage = 1, maxProjectsList = 100, maxIssuesList = 100, maxCommentsList = 100;
        HttpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getProjects(textBox1.Text);
            for (int i = 0; i <= 1; i++)
            {
                if (comboBox1.Items.Count == maxProjectsList)
                {
                    projectPage += 1;
                    maxProjectsList += 100;
                    i = 0;
                    getProjects(textBox1.Text);
                }
            }
        }

        private void getUserID()
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", textBox1.Text);
                var response = client.GetAsync($"https://gitlab.com/api/v4/user").Result;
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

            label2.Text = ("Użytkownik: " + jsonObj.name);
            ID = jsonObj.id.ToString();
        }

        private void getProjects(string Token)
        {
            getUserID();
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", Token);
                var response = client.GetAsync($"https://gitlab.com/api/v4/users/{ID}/projects?per_page=100&page={projectPage.ToString()}").Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    deserializeJSONProjects(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }
        }

        private void GetIssues(string Token)
        {
            getUserID();
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", Token);
                var response = client.GetAsync($"https://gitlab.com/api/v4/projects/{projectID}/issues?per_page=100&page={issuePage.ToString()}").Result;
                if(response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    deserializeJSONIssues(responseString);
                    //MessageBox.Show(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }
        }

        private void deserializeJSONIssues(string json)
        {
            Issues jsonObj;
            Issue = JsonSerializer.Deserialize<List<Issues>>(json);

            for (int i = 0; i < Issue.Count; i++)
            {
                jsonObj = Issue[i];
                comboBox2.Items.Add(jsonObj.title + " iid:" + jsonObj.iid);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            dataGridView1.Rows.Clear();
            projectID = comboBox1.Text.Split(':')[1];
            GetIssues(textBox1.Text);
            for (int i = 0; i <= 1; i++)
            {
                if (comboBox2.Items.Count == maxIssuesList)
                {
                    issuePage += 1;
                    maxIssuesList += 100;
                    i = 0;
                    GetIssues(textBox1.Text);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            issueID = comboBox2.Text.Split(':')[1];
            GetIssuesComments(textBox1.Text);
            for (int i = 0; i <= 1; i++)
            {
                if (dataGridView1.Rows.Count == maxCommentsList)
                {
                    commentPage += 1;
                    maxCommentsList += 100;
                    i = 0;
                    GetIssuesComments(textBox1.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            note = textBox2.Text;
            UploadIssueComment(textBox1.Text);
        }

        private void deserializeJSONProjects(string json)
        {
            JSON jsonObj;
            Json = JsonSerializer.Deserialize<List<JSON>>(json);

            for (int i = 0; i < Json.Count; i++)
            {
                jsonObj = Json[i];
                comboBox1.Items.Add(jsonObj.name + " id:" + jsonObj.id);
            }
        }

        private void GetIssuesComments(string Token)
        {
            getUserID();
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", Token);
                var response = client.GetAsync($"https://gitlab.com/api/v4/projects/{projectID}/issues/{issueID}/notes?per_page=100&page={commentPage.ToString()}").Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    deserializeJSONIssuesComments(responseString);
                    //MessageBox.Show(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }
        }

        private void deserializeJSONIssuesComments(string json)
        {
            IssuesComments jsonObj;
            Comment = JsonSerializer.Deserialize<List<IssuesComments>>(json);

            for (int i = 0; i < Comment.Count; i++)
            {
                jsonObj = Comment[i];
                dataGridView1.Rows.Add(jsonObj.author.username, jsonObj.body);
            }
        }

        private void UploadIssueComment(string Token)
        {
            getUserID();
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", Token);
                var values = new List<KeyValuePair<string, string>>();
                values.Add(new KeyValuePair<string, string>("body", textBox2.Text));
                var content = new FormUrlEncodedContent(values);
                var responsePost = client.PostAsync($"https://gitlab.com/api/v4/projects/{projectID}/issues/{issueID}/notes", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    dataGridView1.Rows.Clear();
                    GetIssuesComments(textBox1.Text);
                    //MessageBox.Show(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }

        }


    }
}
