using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Station(bool isAlive, int steeringHelp, int brakingHelp, int stabilityControl, int autoShifting, int tractionControl, int antiLockBrakes)
        {
            IsAlive = isAlive;
            SteeringHelp = steeringHelp;
            BrakingHelp = brakingHelp;
            StabilityControl = stabilityControl;
            AutoShifting = autoShifting;
            TractionControl = tractionControl;
            AntiLockBrakes = antiLockBrakes;
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
        }
    }
}
