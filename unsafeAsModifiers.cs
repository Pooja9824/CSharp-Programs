using System;
class myclass4
{
	public unsafe void method2()
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
class myclient2
{
	public static void Main()
	{
		myclass4 m=new myclass4();
		m.method2();
	}
}