using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagement.WinApp
{
    public interface IManagementDB
    {
        void InsertRecordEntry(RecordEntry item);        
    }
}
