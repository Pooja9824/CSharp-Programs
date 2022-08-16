using System;

class marksheet
{
    public static void Main()
    {
        int rno;
        string name;
        float java;
        float cs;
        float os;
        float net;

        Console.WriteLine("Enter roll no:-");
        rno=Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter name:-");
        name=Console.ReadLine();

        Console.WriteLine("Enter marks for java:-");
        java=float.Parse(Console.ReadLine());

         Console.WriteLine("Enter marks for c#:-");
        cs=float.Parse(Console.ReadLine());

         Console.WriteLine("Enter marks for os:-");
        os=float.Parse(Console.ReadLine());

         Console.WriteLine("Enter marks for net:-");
        net=float.Parse(Console.ReadLine());

        Console.WriteLine("-----------Result----------");
        
        Console.WriteLine("roll no   ="+rno);
        Console.WriteLine("name      ="+name);
        Console.WriteLine("java      ="+java);
        Console.WriteLine("c#        ="+cs);
        Console.WriteLine("os        ="+os);
        Console.WriteLine("networking="+net);

        Console.WriteLine("--------------------------");

        float sum=java+cs+os+net;
        Console.WriteLine("TOTLE IS="+sum);

        Console.WriteLine("--------------------------");
   
        float per;
        per=sum/4;
        Console.WriteLine("percentage:-"+per);

         if(per>=30)
        {
            Console.WriteLine("you are pass");
        }
        else
        {
            Console.WriteLine("better luck next time");
        }

       //grade

        if(per>90)
        {
            Console.WriteLine("Grade = A+");
            
        }
        else if(per>80 && per<90)
        {
            Console.WriteLine("Grade = A");
        }
        else if(per>70 && per<80)
        {
            Console.WriteLine("Grade = B+");
        }
        else if(per>60 && per<70)
        {
            Console.WriteLine("Grade = B");
        }
        else if(per>50 && per<60)
        {
            Console.WriteLine("Grade = C+");
        }
        else if(per>40 && per<50)
        {
            Console.WriteLine("Grade = C");
        }
         else if(per>35 && per<40)
        {
            Console.WriteLine("Grade = D+");
        }
        else if(per>30 && per<35)
        {
            Console.WriteLine("Grade = D");
        }
        else
        {
            Console.WriteLine("you are fail");
            
        }
        
        

    }
}