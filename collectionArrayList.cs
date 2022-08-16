using System;
using System.Collections;
public class ArrayListDemo
{ 
	public static void Main()
	{
		ArrayList a=new ArrayList();
		Console.WriteLine();
		Console.WriteLine("Total element {0}",a.Count);
		Console.WriteLine("Adding six element");
		a.Add("a");
		a.Add("b");
		a.Add("c");
		a.Add("d");
		a.Add("e");
		a.Add("f");

		Console.WriteLine("total={0}",a.Count);

		for(int i=0;i<a.Count;i++)
		{
			Console.WriteLine(a[i]);
		}
		a.Remove("c");
		Console.WriteLine("After Removing c");
		
		foreach(String c in a)
		{
			Console.WriteLine(c);
		}
	}
}