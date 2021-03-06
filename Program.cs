﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace HackerEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                long[] inputs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                if (inputs[1] % inputs[0] == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
    }
}
