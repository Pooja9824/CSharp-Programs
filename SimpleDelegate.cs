using System;
public delegate int mydelegate(int x,int y);

public class myclass1
{
	public static int Add(int x,int y)
	{
		return x+y;
	}
	public static int Multiply(int x,int y)
	{
		return x*y;
	}
}
class SimpleDelegate
{
	public static void Main()
	{
		mydelegate del1=new mydelegate(myclass1.Add);
		int result=del1(5,5);
		Console.WriteLine("Result={0}",result);
	
		mydelegate del2=new mydelegate(myclass1.Multiply);
		int mresult=del2(5,5);
		Console.WriteLine("Multiplication result={0}",mresult);
	}
}