using System;

namespace stairwaytoheaven
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("hey hows it goin wanna make a staircase why? because i make staircases put in a number my dude.");
			int num = int.Parse(Console.ReadLine());
				string msg = "";
			int i = 0;
			while (i < num)
			{
				if (i < num)
					i++;
					msg += "*";
				    Console.WriteLine (msg);
			}
		}
	}
}

