using System;
class a
{
	public a()
	{
		Console.WriteLine("Constructing A");
	}
}
class b:a
{
	public b()
	{
		Console.WriteLine("Constucting B");
	}
}
class c:b
{	
	public c()
	{
		Console.WriteLine("Constructing C");
	}
}
class Demo
{
	public static void Main()
	{
		c c1=new c();
	}
}