using System;
class array2
{
    public static void Main()
    {
        int[] age=new int[3];
        age[0]=1;
        age[1]=2;
        age[2]=3;

       for(int i=0;i<age.Length;i++)
       {
           Console.WriteLine("value={0}",age[i]);
       }
    }
}