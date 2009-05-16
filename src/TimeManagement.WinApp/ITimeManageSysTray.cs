using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagement.WinApp
{
    public interface ITimeManageSysTray
    {
        event EventHandler StopEvent;
        event EventHandler StartEvent;
        event EventHandler ExitEvent;
    }
}
