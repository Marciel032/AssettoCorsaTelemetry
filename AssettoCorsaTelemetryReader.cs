using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AssettoCorsaSharedMemory
{
    public delegate void OnTelemetryUpdate(AssettoCorsaTelemetry telemetry);
    public class AssettoCorsaTelemetryReader
    {
        private readonly AssettoCorsa assettoCorsa;
        private readonly AssettoCorsaTelemetry telemetry;
        private readonly object lockControl;
        private readonly Timer updateTimer;
        private bool telemetryNeedUpdate;

        public event OnTelemetryUpdate OnTelemetryRead;

        public AssettoCorsaTelemetryReader(short updateInterval = 10)
        {                        
            telemetry = new AssettoCorsaTelemetry();
            lockControl = new object();
            telemetryNeedUpdate = true;

            assettoCorsa = new AssettoCorsa();
            assettoCorsa.GameStatusChanged += AssettoCorsa_GameStatusChanged;
            assettoCorsa.GraphicsUpdated += AssettoCorsa_GraphicsUpdated;
            assettoCorsa.PhysicsUpdated += AssettoCorsa_PhysicsUpdated;
            assettoCorsa.StaticInfoUpdated += AssettoCorsa_StaticInfoUpdated;

            updateTimer = new Timer(updateInterval);
            updateTimer.AutoReset = false;
            updateTimer.Elapsed += UpdateTimer_Elapsed;
        }        

        private void UpdateTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                lock (lockControl)
                {
                    if (!telemetryNeedUpdate)
                        return;

                    OnTelemetryRead?.Invoke(telemetry);
                    telemetryNeedUpdate = false;
                }
            }
            finally {
                updateTimer.Start();
            }
        }

        private void AssettoCorsa_GraphicsUpdated(object sender, GraphicsEventArgs e)
        {
            lock (lockControl)
            {
                telemetry.Graphics = e.Graphics;
                telemetryNeedUpdate = true;
            }
        }

        private void AssettoCorsa_GameStatusChanged(object sender, GameStatusEventArgs e)
        {
            lock (lockControl)
            {
                telemetry.GameStatus = e.GameStatus;
                telemetryNeedUpdate = true;
            }
        }

        private void AssettoCorsa_PhysicsUpdated(object sender, PhysicsEventArgs e)
        {
            lock (lockControl)
            {
                telemetry.Physics = e.Physics;
                telemetryNeedUpdate = true;
            }
        }

        private void AssettoCorsa_StaticInfoUpdated(object sender, StaticInfoEventArgs e)
        {
            lock (lockControl)
            {
                telemetry.StaticInfo = e.StaticInfo;
                telemetryNeedUpdate = true;
            }
        }

        public void Start() {
            updateTimer.Start();
            assettoCorsa.Start();
        }

        public void Stop() {
            assettoCorsa.Stop();
            updateTimer.Stop();
        }
    }
}
