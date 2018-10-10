using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.BasicsOfOperator
{
    class Solver
    {
        public void BirthDayParty()
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
