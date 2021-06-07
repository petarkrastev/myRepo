using System;
using System.Collections.Generic;

namespace Eratosten
{
    public class Eratosten
    {
        public int Number { get; set; }
        public bool IsPrime { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int N = 100;
            List<Eratosten> numbers = new List<Eratosten>();
            for (int i = 1; i < 1 + N; i++)
            {
                numbers.Add(new Eratosten { Number = i , IsPrime = true});
            }

            // We skip 1
            for (int i = 1; i < Math.Sqrt(N); i++)
            {
                if (!numbers[i].IsPrime)
                    continue;

                for (int j = i + 1; j < N; j++)
                {
                    if (numbers[j].Number % numbers[i].Number == 0)
                    {
                        numbers[j].IsPrime = false;
                        continue;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (numbers[i].IsPrime)
                    Console.WriteLine(numbers[i].Number.ToString());
            }
        }
    }
}
