using System;
using System.Runtime.InteropServices;

namespace ACCSharedMemory
{
    internal class PhysicsEventArgs : EventArgs
    {
        public PhysicsEventArgs (Physics physics)
        {
            this.Physics = physics;
        }

        public Physics Physics { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct Coordinates
    {
        public float X;
        public float Y;
        public float Z;
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct Physics
    {
        public int packetId;
        public float gas;
        public float brake;
        public float fuel;
        public int gear;
        public int rpm;
        public float steerAngle;
        public float speedKmh;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] velocity;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] accG;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelSlip;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelLoad;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelPressure;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelAngularSpeed;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreWear;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreDirtyLevel;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreCoreTemp;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] camberRad;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionTravel;

        [Obsolete]
        public float drs;
        public float tc;
        public float heading;
        public float pitch;
        public float roll;
        [Obsolete]
        public float cgHeight;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 5)]
        public float[] carDamage;

        [Obsolete]
        public int NumberOfTyresOut;
        public int pitLimiterOn;
        public float abs;

        [Obsolete]
        public float kersCharge;
        [Obsolete]
        public float kersInput;
        public int autoshifterOn;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] rideHeight;

        // since 1.5
        public float turboBoost;
        [Obsolete]
        public float ballast;
        [Obsolete]
        public float airDensity;

        // since 1.6
        public float airTemp;
        public float roadTemp;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] localAngularVel;
        public float finalFF;

        // since 1.7
        [Obsolete]
        public float PerformanceMeter;
        [Obsolete]
        public int EngineBrake;
        [Obsolete]
        public int ErsRecoveryLevel;
        [Obsolete]
        public int ErsPowerLevel;
        [Obsolete]
        public int ErsHeatCharging;
        [Obsolete]
        public int ErsisCharging;
        [Obsolete]
        public float KersCurrentKJ;
        [Obsolete]
        public int DrsAvailable;
        [Obsolete]
        public int DrsEnabled;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] brakeTemp;

        // since 1.10
        public float clutch;

        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempI;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempM;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempO;

        // since 1.10.2
        public int isAIControlled;

        // since 1.11
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] tyreContactPoint;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] tyreContactNormal;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] tyreContactHeading;
        public float brakeBias;

        // since 1.12
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] localVelocity;

        [Obsolete]
        public int P2PActivation;
        [Obsolete]
        public int P2PStatus;
        [Obsolete]
        public float currentMaxRpm;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mz;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] fx;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] fy;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] slipRatio;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] slipAngle;
        [Obsolete]
        public int tcinAction;
        [Obsolete]
        public int absinAction;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        [Obsolete]
        public float[] suspensionDamage;
        [Obsolete]
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreTemp;
        public float waterTemp;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] brakePressure;
        public int frontBrakeCompound;
        public int rearBrakeCompound;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] padLife;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] discLife;
        public int ignitionOn;
        public int starterEngineOn;
        public int isEngineRunning;
        public float kerbVibrations;
        public float slipVibrations;
        public float gVibrations;
        public float absVibrations;

    }
}
