using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACCSharedMemory
{
    internal class GameStatusEventArgs : EventArgs
    {
        public STATUS GameStatus {get; private set;}

        public GameStatusEventArgs(STATUS status)
        {
            GameStatus = status;
        }
    }
}
