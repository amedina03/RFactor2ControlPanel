using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Text.Json;

namespace Server_Admin
{
    public partial class Form1 : Form
    {
        private Station easyStation = new Station(1, 1, 2, 3, 3, 2, 3, 1);
        private Station mediumStation = new Station(0, 0, 2, 3, 3, 2, 3, 1);
        private Station hardStation = new Station(0, 0, 1, 0, 1, 1, 3, 0);
        private Station manualStation = new Station(0, 0, 0, 0, 0, 0, 0, 0);
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
            loadStations();
            // El texto vendr� de la api en formato json
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
            saveStations();
            await station1.SendSaveRequest();
        }

        private async void btnSaveStation2_Click(object sender, EventArgs e)
        {
            station2.IP = txtIPStation2.Text;
            station2.Server = txtServerStation2.Text;
            station2.Name = txtNameStation2.Text;
            station2.Nick = txtNameStation2.Text;
            saveStations();
            await station2.SendSaveRequest();
        }

        private async void btnSaveStation3_Click(object sender, EventArgs e)
        {
            station3.IP = txtIPStation3.Text;
            station3.Server = txtServerStation3.Text;
            station3.Name = txtNameStation3.Text;
            station3.Nick = txtNameStation3.Text;
            saveStations();
            await station3.SendSaveRequest();
        }

        private async void btnSaveStation4_Click(object sender, EventArgs e)
        {
            station4.IP = txtIPStation4.Text;
            station4.Server = txtServerStation4.Text;
            station4.Name = txtNameStation4.Text;
            station4.Nick = txtNameStation4.Text;
            saveStations();
            await station4.SendSaveRequest();
        }

        private async void btnSaveStation5_Click(object sender, EventArgs e)
        {
            station5.IP = txtIPStation5.Text;
            station5.Server = txtServerStation5.Text;
            station5.Name = txtNameStation5.Text;
            station5.Nick = txtNameStation5.Text;
            saveStations();
            await station5.SendSaveRequest();
        }

        private async void btnSaveStation6_Click(object sender, EventArgs e)
        {
            station6.IP = txtIPStation6.Text;
            station6.Server = txtServerStation6.Text;
            station6.Name = txtNameStation6.Text;
            station6.Nick = txtNameStation6.Text;
            saveStations();
            await station6.SendSaveRequest();
        }

        private async void btnSaveStation7_Click(object sender, EventArgs e)
        {
            station7.IP = txtIPStation7.Text;
            station7.Server = txtServerStation7.Text;
            station7.Name = txtNameStation7.Text;
            station7.Nick = txtNameStation7.Text;
            saveStations();
            await station7.SendSaveRequest();
        }

        private async void btnSaveStation8_Click(object sender, EventArgs e)
        {
            station8.IP = txtIPStation8.Text;
            station8.Server = txtServerStation8.Text;
            station8.Name = txtNameStation8.Text;
            station8.Nick = txtNameStation8.Text;
            saveStations();
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
            bool result = await station1.SendToggleRequest();
            if (result)
            {
                if (station1.IsAlive)
                    btnToggleState1.BackColor = Color.Lime;
                else
                    btnToggleState1.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private async void btnToggleState2_Click(object sender, EventArgs e)
        {
            station2.IP = txtIPStation2.Text;
            bool result = await station2.SendToggleRequest();
            if (result)
            {
                if (station2.IsAlive)
                    btnToggleState2.BackColor = Color.Lime;
                else
                    btnToggleState2.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private async void btnToggleState3_Click(object sender, EventArgs e)
        {
            station3.IP = txtIPStation3.Text;
            bool result = await station3.SendToggleRequest();
            if (result)
            {
                if (station3.IsAlive)
                    btnToggleState3.BackColor = Color.Lime;
                else
                    btnToggleState3.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private async void btnToggleState4_Click(object sender, EventArgs e)
        {
            station4.IP = txtIPStation4.Text;
            bool result = await station4.SendToggleRequest();
            if (result)
            {
                if (station4.IsAlive)
                    btnToggleState4.BackColor = Color.Lime;
                else
                    btnToggleState4.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private async void btnToggleState5_Click(object sender, EventArgs e)
        {
            station5.IP = txtIPStation5.Text;
            bool result = await station5.SendToggleRequest();
            if (result)
            {
                if (station5.IsAlive)
                    btnToggleState5.BackColor = Color.Lime;
                else
                    btnToggleState5.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private async void btnToggleState6_Click(object sender, EventArgs e)
        {
            station6.IP = txtIPStation6.Text;
            bool result = await station6.SendToggleRequest();
            if (result)
            {
                if (station6.IsAlive)
                    btnToggleState6.BackColor = Color.Lime;
                else
                    btnToggleState6.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private async void btnToggleState7_Click(object sender, EventArgs e)
        {
            station7.IP = txtIPStation7.Text;
            bool result = await station7.SendToggleRequest();
            if (result)
            {
                if (station7.IsAlive)
                    btnToggleState7.BackColor = Color.Lime;
                else
                    btnToggleState7.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private async void btnToggleState8_Click(object sender, EventArgs e)
        {
            station8.IP = txtIPStation8.Text;
            bool result = await station8.SendToggleRequest();
            if (result)
            {
                if (station8.IsAlive)
                    btnToggleState8.BackColor = Color.Lime;
                else
                    btnToggleState8.BackColor = Color.FromArgb(255, 128, 128);
            }
        }


        private void btnEasyStation1_Click(object sender, EventArgs e)
        {
            station1.CopyStationDifficulty(easyStation);
        }

        private void btnMediumStation1_Click(object sender, EventArgs e)
        {
            station1.CopyStationDifficulty(mediumStation);
        }

        private void btnHardStation1_Click(object sender, EventArgs e)
        {
            station1.CopyStationDifficulty(hardStation);
        }

        private void btnManualStation1_Click(object sender, EventArgs e)
        {
            station1.CopyStationDifficulty(manualStation);
        }

        private void btnEasyStation2_Click(object sender, EventArgs e)
        {
            station2.CopyStationDifficulty(easyStation);
        }

        private void btnMediumStation2_Click(object sender, EventArgs e)
        {
            station2.CopyStationDifficulty(mediumStation);
        }

        private void btnHardStation2_Click(object sender, EventArgs e)
        {
            station2.CopyStationDifficulty(hardStation);
        }

        private void btnManualStation2_Click(object sender, EventArgs e)
        {
            station2.CopyStationDifficulty(manualStation);
        }

        private void btnEasyStation3_Click(object sender, EventArgs e)
        {
            station3.CopyStationDifficulty(easyStation);
        }

        private void btnMediumStation3_Click(object sender, EventArgs e)
        {
            station3.CopyStationDifficulty(mediumStation);
        }

        private void btnHardStation3_Click(object sender, EventArgs e)
        {
            station3.CopyStationDifficulty(hardStation);
        }

        private void btnManualStation3_Click(object sender, EventArgs e)
        {
            station3.CopyStationDifficulty(manualStation);
        }

        private void btnEasyStation4_Click(object sender, EventArgs e)
        {
            station4.CopyStationDifficulty(easyStation);
        }

        private void btnMediumStation4_Click(object sender, EventArgs e)
        {
            station4.CopyStationDifficulty(mediumStation);
        }

        private void btnHardStation4_Click(object sender, EventArgs e)
        {
            station4.CopyStationDifficulty(hardStation);
        }

        private void btnManualStation4_Click(object sender, EventArgs e)
        {
            station4.CopyStationDifficulty(manualStation);
        }

        private void btnEasyStation5_Click(object sender, EventArgs e)
        {
            station5.CopyStationDifficulty(easyStation);
        }

        private void btnMediumStation5_Click(object sender, EventArgs e)
        {
            station5.CopyStationDifficulty(mediumStation);
        }

        private void btnHardStation5_Click(object sender, EventArgs e)
        {
            station5.CopyStationDifficulty(hardStation);
        }

        private void btnManualStation5_Click(object sender, EventArgs e)
        {
            station5.CopyStationDifficulty(manualStation);
        }

        private void btnEasyStation6_Click(object sender, EventArgs e)
        {
            station6.CopyStationDifficulty(easyStation);
        }

        private void btnMediumStation6_Click(object sender, EventArgs e)
        {
            station6.CopyStationDifficulty(mediumStation);
        }

        private void btnHardStation6_Click(object sender, EventArgs e)
        {
            station6.CopyStationDifficulty(hardStation);
        }

        private void btnManualStation6_Click(object sender, EventArgs e)
        {
            station6.CopyStationDifficulty(manualStation);
        }

        private void btnEasyStation7_Click(object sender, EventArgs e)
        {
            station7.CopyStationDifficulty(easyStation);
        }

        private void btnMediumStation7_Click(object sender, EventArgs e)
        {
            station7.CopyStationDifficulty(mediumStation);
        }

        private void btnHardStation7_Click(object sender, EventArgs e)
        {
            station7.CopyStationDifficulty(hardStation);
        }

        private void btnManualStation7_Click(object sender, EventArgs e)
        {
            station7.CopyStationDifficulty(manualStation);
        }

        private void btnEasyStation8_Click(object sender, EventArgs e)
        {
            station8.CopyStationDifficulty(easyStation);
        }

        private void btnMediumStation8_Click(object sender, EventArgs e)
        {
            station8.CopyStationDifficulty(mediumStation);
        }

        private void btnHardStation8_Click(object sender, EventArgs e)
        {
            station8.CopyStationDifficulty(hardStation);
        }

        private void btnManualStation8_Click(object sender, EventArgs e)
        {
            station8.CopyStationDifficulty(manualStation);
        }

        private async void btnEndRace1_Click(object sender, EventArgs e)
        {
            saveStationConnections(station1, false);
            await station1.SendFinishRaceRequest();
        }

        private async void btnEndRace2_Click(object sender, EventArgs e)
        {
            saveStationConnections(station2, false);
            await station2.SendFinishRaceRequest();
        }

        private async void btnEndRace3_Click(object sender, EventArgs e)
        {
            saveStationConnections(station3, false);
            await station3.SendFinishRaceRequest();
        }

        private async void btnEndRace4_Click(object sender, EventArgs e)
        {
            saveStationConnections(station4, false);
            await station4.SendFinishRaceRequest();
        }

        private async void btnEndRace5_Click(object sender, EventArgs e)
        {
            saveStationConnections(station5, false);
            await station5.SendFinishRaceRequest();
        }

        private async void btnEndRace6_Click(object sender, EventArgs e)
        {
            saveStationConnections(station6, false);
            await station6.SendFinishRaceRequest();
        }

        private async void btnEndRace7_Click(object sender, EventArgs e)
        {
            saveStationConnections(station7, false);
            await station7.SendFinishRaceRequest();
        }

        private async void btnEndRace8_Click(object sender, EventArgs e)
        {
            saveStationConnections(station8, false);
            await station8.SendFinishRaceRequest();
        }

        private async void btnConnectStation1_Click(object sender, EventArgs e)
        {
            saveStationConnections(station1, true);
            await station1.SendJoinRequest();
        }

        private async void btnConnectStation2_Click(object sender, EventArgs e)
        {
            saveStationConnections(station2, true);
            await station2.SendJoinRequest();
        }

        private async void btnConnectStation3_Click(object sender, EventArgs e)
        {
            saveStationConnections(station3, true);
            await station3.SendJoinRequest();
        }

        private async void btnConnectStation4_Click(object sender, EventArgs e)
        {
            saveStationConnections(station4, true);
            await station4.SendJoinRequest();
        }

        private async void btnConnectStation5_Click(object sender, EventArgs e)
        {
            saveStationConnections(station5, true);
            await station5.SendJoinRequest();
        }

        private async void btnConnectStation6_Click(object sender, EventArgs e)
        {
            saveStationConnections(station6, true);
            await station6.SendJoinRequest();
        }

        private async void btnConnectStation7_Click(object sender, EventArgs e)
        {
            saveStationConnections(station7, true);
            await station7.SendJoinRequest();
        }

        private async void btnConnectStation8_Click(object sender, EventArgs e)
        {
            saveStationConnections(station8, true);
            await station8.SendJoinRequest();
        }
        private void saveStations()
        {
            List<Station> stationList = new List<Station> { station1, station2, station3, station4, station5, station6, station7, station8 };
            string jsonData = JsonSerializer.Serialize(stationList);
            string programFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string saveFolder = programFilesX86 + "\\rFactorServerAdmin";
            File.WriteAllText(saveFolder + "\\userData.json", jsonData);
        }
        private void saveStationConnections(Station stationToSave, bool start)
        {
            string programFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string saveFolder = programFilesX86 + "\\rFactorServerAdmin";
            string filePath = saveFolder + "\\connectionRegistry.json";

            List<Dictionary<string, object>> stations = new List<Dictionary<string, object>>();

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(existingJson))
                {
                    stations = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(existingJson);
                }
            }

            var stationDict = JsonSerializer.Deserialize<Dictionary<string, object>>(JsonSerializer.Serialize(stationToSave));

            stationDict["DateAdded"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (start) 
            {
                stationDict["Action"] = "Start";
            }
            else
            {
                stationDict["Action"] = "End";
            }

            stationDict.Remove("IsAlive");
            stationDict.Remove("SteeringHelp");
            stationDict.Remove("BrakingHelp");
            stationDict.Remove("StabilityControl");
            stationDict.Remove("AutoShifting");
            stationDict.Remove("ThrottleControl");
            stationDict.Remove("AntiLockBrakes");
            stationDict.Remove("DrivingLine");
            stationDict.Remove("AutoReverse");
            stationDict.Remove("Nick");

            stations.Add(stationDict);

            string jsonData = JsonSerializer.Serialize(stations);
            File.WriteAllText(filePath, jsonData);
        }
        private void loadStations()
        {
            string programFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
            string saveFolder = programFilesX86 + "\\rFactorServerAdmin";
            if (!Directory.Exists(saveFolder))
            {
                Directory.CreateDirectory(saveFolder);
            }
            if (File.Exists(saveFolder + "\\userData.json"))
            {
                string data = File.ReadAllText(saveFolder + "\\userData.json");
                List <Station> stationList = JsonSerializer.Deserialize<List<Station>>(data);

                station1 = stationList[0];
                station2 = stationList[1];
                station3 = stationList[2];
                station4 = stationList[3];
                station5 = stationList[4];
                station6 = stationList[5];
                station7 = stationList[6];
                station8 = stationList[7];


                txtNameStation1.Text = station1.Name == "Jugador" ? "" : station1.Name;
                txtIPStation1.Text = station1.IP;
                txtServerStation1.Text = station1.Server;

                txtNameStation2.Text = station2.Name == "Jugador" ? "": station2.Name;
                txtIPStation2.Text = station2.IP;
                txtServerStation2.Text = station2.Server;

                txtNameStation3.Text = station3.Name == "Jugador" ? "" : station3.Name;
                txtIPStation3.Text = station3.IP;
                txtServerStation3.Text = station3.Server;

                txtNameStation4.Text = station4.Name == "Jugador" ? "" : station4.Name;
                txtIPStation4.Text = station4.IP;
                txtServerStation4.Text = station4.Server;

                txtNameStation5.Text = station5.Name == "Jugador" ? "" : station5.Name;
                txtIPStation5.Text = station5.IP;
                txtServerStation5.Text = station5.Server;

                txtNameStation6.Text = station6.Name == "Jugador" ? "" : station6.Name;
                txtIPStation6.Text = station6.IP;
                txtServerStation6.Text = station6.Server;

                txtNameStation7.Text = station7.Name == "Jugador" ? "" : station7.Name;
                txtIPStation7.Text = station7.IP;
                txtServerStation7.Text = station7.Server;

                txtNameStation8.Text = station8.Name == "Jugador" ? "" : station8.Name;
                txtIPStation8.Text = station8.IP;
                txtServerStation8.Text = station8.Server;

            }
            else
            {
                station1 = new Station();
                station2 = new Station();
                station3 = new Station();
                station4 = new Station();
                station5 = new Station();
                station6 = new Station();
                station7 = new Station();
                station8 = new Station();
            }
        }
    }
}
