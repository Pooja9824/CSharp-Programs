using System;
class B
{
	protected int i,j;
	public void setab(int a,int b)
	{
		i=a;
		j=b;
	}
	public void show()
	{
		Console.WriteLine("i{0} j{1}",i,j);
	}
}
class D:B
{
	int k;
	public void setk()
	{
		k=i*j;
	}
	public void showk()
	{
		Console.WriteLine(k);
	}
}
class protecteddemo
{
	public static void Main()
	{
		D ob=new D();
		ob.setab(2,3);
		ob.show();
		ob.setk();
		ob.showk();
	}
}