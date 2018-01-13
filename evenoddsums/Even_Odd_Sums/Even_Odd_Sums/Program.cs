using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Even_Odd_Sums
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			StreamReader reader = new StreamReader("input.txt");
			StreamWriter writer = new StreamWriter("output.txt");
			writer.WriteLine("integer    |  Even Sums |  Odd Sums | Processing Time");
			writer.WriteLine("-------------------------------------------------");
			while (reader.EndOfStream == false)
			{
				int num = Convert.ToInt32(reader.ReadLine());
				Stopwatch st = new Stopwatch();
				int ed = 0;
				int od = 0;
				st.Start();
				for (int i = 1; i <= num; i++)
				{
					if (num % i == 0)
					{
						if (i % 2 == 0)
						{
							ed++;
						}
						else
						{
							od++;
						}
					}
				}
				st.Stop();
				writer.WriteLine(String.Format("{0,-10} | {1,-10} | {2,-5}     | {2,-5}ms", num, ed, od, st.ElapsedMilliseconds));
			}
			writer.Close();
			reader.Close();
		}
	}
}