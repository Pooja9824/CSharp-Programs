using System;

class table
{
    public static void Main()
    {
        Console.WriteLine("Enter a number for which you want to create table");
        int i=Int32.Parse(Console.ReadLine());
        for(int j=1;j<=10;j++)
        {
            //a=i*j;
            Console.WriteLine("{0} x {1} = {2}",i,j,i*j);
        }
    }
}
