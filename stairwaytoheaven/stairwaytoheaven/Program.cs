using System;

namespace stairwaytoheaven
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (" i make staircases put in a number.");
			int num = int.Parse(Console.ReadLine());
            int numSpaces = num - 1;
            int numStars = 1;
            string spaces = "";

            for (int j = 0; j < num; j++)
            {
                string msg = "";

                for (int i = 0; i < numSpaces; i++)
                {
                    msg += " ";
                }

                for (int k = 0; k < numStars; k++)
                {
                    msg += "*";
                }
                numSpaces--;
                numStars++;
                Console.WriteLine(msg);
            }
		}
	}
}