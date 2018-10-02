using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        }
    }
}
