using System;
class myclass2
{
	public void method3()
	{
		unsafe
		{
			int x=10;
			int y=10;
			int *ptr1=&x;
			int *ptr2=&y;

			Console.WriteLine((int)ptr1);
			Console.WriteLine((int)ptr2);
			Console.WriteLine(*ptr1);
			Console.WriteLine(*ptr2);
		}
		
	}
}
class myclient
{
	public static void Main()
	{
		myclass2 m=new myclass2();
		m.method3();
	}
}