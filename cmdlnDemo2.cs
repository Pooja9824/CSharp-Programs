using System;
class cmdlnDemo2
{
    public static void Main(String[] args)
    {
        int num1,num2,op;
        num1=Int32.Parse(args[0]);
        num2=Int32.Parse(args[2]);

        if(args[1]=="+")
        {
            op=num1+num2;
            Console.WriteLine("{0}{1}{2}={3}",num1,args[1],num2,op);
        }
        else if(args[1]=="-")
        {
            op=num1-num2;
            Console.WriteLine("{0}{1}{2}={3}",num1,args[1],num2,op);
        }
        else if(args[1]=="*")
        {
            op=num1*num2;
            Console.WriteLine("{0}{1}{2}={3}",num1,args[1],num2,op);
        }
        else if(args[1]=="/")
        {
            op=num1/num2;
            Console.WriteLine("{0}{1}{2}={3}",num1,args[1],num2,op);
        }
        else
        {
            Console.WriteLine("Enter proper value");
        }

    }
}