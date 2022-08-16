using System;

class piramide3
{
    public static void Main()
    {
        for(int i=1;i<=5;i++)
        { 
           
            for(int j=1;j<=i;j++)
            {
                if(j%2==0)
                {
                   Console.Write("#"); 
                }
                else
                {
                Console.Write("*");
                }
            }
           Console.WriteLine("");
        }
    }
}