using System;
public delegate void MulticastDelegate(int x,int y);
public class myclass
{
	public static void Add(int x,int y)
	{
		Console.WriteLine("You are in add");
		Console.WriteLine("{0}+{1}={2}",x,y,x+y);
	}
	public static void Multiply(int x,int y)
	{
		Console.WriteLine("you are in multiply");
		Console.WriteLine("{0}*{1}={2}",x,y,x*y);
	}
}
class prg
{
	static void Main()
	{
		MulticastDelegate del=new MulticastDelegate(myclass.Add);
		del +=new MulticastDelegate(myclass.Multiply);
		Console.WriteLine("calling Add and Multiply method");
		del(5,5);
		del -=new MulticastDelegate(myclass.Add);
		Console.WriteLine("Removed Add");
		del(5,5);
	}
} 