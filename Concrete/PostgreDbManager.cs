using System;
using Quiz1.Abstract;

namespace Quiz1
{
	public class PostgreDbManager : BaseDbManager
	{
		public PostgreDbManager() 
		{
			dbName = "Postgre";
		}
	}
}

