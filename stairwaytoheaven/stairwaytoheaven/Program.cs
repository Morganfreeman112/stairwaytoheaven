using System;

namespace stairwaytoheaven
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (" i make staircases put in a number.");
			int num = int.Parse(Console.ReadLine());
			string msg = "";
			for (int i = 0; i < num; i++)
			if (i < num)
			{
				msg += "*";
				Console.WriteLine (msg.PadLeft(num));
			}
		}
	}
}