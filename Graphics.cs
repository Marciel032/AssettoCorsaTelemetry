using System;
using System.Runtime.InteropServices;

namespace ACCSharedMemory
{
    public enum FLAG_TYPE
    {
        NO_FLAG = 0,
        BLUE_FLAG = 1,
        YELLOW_FLAG = 2,
        BLACK_FLAG = 3,
        WHITE_FLAG = 4,
        CHECKERED_FLAG = 5,
        PENALTY_FLAG = 6,
        GREEN_FLAG = 7,
        ORANGE_FLAG = 8
    }

    public enum TRACK_GRIP_STATUS
    {
        GREEN = 0,
        FAST = 1,
        OPTIMUM = 2,
        GREASY = 3,
        DAMP = 4,
        WET = 5,
        FLOODED = 6
    }

    public enum PENALTY_TYPE
    {
        None = 0,
        DriveThrough_Cutting = 1 ,
        StopAndGo_10_Cutting = 2 ,
        StopAndGo_20_Cutting = 3 ,
        StopAndGo_30_Cutting = 4 ,
        Disqualified_Cutting = 5 ,
        RemoveBestLaptime_Cutting = 6 ,
        DriveThrough_PitSpeeding = 7 ,
        StopAndGo_10_PitSpeeding = 8 ,
        StopAndGo_20_PitSpeeding = 9 ,
        StopAndGo_30_PitSpeeding = 10 ,
        Disqualified_PitSpeeding = 11 ,
        RemoveBestLaptime_PitSpeeding = 12 ,
        Disqualified_IgnoredMandatoryPit = 13 ,
        PostRaceTime = 14 ,
        Disqualified_Trolling = 15 ,
        Disqualified_PitEntry = 16 ,
        Disqualified_PitExit = 17 ,
        Disqualified_Wrongway = 18 ,
        DriveThrough_IgnoredDriverStint = 19 ,
        Disqualified_IgnoredDriverStint = 20 ,
        Disqualified_ExceededDriverStintLimit = 21
    }

    public enum STATUS
    {
        OFF = 0,
        REPLAY = 1,
        LIVE = 2,
        PAUSE = 3
    }

    public enum SESSION_TYPE
    {
        UNKNOWN = -1,
        PRACTICE = 0,
        QUALIFY = 1,
        RACE = 2,
        HOTLAP = 3,
        TIME_ATTACK = 4,
        DRIFT = 5,
        DRAG = 6,
        HOTSTINT = 7,
        HOTSTINTSUPERPOLE = 8
    }

    public enum RAIN_INTENSITY
    {
        NO_RAIN = 0,
        DRIZZLE = 1,
        LIGHT_RAIN = 2,
        MEDIUM_RAIN = 3,
        HEAVY_RAIN = 4,
        THUNDERSTORM = 5
    }

    internal class GraphicsEventArgs : EventArgs
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

        public STATUS Status;
        public SESSION_TYPE Session;

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
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 180)]
        public float[] CarCoordinates;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 60)]
        public int[] carID;
        public int playerCarID;
        public float PenaltyTime;

        public FLAG_TYPE Flag;
        public PENALTY_TYPE penalty;
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
        public TRACK_GRIP_STATUS trackGripStatus;
        public RAIN_INTENSITY rainIntensity;
        public RAIN_INTENSITY rainIntensityIn10min;
        public RAIN_INTENSITY rainIntensityIn30min;
        public int currentTyreSet;
        public int strategyTyreSet;
        public int gapAhead;
        public int gapBehind;
        

    }
}
