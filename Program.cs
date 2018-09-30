using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n != 42)
            {
                n = int.Parse(Console.ReadLine());
                if (n != 42)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
