using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Text.Json;

namespace Server_Admin
{
    public partial class Form1 : Form
    {
        private Station easyStation = new Station(1, 1, 2, 1, 2, 2, 1);
        private Station mediumStation = new Station(0, 0, 2, 1, 2, 2, 1);
        private Station hardStation = new Station(0, 0, 1, 0, 1, 1, 1);
        private Station manualStation = new Station(0, 0, 0, 0, 0, 0, 0);
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
            // El texto vendrá de la api en formato json
            //string jsonString = File.ReadAllText("C:/Users/alexm/source/repos/RFactor2ControlPanel/Server Admin/Assets/player.json");
            //var optionsDictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
            //var drivingAids = JsonSerializer.Deserialize<Dictionary<string, object>>(optionsDictionary?["DRIVING AIDS"]?.ToString() ?? "");
            //jsonString = JsonSerializer.Serialize(optionsDictionary, new JsonSerializerOptions { WriteIndented = true });
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

        private void btnEasyStation1_Click(object sender, EventArgs e)
        {
            station1 = easyStation;
        }

        private void btnMediumStation1_Click(object sender, EventArgs e)
        {
            station1 = mediumStation;
        }

        private void btnHardStation1_Click(object sender, EventArgs e)
        {
            station1 = hardStation;
        }

        private void btnManualStation1_Click(object sender, EventArgs e)
        {
            station1 = manualStation;
        }

        private void btnEasyStation2_Click(object sender, EventArgs e)
        {
            station2 = easyStation;
        }

        private void btnMediumStation2_Click(object sender, EventArgs e)
        {
            station2 = mediumStation;
        }

        private void btnHardStation2_Click(object sender, EventArgs e)
        {
            station2 = hardStation;
        }

        private void btnManualStation2_Click(object sender, EventArgs e)
        {
            station2 = manualStation;
        }

        private void btnEasyStation3_Click(object sender, EventArgs e)
        {
            station3 = easyStation;
        }

        private void btnMediumStation3_Click(object sender, EventArgs e)
        {
            station3 = mediumStation;
        }

        private void btnHardStation3_Click(object sender, EventArgs e)
        {
            station3 = hardStation;
        }

        private void btnManualStation3_Click(object sender, EventArgs e)
        {
            station3 = manualStation;
        }

        private void btnEasyStation4_Click(object sender, EventArgs e)
        {
            station4 = easyStation;
        }

        private void btnMediumStation4_Click(object sender, EventArgs e)
        {
            station4 = mediumStation;
        }

        private void btnHardStation4_Click(object sender, EventArgs e)
        {
            station4 = hardStation;
        }

        private void btnManualStation4_Click(object sender, EventArgs e)
        {
            station4 = manualStation;
        }

        private void btnEasyStation5_Click(object sender, EventArgs e)
        {
            station5 = easyStation;
        }

        private void btnMediumStation5_Click(object sender, EventArgs e)
        {
            station5 = mediumStation;
        }

        private void btnHardStation5_Click(object sender, EventArgs e)
        {
            station5 = hardStation;
        }

        private void btnManualStation5_Click(object sender, EventArgs e)
        {
            station5 = manualStation;
        }

        private void btnEasyStation6_Click(object sender, EventArgs e)
        {
            station6 = easyStation;
        }

        private void btnMediumStation6_Click(object sender, EventArgs e)
        {
            station6 = mediumStation;
        }

        private void btnHardStation6_Click(object sender, EventArgs e)
        {
            station6 = hardStation;
        }

        private void btnManualStation6_Click(object sender, EventArgs e)
        {
            station6 = manualStation;
        }

        private void btnEasyStation7_Click(object sender, EventArgs e)
        {
            station7 = easyStation;
        }

        private void btnMediumStation7_Click(object sender, EventArgs e)
        {
            station7 = mediumStation;
        }

        private void btnHardStation7_Click(object sender, EventArgs e)
        {
            station7 = hardStation;
        }

        private void btnManualStation7_Click(object sender, EventArgs e)
        {
            station7 = manualStation;
        }

        private void btnEasyStation8_Click(object sender, EventArgs e)
        {
            station8 = easyStation;
        }

        private void btnMediumStation8_Click(object sender, EventArgs e)
        {
            station8 = mediumStation;
        }

        private void btnHardStation8_Click(object sender, EventArgs e)
        {
            station8 = hardStation;
        }

        private void btnManualStation8_Click(object sender, EventArgs e)
        {
            station8 = manualStation;
        }
    }
}
