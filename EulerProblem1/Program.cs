using System;

namespace EulerProblems
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                int x = i % 3;
                int y = i % 5;
                if (x != 0 && y != 0) continue;
                Console.Write("{0}\t", i);
                sum = sum + i;
            }
            Console.WriteLine("The Sum of all the multiples of 3 or 5 below 1000 is " + sum);
            Console.Read();
        }
    }
}
