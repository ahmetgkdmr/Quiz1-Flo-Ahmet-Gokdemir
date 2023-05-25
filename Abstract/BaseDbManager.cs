 using System;
namespace Quiz1.Abstract
{
	public abstract class BaseDbManager : IDbManager
	{
        protected string dbName = "";

        public void Post() => Console.WriteLine("Post ["+ dbName + "]");
        public void Get() => Console.WriteLine("Get ["+ dbName + "]");
        public void Put() => Console.WriteLine("Put ["+ dbName + "]");
        public void Delete() => Console.WriteLine("Delete ["+ dbName + "]");
    }
}

