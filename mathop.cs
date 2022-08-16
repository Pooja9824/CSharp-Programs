using mymath;
using System;
class mathop
{
	public static void Main()
	{
		int x=10;
		int y=20;
		int sum=classadd.add(x,y);
		int product=classmul.mul(x,y);

		Console.WriteLine("sum={0}",sum);
		Console.WriteLine("product={0}",product);
	}
}