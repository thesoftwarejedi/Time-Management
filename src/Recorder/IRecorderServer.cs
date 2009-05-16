using System;
using System.Collections.Generic;
using System.Text;

namespace Recorder
{
    public interface IRecorderServer
    {
        void Start();
        void Stop();
        bool IsRunning { get; }
    }
}
