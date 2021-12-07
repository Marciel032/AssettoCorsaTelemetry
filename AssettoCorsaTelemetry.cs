using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaSharedMemory
{
    public class AssettoCorsaTelemetry
    {
        public AC_STATUS GameStatus { get; set; }
        public Graphics Graphics { get; set; }
        public Physics Physics { get; set; }
        public StaticInfo StaticInfo { get; set; }

        public AssettoCorsaTelemetry()
        {
            GameStatus = AC_STATUS.AC_OFF;
            Graphics = new Graphics();
            Physics = new Physics();
            StaticInfo = new StaticInfo();
        }
    }
}
