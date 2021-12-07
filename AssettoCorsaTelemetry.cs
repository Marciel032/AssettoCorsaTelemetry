using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCSharedMemory
{
    public class AssettoCorsaTelemetry
    {
        public STATUS GameStatus { get; set; }
        public Graphics Graphics { get; set; }
        public Physics Physics { get; set; }
        public StaticInfo StaticInfo { get; set; }

        public AssettoCorsaTelemetry()
        {
            GameStatus = STATUS.OFF;
            Graphics = new Graphics();
            Physics = new Physics();
            StaticInfo = new StaticInfo();
        }
    }
}
