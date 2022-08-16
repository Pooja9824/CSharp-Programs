using System;
class JaggedArray
{
	public static void Main()
	{
		int[][] jagged=new int[3][];		
		jagged[0]=new int[2]{1,2};
		jagged[1]=new int[5]{10,20,30,40,50};
		jagged[2]=new int[4]{4,5,6,7};

		for(int row=0;row<jagged.Length;row++)
		{
			for(int col=0;col<jagged[row].Length;col++)
			{
				Console.WriteLine("row{0},col{1} value{2}",row,col,jagged[row][col]);
			}
		}
	}
}