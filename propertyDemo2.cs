using System;
class property2
{
    public String Country
    {
        set
        {
            _Country=value;
        }
        get
        {
            return _Country;
        }
    }
    public String State
    {
        set
        {
            _State=value;
        }
        get
        {
            return _State;
        }
    }
    private String _Country;
    private String _State;
}
class propertyDemo2
{
    public static void Main()
    {
        property2 pro=new property2();
        Console.WriteLine("Enter name of your country:-");
        pro.Country=Console.ReadLine();
       
        Console.WriteLine();
        Console.WriteLine("Enter name of Your state:-");
        pro.State=Console.ReadLine();
        
        Console.WriteLine("-------------------------------");
        Console.WriteLine("my Country is="+pro.Country);
        Console.WriteLine("my state is="+pro.State);
    }
}
