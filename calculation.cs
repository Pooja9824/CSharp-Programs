using System;
class arith_opp
{
    public static void Main()
    {
        float a;
        float b;
        string c;
        Console.WriteLine("Enter value for a:-");
        a=float.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for b:-");
        b=float.Parse(Console.ReadLine());
        Console.WriteLine("Enter sign like +,-,*,/");
        c=Console.ReadLine();
        if(c=="+")
        {
            Console.WriteLine(a+b);
        }
        else if(c=="-")
        {
           Console.WriteLine(a-b); 
        }
        else if(c=="*")
        {
            Console.WriteLine(a*b);
        }
        else if(c=="/")
        {
            Console.WriteLine(a/b);
        }
        else
        {
            Console.WriteLine("Enter proper value");
        }
    }
}