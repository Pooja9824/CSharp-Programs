using System;
class Database
{
	public Database()
	{
		commonfield=42;
	}
	public int commonfield;
	public void commonMethod()
	{
		Console.WriteLine("Database Method called");
	}
}
class sqlserver:Database
{
	public void sqlserverMethod()
	{
		Console.WriteLine("sqlserver Method called");
	}
}
class oracle:Database
{
	public void oracleMethod()
	{
		Console.WriteLine("oracle method called");
	}
}
class inheritDemo
{
	public static void Main()
	{
		Console.WriteLine("calling sqlserver");
		sqlserver s=new sqlserver();
		Console.WriteLine("calling sqlserver method");
		s.sqlserverMethod();
		Console.WriteLine("calling common method");
		s.commonMethod();

		Console.WriteLine("accessing common field"+s.commonfield);

		Console.WriteLine("Calling oracle");
		oracle ob=new oracle();
		Console.WriteLine("calling oracle method");
		ob.oracleMethod();
		Console.WriteLine("calling common method");
		ob.commonMethod();
		Console.WriteLine("Accessing commonfield"+ob.commonfield);
	}
}