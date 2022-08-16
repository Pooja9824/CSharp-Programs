using System;
class tablePrint
{
    public static void Main(String[] args)
    {
        for(int i=1;i<=10;i++)
        {
            for(int j=i;j<=100;j+=10)
            {
                Console.Write(" {0} ",j);
            }
            Console.WriteLine(" ");
        }
    }
}