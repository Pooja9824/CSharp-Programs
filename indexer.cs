using System;
class mypriviousexp
{
	private String[] mycompanies=new String[10];

	public String this[int index]
	{
		get
		{
			if(mycompanies[index]==null)
			{
				return "null";
			}
			else
			{
				return mycompanies[index];
			}
		}
		set
		{
			if(index>0 || index<=10)
			{
				mycompanies[index]=value;
			}
		}
	}
}
class mymainclass
{
	public static void Main()
	{
		mypriviousexp mp=new mypriviousexp();
		mp[0]="Intel";
		mp[3]="Accer";
		mp[5]="compaq";
		for (int i=0;i<10;i++)
		{
			Console.WriteLine(mp[i]);
		}
	}
}