using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACCSharedMemory
{
    internal class StaticInfoEventArgs : EventArgs
    {
        public StaticInfoEventArgs (StaticInfo staticInfo)
        {
            this.StaticInfo = staticInfo;
        }

        public StaticInfo StaticInfo { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct StaticInfo
    {
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String smVersion;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String acVersion;

        // session static info
        public int numberOfSessions;
        public int numCars;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String carModel;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String track;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String playerName;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String playerSurname;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String playerNick;

        public int SectorCount;

        // car static info
        public float maxTorque;
        public float maxPower;
        public int maxRpm;
        public float maxFuel;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionMaxTravel;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreRadius;

        // since 1.5
        public float MaxTurboBoost;
        public float Deprecated1; // AirTemp since 1.6 in physic
        public float Deprecated2; // RoadTemp since 1.6 in physic
        public int penaltiesEnabled;
        public float aidFuelRate;
        public float aidTireRate;
        public float aidMechanicalDamage;
        public int AllowTyreBlankets;
        public float aidStability;
        public int aidAutoClutch;
        public int aidAutoBlip;

        // since 1.7.1
        public int HasDRS;
        public int HasERS;
        public int HasKERS;
        public float KersMaxJoules;
        public int EngineBrakeSettingsCount;
        public int ErsPowerControllerCount;

        // since 1.7.2
        public float TrackSPlineLength;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public string TrackConfiguration;

        // since 1.10.2
        public float ErsMaxJ;

        // since 1.13
        public int IsTimedRace;
        public int HasExtraLap;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String CarSkin;
        public int ReversedGridPositions;
        public int PitWindowStart;
        public int PitWindowEnd;
    
        public int isOnline;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String dryTyresName;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String wetTyresName;
    }
}
