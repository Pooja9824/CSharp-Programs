using System;
class twodShape
{
	public double width,height;
	public void showdim()
	{
		Console.WriteLine("Width={0} height={1}",width,height);
	}
}
class trai:twodShape
{
	public string style="";
	public double area()
	{
		return width*height/2;
	}
	public void showStyle()
	{
		Console.WriteLine("trai style is {0}",style);
	}
}
class shapes
{
	public static void Main()
	{
		trai t1=new trai();
		trai t2=new trai();
		t1.width=4.0;
		t1.height=4.0;
		t1.style="left";
		t2.width=8.0;
		t2.height=8.0;
		t2.style="Right";

		Console.WriteLine("Info for t1");
		t1.showStyle();
		t1.showdim();
		Console.WriteLine("area is"+t1.area());

		Console.WriteLine("Info for t2");
		t2.showStyle();
		t2.showdim();
		Console.WriteLine("area is"+t2.area());
	}
}

