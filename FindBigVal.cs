using System;
class FindBigVal
{
    public static void Main()
    {
        Console.WriteLine("Enter any three value:-");
        int a=Int32.Parse(Console.ReadLine());

        int b=Int32.Parse(Console.ReadLine());

        int c=Int32.Parse(Console.ReadLine());

        if(a>b && a>c)
        {
             Console.WriteLine("a is big");
        }
        else if(b>a && b>c)
        {
            Console.WriteLine("b is big");
        }
        else if(c>a && c>b)
        {
            Console.WriteLine("c is big");
        }
        else
        {
            Console.WriteLine("Enter proper value");
        }
        
    }
}