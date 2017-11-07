using System;

namespace stairwaytoheaven
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hey hows it goin you wanna make a staircase ah i dont care  ill make one no matter what put in a number will ya m8");
			int Num = int.Parse(Console.ReadLine());
			for (int i = 0; i < Num; i++)
				Console.WriteLine(new String('*', i + 1).PadRight(Num, ' '));
		}
	}
}

