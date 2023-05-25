using Quiz1;


/*
 Farklı veritabanı teknolojileri kullanıldığı için veritabanı teknolojisine bağımlılığı kaldırmak amacıyla dependency injection kullandım.
 Tüm database ler benzer işleri yaptıkları için abstract class yapısını da kullandım.
 Crud fonksiyonunu tüm fonksiyonları tek tek yazmamak amacıyla kullandım. Normal bir db senaryosunda anlamlı bir fonksiyon olmaz.
 */

DbManager mySqlDbManager = new DbManager(new MySqlDbManager());
DbManager msSqlDbManager = new DbManager(new MsSqlDbManager());
DbManager postgreDbManager = new DbManager(new PostgreDbManager());
DbManager oracleDbManager = new DbManager(new OracleDbManager());
DbManager mongoDbManager = new DbManager(new MongoDbManager());

mySqlDbManager.Crud();
msSqlDbManager.Crud();
postgreDbManager.Crud();
oracleDbManager.Crud();
mongoDbManager.Crud();