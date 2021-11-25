using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACCSharedMemory
{
    public enum ACC_FLAG_TYPE
    {
        ACC_NO_FLAG = 0,
        ACC_BLUE_FLAG = 1,
        ACC_YELLOW_FLAG = 2,
        ACC_BLACK_FLAG = 3,
        ACC_WHITE_FLAG = 4,
        ACC_CHECKERED_FLAG = 5,
        ACC_PENALTY_FLAG = 6,
        ACC_GREEN_FLAG = 7,
        ACC_ORANGE_FLAG = 8
    }

    public enum ACC_TRACK_GRIP_STATUS
    {
        ACC_GREEN = 0,
        ACC_FAST = 1,
        ACC_OPTIMUM = 2,
        ACC_GREASY = 3,
        ACC_DAMP = 4,
        ACC_WET = 5,
        ACC_FLOODED = 6
    }

    public enum ACC_PENALTY_TYPE
    {
        ACC_None = 0,
        ACC_DriveThrough_Cutting = 1 ,
        ACC_StopAndGo_10_Cutting = 2 ,
        ACC_StopAndGo_20_Cutting = 3 ,
        ACC_StopAndGo_30_Cutting = 4 ,
        ACC_Disqualified_Cutting = 5 ,
        ACC_RemoveBestLaptime_Cutting = 6 ,
        ACC_DriveThrough_PitSpeeding = 7 ,
        ACC_StopAndGo_10_PitSpeeding = 8 ,
        ACC_StopAndGo_20_PitSpeeding = 9 ,
        ACC_StopAndGo_30_PitSpeeding = 10 ,
        ACC_Disqualified_PitSpeeding = 11 ,
        ACC_RemoveBestLaptime_PitSpeeding = 12 ,
        ACC_Disqualified_IgnoredMandatoryPit = 13 ,
        ACC_PostRaceTime = 14 ,
        ACC_Disqualified_Trolling = 15 ,
        ACC_Disqualified_PitEntry = 16 ,
        ACC_Disqualified_PitExit = 17 ,
        ACC_Disqualified_Wrongway = 18 ,
        ACC_DriveThrough_IgnoredDriverStint = 19 ,
        ACC_Disqualified_IgnoredDriverStint = 20 ,
        ACC_Disqualified_ExceededDriverStintLimit = 21
    }

    public enum ACC_STATUS
    {
        ACC_OFF = 0,
        ACC_REPLAY = 1,
        ACC_LIVE = 2,
        ACC_PAUSE = 3
    }

    public enum ACC_SESSION_TYPE
    {
        ACC_UNKNOWN = -1,
        ACC_PRACTICE = 0,
        ACC_QUALIFY = 1,
        ACC_RACE = 2,
        ACC_HOTLAP = 3,
        ACC_TIME_ATTACK = 4,
        ACC_DRIFT = 5,
        ACC_DRAG = 6,
        ACC_HOTSTINT = 7,
        ACC_HOTSTINTSUPERPOLE = 8
    }

    public enum ACC_RAIN_INTENSITY
    {
        ACC_NO_RAIN = 0,
        ACC_DRIZZLE = 1,
        ACC_LIGHT_RAIN = 2,
        ACC_MEDIUM_RAIN = 3,
        ACC_HEAVY_RAIN = 4,
        ACC_THUNDERSTORM = 5
    }

    public class GraphicsEventArgs : EventArgs
    {
        public GraphicsEventArgs (Graphics graphics)
        {
            this.Graphics = graphics;
        }

        public Graphics Graphics { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct Graphics
    {
        public int PacketId;
        public ACC_STATUS Status;
        public ACC_SESSION_TYPE Session;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String CurrentTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String LastTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String BestTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String Split;
        public int CompletedLaps;
        public int Position;
        public int iCurrentTime;
        public int iLastTime;
        public int iBestTime;
        public float SessionTimeLeft;
        public float DistanceTraveled;
        public int IsInPit;
        public int CurrentSectorIndex;
        public int LastSectorTime;
        public int NumberOfLaps;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String TyreCompound;

        public float ReplayTimeMultiplier;
        public float NormalizedCarPosition;
        public int activeCars;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] CarCoordinates;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 60)]
        public int[] carID;
        public int playerCarID;
        public float PenaltyTime;
        public ACC_FLAG_TYPE Flag;
        public ACC_PENALTY_TYPE penalty;
        public int IdealLineOn;

        // since 1.5
        public int IsInPitLane;
        public float SurfaceGrip;
    
        // since 1.13
        public int MandatoryPitDone;

        public float windSpeed;
        public float windDirection;
        public int isSetupMenuVisisble;
        public int mainDisplayIndex;
        public int secondaryDisplayIndex;
        public int TC;
        public int TCCUT;
        public int EngineMap;
        public int ABS;
        public float fuelXLap;
        public int rainLights;
        public int flashingLights;
        public int lightsStage;
        public float exhaustTemperature;
        public int wiperLV;
        public int driverStintTotalTimeLeft;
        public int driverStintTimeLeft;
        public int rainTyres;
        public int sessionIndex;
        public float usedFuel;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String deltaLapTime;
        public int iDeltaLapTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String estimatedLapTime;
        
        public int iEstimatedLapTime;
        public int isDeltaPositive;
        public int iSplit;
        public int isValidLap;
        public float fuelEstimatedLaps;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String trackStatus;
        public int missingMandatoryPits;
        public float Clock;
        public int directionLightsLeft;
        public int directionLightsRight;
        public int GlobalYellow;
        public int GlobalYellow1;
        public int GlobalYellow2;
        public int GlobalYellow3;
        public int GlobalWhite;
        public int GlobalGreen;
        public int GlobalChequered;
        public int GlobalRed;
        public int mfdTyreSet;
        public float mfdFuelToAdd;
        public float mfdTyrePressureLF;
        public float mfdTyrePressureRF;
        public float mfdTyrePressureLR;
        public float mfdTyrePressureRR;
        public ACC_TRACK_GRIP_STATUS trackGripStatus;
        public ACC_RAIN_INTENSITY rainIntensity;
        public ACC_RAIN_INTENSITY rainIntensityIn10min;
        public ACC_RAIN_INTENSITY rainIntensityIn30min;
        public int currentTyreSet;
        public int strategyTyreSet;
        public int gapAhead;
        public int gapBehind;
        

    }
}
