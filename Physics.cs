using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ACCSharedMemory
{
    public class PhysicsEventArgs : EventArgs
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
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelLoad;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelPressure;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelAngularSpeed;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreWear;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyreDirtyLevel;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreCoreTemp;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] camberRad;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionTravel;

        public float drs;
        public float tc;
        public float heading;
        public float pitch;
        public float roll;
        public float cgHeight;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 5)]
        public float[] carDamage;

        public int NumberOfTyresOut;
        public int pitLimiterOn;
        public float abs;

        public float kersCharge;
        public float kersInput;
        public int autoshifterOn;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] rideHeight;

        // since 1.5
        public float turboBoost;
        public float ballast;
        public float airDensity;

        // since 1.6
        public float airTemp;
        public float roadTemp;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] localAngularVel;
        public float finalFF;

        // since 1.7
        public float PerformanceMeter;
        public int EngineBrake;
        public int ErsRecoveryLevel;
        public int ErsPowerLevel;
        public int ErsHeatCharging;
        public int ErsisCharging;
        public float KersCurrentKJ;
        public int DrsAvailable;
        public int DrsEnabled;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] brakeTemp;

        // since 1.10
        public float clutch;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempI;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreTempM;
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

        public int P2PActivation;
        public int P2PStatus;
        public float currentMaxRpm;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] mz;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] fx;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] fy;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] slipRatio;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] slipAngle;
        public int tcinAction;
        public int absinAction;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionDamage;
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
