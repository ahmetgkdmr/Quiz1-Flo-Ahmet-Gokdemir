using System;
using Quiz1.Abstract;

namespace Quiz1
{
	public class OracleDbManager : BaseDbManager
	{
		public OracleDbManager() 
		{
			dbName = "Oracle";
		}
	}
}

