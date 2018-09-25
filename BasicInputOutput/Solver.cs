using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.BasicInputOutput
{
    public class Solver
    {
        public void Ladderophilia()
        {
            string twoStarPattern = "*   *";
            string stepPattern = "*****";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(twoStarPattern);
                Console.WriteLine(twoStarPattern);
                // dont print last step
                if (i < n)
                    Console.WriteLine(stepPattern);
            }
        }

        public void PrintPrimeNumbers()
        {
            int n = int.Parse(Console.ReadLine());
            // base condition
            if (n == 1)
                return;
            Console.Write("2");
            for (int i = 3; i < n; i++)
            {
                if (!isPrimeOrNot(i))
                    Console.Write(" " + i);
            }
        }

        #region Helper functions
        private bool isPrimeOrNot(int n)
        {
            bool isPrime = false;
            for (int i = 2; i < n; i++)
            {
                isPrime = (n % i == 0);

                if (isPrime)
                    return isPrime;
            }
            return isPrime;
        }

        #endregion
    }
}
