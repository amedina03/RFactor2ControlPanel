using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Text.Json;

namespace Server_Admin
{
    public partial class Form1 : Form
    {
        private Station easyStation = new Station(1, 1, 2, 3, 3, 2, 3);
        private Station mediumStation = new Station(0, 0, 2, 3, 3, 2, 3);
        private Station hardStation = new Station(0, 0, 1, 0, 1, 1, 3);
        private Station manualStation = new Station(0, 0, 0, 0, 0, 0, 0);
        // Holds station values
        private Station station1 = new Station();
        private Station station2 = new Station();
        private Station station3 = new Station();
        private Station station4 = new Station();
        private Station station5 = new Station();
        private Station station6 = new Station();
        private Station station7 = new Station();
        private Station station8 = new Station();

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
            station1.IP = txtIPStation1.Text;
            station1.Server = txtServerStation1.Text;
            station1.Name = txtNameStation1.Text;
            station1.Nick = txtNameStation1.Text;
            await station1.SendSaveRequest();
        }

        private async void btnSaveStation2_Click(object sender, EventArgs e)
        {
            station2.IP = txtIPStation2.Text;
            station2.Server = txtServerStation2.Text;
            station2.Name = txtNameStation2.Text;
            station2.Nick = txtNameStation2.Text;
            await station2.SendSaveRequest();
        }

        private async void btnSaveStation3_Click(object sender, EventArgs e)
        {
            station3.IP = txtIPStation3.Text;
            station3.Server = txtServerStation3.Text;
            station3.Name = txtNameStation3.Text;
            station3.Nick = txtNameStation3.Text;
            await station3.SendSaveRequest();
        }

        private async void btnSaveStation4_Click(object sender, EventArgs e)
        {
            station4.IP = txtIPStation4.Text;
            station4.Server = txtServerStation4.Text;
            station4.Name = txtNameStation4.Text;
            station4.Nick = txtNameStation4.Text;
            await station4.SendSaveRequest();
        }

        private async void btnSaveStation5_Click(object sender, EventArgs e)
        {
            station5.IP = txtIPStation5.Text;
            station5.Server = txtServerStation5.Text;
            station5.Name = txtNameStation5.Text;
            station5.Nick = txtNameStation5.Text;
            await station5.SendSaveRequest();
        }

        private async void btnSaveStation6_Click(object sender, EventArgs e)
        {
            station6.IP = txtIPStation6.Text;
            station6.Server = txtServerStation6.Text;
            station6.Name = txtNameStation6.Text;
            station6.Nick = txtNameStation6.Text;
            await station6.SendSaveRequest();
        }

        private async void btnSaveStation7_Click(object sender, EventArgs e)
        {
            station7.IP = txtIPStation7.Text;
            station7.Server = txtServerStation7.Text;
            station7.Name = txtNameStation7.Text;
            station7.Nick = txtNameStation7.Text;
            await station7.SendSaveRequest();
        }

        private async void btnSaveStation8_Click(object sender, EventArgs e)
        {
            station8.IP = txtIPStation8.Text;
            station8.Server = txtServerStation8.Text;
            station8.Name = txtNameStation8.Text;
            station8.Nick = txtNameStation8.Text;
            await station8.SendSaveRequest();
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

        private async void btnToggleState1_Click(object sender, EventArgs e)
        {
            station1.IP = txtIPStation1.Text;
            await station1.SendToggleRequest();
        }

        private async void btnToggleState2_Click(object sender, EventArgs e)
        {
            station2.IP = txtIPStation2.Text;
            await station2.SendToggleRequest();
        }

        private async void btnToggleState3_Click(object sender, EventArgs e)
        {
            station3.IP = txtIPStation3.Text;
            await station3.SendToggleRequest();
        }

        private async void btnToggleState4_Click(object sender, EventArgs e)
        {
            station4.IP = txtIPStation4.Text;
            await station4.SendToggleRequest();
        }

        private async void btnToggleState5_Click(object sender, EventArgs e)
        {
            station5.IP = txtIPStation4.Text;
            await station5.SendToggleRequest();
        }

        private async void btnToggleState6_Click(object sender, EventArgs e)
        {
            station6.IP = txtIPStation4.Text;
            await station6.SendToggleRequest();
        }

        private async void btnToggleState7_Click(object sender, EventArgs e)
        {
            station7.IP = txtIPStation4.Text;
            await station7.SendToggleRequest();
        }

        private async void btnToggleState8_Click(object sender, EventArgs e)
        {
            station8.IP = txtIPStation4.Text;
            await station8.SendToggleRequest();
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

        private void btnEndRace1_Click(object sender, EventArgs e)
        {

        }

        private void btnEndRace2_Click(object sender, EventArgs e)
        {

        }

        private void btnEndRace3_Click(object sender, EventArgs e)
        {

        }

        private void btnEndRace4_Click(object sender, EventArgs e)
        {

        }

        private void btnEndRace5_Click(object sender, EventArgs e)
        {

        }

        private void btnEndRace6_Click(object sender, EventArgs e)
        {

        }

        private void btnEndRace7_Click(object sender, EventArgs e)
        {

        }

        private void btnEndRace8_Click(object sender, EventArgs e)
        {

        }
    }
}
