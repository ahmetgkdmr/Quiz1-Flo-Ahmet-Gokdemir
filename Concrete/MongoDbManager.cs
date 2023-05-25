using System;
using Quiz1.Abstract;

namespace Quiz1
{
	public class MongoDbManager : BaseDbManager
	{
		public MongoDbManager() 
		{
			dbName = "Mongo";
		}
	}
}

