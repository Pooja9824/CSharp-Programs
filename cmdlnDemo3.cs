using System;
class cmdlnDemo3
{
    public static void Main(String[] args)
    {
        int val=0;
        for(int i=0;i<args.Length;i++)
        {
            Console.WriteLine("{0}",args[i]);
            val=1;
        }
        if(val==0)
        {
            Console.WriteLine("No argument has been passed");
        }
    }
}