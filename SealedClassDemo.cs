using System;
sealed class point
{
    public point(int x,int y)
    {
        x1=x;
        y1=y;
    }
    public int x1;
    public int y1;
}
/*
  Compiler error:-

  class myclass:point
  {

  }
*/
class sealedDemo
{
    public static void Main()
    {
        point pt=new point(10,15);
        Console.WriteLine("value x={0} y={1}",pt.x1,pt.y1);
    }
}
