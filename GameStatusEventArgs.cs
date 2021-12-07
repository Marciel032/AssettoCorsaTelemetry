using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACCSharedMemory
{
    public class GameStatusEventArgs : EventArgs
    {
        public ACC_STATUS GameStatus {get; private set;}

        public GameStatusEventArgs(ACC_STATUS status)
        {
            GameStatus = status;
        }
    }
}
