using System;
class arithopp
{
    public static void Main()
    {
        float a;
        float b;
        string c;
        int x;

    do
    {

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

        Console.WriteLine("Do you want to continue:-");
        Console.WriteLine("Press 1 for Continue");
        x=Int32.Parse(Console.ReadLine());
    
     }while(x==1);
  }
}