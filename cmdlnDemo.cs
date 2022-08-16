//run program like <programe name> <val1> <val2> <val3>
//for example:- cmdlnDemo a 5 6 8 r 9  
using System;
class cmdlndemo
{
    public static void Main(String[] args)
    {
        if(args[0]=="a")
        {
            Console.WriteLine("you have entered={0}",args[0]);
        }
        else{

            Console.WriteLine("Length of argument={0}",args.Length);
        }
    }
}