using System;
class arrayDemo
{
    public static void Main()
    {
        int[,] twodim=new int[4,3];

        Console.WriteLine("Enter values:-");
        
        for(int i=0;i<4;i++)
        {
            for(int j=0;j<3;j++)
            {
                twodim[i,j]=Int32.Parse(Console.ReadLine());
            }
        }
        for(int i=0;i<4;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(twodim[i,j]);
            }
            Console.WriteLine();
        }
    }
}