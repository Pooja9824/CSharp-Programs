using System;
class employee
{
	public static void Main()
	{
		string gen;
        string name;
		int sal;
		float ta;
		float da;
		float total;

        Console.WriteLine("Enter your name:-");
		name=Console.ReadLine();
		Console.WriteLine("Enter your Gender(m/f):-");
		gen=Console.ReadLine();
		Console.WriteLine("Enter Your salary:-");
		sal=Int32.Parse(Console.ReadLine());
		Console.WriteLine("Name={0},Salary={1}",name,sal);

        Console.WriteLine("-------------------------------------");
		
		if(gen=="m")
		{
			if (sal<10000)
			{
				ta=sal*5/100;
				da=sal*10/100;
				total=sal+ta+da;
				Console.WriteLine("salary={0},ta={1},da={2}",sal,ta,da);
				Console.WriteLine("Total Salary={0}",total);
			}
			else if(sal>=10000 && sal<60000)
			{
				ta=sal*6/100;
				da=sal*11/100;
				total=sal+ta+da;
				Console.WriteLine("salary={0},ta={1},da={2}",sal,ta,da);
				Console.WriteLine("Total Salary={0}",total);
			}
			else if(sal>=60000)
			{
				ta=sal*7/100;
				da=sal*12/100;
				total=sal+ta+da;
				Console.WriteLine("salary={0},ta={1},da={2}",sal,ta,da);
				Console.WriteLine("Total Salary={0}",total);
			}
			else
			{
				Console.WriteLine("Enter Proper Value");
			}
			
		}
	                   else if(gen=="f")
		{
			if (sal<10000)
			{
				ta=sal*4/100;
				da=sal*9/100;
				total=sal+ta+da;
				Console.WriteLine("salary={0},ta={1},da={2}",sal,ta,da);
				Console.WriteLine("Total Salary={0}",total);
			}
			else if(sal>=10000 && sal<60000)
			{
				ta=sal*3/100;
				da=sal*8/100;
				total=sal+ta+da;
				Console.WriteLine("salary={0},ta={1},da={2}",sal,ta,da);
				Console.WriteLine("Total Salary={0}",total);
			}
			else if(sal>=60000)
			{
				ta=sal*2/100;
				da=sal*7/100;
				total=sal+ta+da;
				Console.WriteLine("salary={0},ta={1},da={2}",sal,ta,da);
				Console.WriteLine("Total Salary={0}",total);
			}
			else
			{
				Console.WriteLine("Enter Proper Value");
			}
		}
		else
		{
			Console.WriteLine("Enter m or f");
		}
	}
}