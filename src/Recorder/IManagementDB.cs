using System;

namespace Recorder
{
    public interface IManagementDB
    {
        void InsertRecordEntry(RecordEntry item);        
    }
}
