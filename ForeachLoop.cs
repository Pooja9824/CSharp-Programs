using System;
class ForeachDemo 
{
    public static void Main()
    {
        int[] age=new int[3];
        age[0]=1;
        age[1]=2;
        age[2]=3;

       foreach(int a in age)
       {
           Console.WriteLine(a);
       }
    }
}