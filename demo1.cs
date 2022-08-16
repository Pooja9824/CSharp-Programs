using System;
class SearchArrayElement
{
    public static void Main()
    {
        int[] arr=new int[10];
        int val1=0;
        int val2=0;

        Console.WriteLine("Enter 10 values:-");
        for(int i=0;i<arr.Length;i++)
        {
            Console.Write("value {0}=",i);
            arr[i]=Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter a value which you want to find:-");
        int j=Int32.Parse(Console.ReadLine());

        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==j)
            {
                val1=1;
                break;
            }
            val2=i;
        }
        if(val1==1)
        {
            Console.WriteLine("Value {0} is found at {1}",j,val2+1);
        }
        else
        {
            Console.WriteLine("Value is not found");
        }
    }
}