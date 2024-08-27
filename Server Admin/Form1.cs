using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Text.Json;

namespace Server_Admin
{
    public partial class Form1 : Form
    {
        // Holds station values
        private Station station1;
        private Station station2;
        private Station station3;
        private Station station4;
        private Station station5;
        private Station station6;
        private Station station7;
        private Station station8;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("HOLA");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnSaveStation1_Click(object sender, EventArgs e)
        {
            await sendRequest(txtIPStation1.Text, txtNameStation1.Text, txtServerStation1.Text);
        }

        private async void btnSaveStation2_Click(object sender, EventArgs e)
        {
            await sendRequest(txtIPStation2.Text, txtNameStation2.Text, txtServerStation2.Text);
        }

        private async void btnSaveStation3_Click(object sender, EventArgs e)
        {
            await sendRequest(txtIPStation3.Text, txtNameStation3.Text, txtServerStation3.Text);
        }

        private async void btnSaveStation4_Click(object sender, EventArgs e)
        {
            await sendRequest(txtIPStation4.Text, txtNameStation4.Text, txtServerStation4.Text);
        }

        private async void btnSaveStation5_Click(object sender, EventArgs e)
        {
            await sendRequest(txtIPStation5.Text, txtNameStation5.Text, txtServerStation5.Text);
        }

        private async void btnSaveStation6_Click(object sender, EventArgs e)
        {
            await sendRequest(txtIPStation6.Text, txtNameStation6.Text, txtServerStation6.Text);
        }

        private async void btnSaveStation7_Click(object sender, EventArgs e)
        {
            await sendRequest(txtIPStation7.Text, txtNameStation7.Text, txtServerStation7.Text);
        }

        private async void btnSaveStation8_Click(object sender, EventArgs e)
        {
            await sendRequest(txtIPStation8.Text, txtNameStation8.Text, txtServerStation8.Text);
        }

        private void saveIds()
        {
            var dictionary = new Dictionary<string, string>
            {
                { "1", "115:12.01.15" },
                { "2", "115:12.01.16" }
            };

            string jsonString = JsonSerializer.Serialize(dictionary);
            File.WriteAllText("C:/ids.txt", jsonString);
        }

        private void readIds()
        {
            string jsonString = File.ReadAllText("C:/ids.txt");

            var dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);

            if (dictionary != null)
            {
                foreach (var kvp in dictionary)
                {
                    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                }
            }
        }

        private async Task sendRequest(string ip, string name, string serverAndPort)
        {
            try
            {
                string[] serverData = serverAndPort.Split(':');
                string server = serverData[0];
                string port = serverData[1];
                string url = $"{server}:{port}/";

                // Para post
                using (var client = new HttpClient())
                {
                    var content = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("name", name)
                    });
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response: {responseBody}");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }

                // Para get
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Response: {responseBody}");
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionsStation1_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionsStation2_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionsStation3_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionsStation4_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionsStation5_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionsStation6_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionsStation7_Click(object sender, EventArgs e)
        {

        }

        private void btnOptionsStation8_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleState1_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleState2_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleState3_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleState4_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleState5_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleState6_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleState7_Click(object sender, EventArgs e)
        {

        }

        private void btnToggleState8_Click(object sender, EventArgs e)
        {

        }
    }
}
