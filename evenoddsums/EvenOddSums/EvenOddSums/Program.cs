using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace EvenOddSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            int num = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            int ed = 0;
            int od = 0;
            st.Start();
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    d++;
                    if (d % 2 == 0)
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
            Console.WriteLine(" evendivisors = {0} odddivisors = {1} time elapsed = {2}", ed, od, st.ElapsedMilliseconds);
        }
    }
}
