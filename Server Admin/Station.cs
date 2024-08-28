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
        public int SteeringHelp { get; set; }
        public int BrakingHelp { get; set; }
        public int StabilityControl { get; set; }
        public int AutoShifting { get; set; }
        public int TractionControl { get; set; }
        public int AntiLockBrakes { get; set; }
        public int DrivingLine { get; set; }
        public string Name { get; set; }
        public string Nick { get; set; }

        public Station(bool isAlive, int steeringHelp, int brakingHelp, int stabilityControl, int autoShifting, int tractionControl, int antiLockBrakes, int drivingLine, string name, string nick)
        {
            IsAlive = isAlive;
            SteeringHelp = steeringHelp;
            BrakingHelp = brakingHelp;
            StabilityControl = stabilityControl;
            AutoShifting = autoShifting;
            TractionControl = tractionControl;
            AntiLockBrakes = antiLockBrakes;
            DrivingLine = drivingLine;
            Name = name;
            Nick = nick;
        }

        public Station()
        {
            IsAlive = false;
            SteeringHelp = 0;
            BrakingHelp = 0;
            StabilityControl = 0;
            AutoShifting = 0;
            TractionControl = 0;
            AntiLockBrakes = 0;
            DrivingLine = 0;
            Name = "Jugador";
            Nick = "Jugador";
        }
    }
}
