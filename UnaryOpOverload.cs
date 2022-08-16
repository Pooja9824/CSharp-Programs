using System;
class ThreeDim
{
    int x,y,z;
    public ThreeDim()
    {
        x=y=x=0;
    }
    public ThreeDim(int i,int j,int k)
    {
        x=i;
        y=j;
        z=k;
    }
    public static ThreeDim operator +(ThreeDim op1,ThreeDim op2)
    {
        ThreeDim result=new ThreeDim();
        result.x=op1.x+op2.x;
        result.y=op1.y+op2.y;
        result.z=op1.z+op2.z;
        return result;
    }
    public static ThreeDim operator -(ThreeDim op)
    {
        ThreeDim result=new ThreeDim();
        result.x=-op.x;
        result.y=-op.y;
        result.z=-op.z;
        return result;
    }
    public void Show()
    {
        Console.WriteLine(x+" "+y+" "+z);
    }
}
class unaryDemo
{
    public static void Main()
    {
        ThreeDim a=new ThreeDim(1,2,3);
        ThreeDim b=new ThreeDim(10,10,10);
        ThreeDim c=new ThreeDim();

        Console.WriteLine("here is a");
        a.Show();
        Console.WriteLine();

        Console.WriteLine("here is b");
        b.Show();
        Console.WriteLine();

        c=a+b;
        Console.WriteLine("result of c");
        c.Show();
        Console.WriteLine();

        c=-a;
        Console.WriteLine("result of -1");
        c.Show();
    }
}