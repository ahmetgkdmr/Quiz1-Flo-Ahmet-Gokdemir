using System;
using Quiz1.Abstract;

namespace Quiz1
{
    public class MsSqlDbManager : BaseDbManager
    {
        public MsSqlDbManager()
        {
            dbName = "MsSql";
        }
    }
}

