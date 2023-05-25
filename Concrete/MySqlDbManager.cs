using System;
using Quiz1.Abstract;

namespace Quiz1
{
	public class MySqlDbManager : BaseDbManager
	{
		public MySqlDbManager() 
		{
			dbName = "MySql";
		}
	}
}

