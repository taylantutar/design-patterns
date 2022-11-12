using Singleton;

System.Console.WriteLine("********************************");

var con1 = DbConnection.GetConnnection();
var con2 = DbConnection.GetConnnection();
var con3 = DbConnection.GetConnnection();

System.Console.WriteLine(con1.GetHashCode());
System.Console.WriteLine(con2.GetHashCode());
System.Console.WriteLine(con3.GetHashCode());

