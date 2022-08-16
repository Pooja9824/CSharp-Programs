using System;
class ThreeD
{
    int x,y,z;
    public ThreeD()
    {
        x=y=z=0;
    }
    public ThreeD(int i,int j,int k)
    {
        x=i;
        y=j;
        z=k;
    }
    public static ThreeD operator +(ThreeD op1,ThreeD op2)
    {
        ThreeD result=new ThreeD();
        result.x=op1.x+op2.x;
        result.y=op1.y+op2.y;
        result.z=op1.z+op2.z;
        return result;
    }
    public static ThreeD operator -(ThreeD op1,ThreeD op2)
    {
        ThreeD result=new ThreeD();
        result.x=op1.x-op2.x;
        result.y=op1.y-op2.y;
        result.z=op1.z-op2.z;
        return result;
    }
    public void Show()
    {
        Console.WriteLine(x+" "+y+" "+z);
    }
}
public class ThreeDDemo
{
    public static void Main()
    {
        ThreeD a=new ThreeD(1,2,3);
        ThreeD b=new ThreeD(10,10,10);
        ThreeD c=new ThreeD();

        Console.WriteLine("here is a");
        a.Show();
        Console.WriteLine();

        Console.WriteLine("here is b");
        b.Show();
        Console.WriteLine();

        c=a+b;
        Console.WriteLine("Result of a+b");
        c.Show();
        Console.WriteLine();

        c=a+b+c;
        Console.WriteLine("Result of a+b+c");
        c.Show();
        Console.WriteLine();

        c=c-a;
        Console.WriteLine("Result of c-a");
        c.Show();
        Console.WriteLine();

        c=c-b;
        Console.WriteLine("Result of c-b");
        c.Show();
        Console.WriteLine();        
    }
}