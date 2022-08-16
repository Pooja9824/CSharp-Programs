using System;
class ExceptionDemo
{
	public static void Main()
	{
		String s=null;
		try
		{
			Console.WriteLine("before calling s.ToLower");
                           		s.ToLower();
			Console.WriteLine("After calling s.ToLower");
		}
		catch(NullReferenceException obj1)
		{
			Console.WriteLine("i am in catch");
			Console.WriteLine("Message"+obj1.Message);
			Console.WriteLine("error"+obj1.StackTrace);
		}
		finally
		{
			Console.WriteLine("I am in finally");
		}
	}
}