using System;
using Quiz1.Abstract;

namespace Quiz1
{
	public class DbManager
	{
		private IDbManager _dbManager;
		public DbManager(IDbManager dbManager)
		{
			_dbManager = dbManager;
		}

        public void Post() => _dbManager.Post();
        public void Get() => _dbManager.Get();
        public void Put() => _dbManager.Put();
        public void Delete() => _dbManager.Delete();
		public void Crud() { Post();Get();Put();Delete(); } // Main Class da tek tek fonksiyonları çağırmamak amacıyla yazdım. Normal bir db senaryosunda mantıklı olmaz.
    }
}

