using System;
class propertyDemo
{
    public String FirstName
    {
        set
        {
            _FirstName=value;
        }
        get
        {
            return _FirstName;
        }
    }
     private String _FirstName;
}
class propertyDemo1
{
    public static void Main()
    {
        propertyDemo pro=new propertyDemo();
        pro.FirstName="India";
        Console.WriteLine(pro.FirstName);
    }
}