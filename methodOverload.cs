using System;
class overload
{
    public void ovldemo()
    {
        Console.WriteLine("No parameter");
    }
    public void ovldemo(int a)
    {
        Console.WriteLine("one parameter={0}",a);
    } 
    public int ovldemo(int a,int b)
    {
        Console.WriteLine("two parameter {0},{1}",a,b);
        return a+b;
    }
    public double ovldemo(double a,double b)
    {
        Console.WriteLine("Two double Parameter {0},{1}",a,b);
        return a+b;
    }
    class overloaddemo
    {
        public static void Main()
        {
            overload ob=new overload();
            int resI;
            double resD;
            ob.ovldemo();
            ob.ovldemo(3);
            Console.WriteLine("");
            resI=ob.ovldemo(4,6);
            Console.WriteLine("resI={0}",resI);
            Console.WriteLine("");
            resD=ob.ovldemo(1.1,2.32);
            Console.WriteLine("resD={0}",resD);            
        }
    }
}