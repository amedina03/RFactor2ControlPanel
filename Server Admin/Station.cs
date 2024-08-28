using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server_Admin
{
    public class Station
    {
        public bool IsAlive { get; set; }
        public string Server { get; set; }
        public string IP { get; set; }
        public int SteeringHelp { get; set; }
        public int BrakingHelp { get; set; }
        public int StabilityControl { get; set; }
        public int AutoShifting { get; set; }
        public int ThrottleControl { get; set; }
        public int AntiLockBrakes { get; set; }
        public int DrivingLine { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }

        public Station(bool isAlive, string server, string ip, int steeringHelp, int brakingHelp, int stabilityControl, int autoShifting, int throttleControl, int antiLockBrakes, int drivingLine, string name, string nick)
        {
            IsAlive = isAlive;
            Server = server; 
            IP = ip;
            SteeringHelp = steeringHelp;
            BrakingHelp = brakingHelp;
            StabilityControl = stabilityControl;
            AutoShifting = autoShifting;
            ThrottleControl = throttleControl;
            AntiLockBrakes = antiLockBrakes;
            DrivingLine = drivingLine;
            Name = name;
            Nick = nick;
        }

        public Station(int steeringHelp, int brakingHelp, int stabilityControl, int autoShifting, int throttleControl, int antiLockBrakes, int drivingLine)
        {
            IsAlive = false;
            Server = "";
            IP = "";
            SteeringHelp = steeringHelp;
            BrakingHelp = brakingHelp;
            StabilityControl = stabilityControl;
            AutoShifting = autoShifting;
            ThrottleControl = throttleControl;
            AntiLockBrakes = antiLockBrakes;
            DrivingLine = drivingLine;
            Name = "Jugador";
            Nick = "Jugador";
        }

        public Station()
        {
            IsAlive = false;
            Server = "";
            IP = "";
            SteeringHelp = 0;
            BrakingHelp = 0;
            StabilityControl = 0;
            AutoShifting = 0;
            ThrottleControl = 0;
            AntiLockBrakes = 0;
            DrivingLine = 0;
            Name = "Jugador";
            Nick = "Jugador";
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
    }
}
