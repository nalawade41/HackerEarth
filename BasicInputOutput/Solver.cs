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

        public void SeatingArangement()
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int seat = int.Parse(Console.ReadLine());
                int facing = seat % 12 == 0 ? 12 : seat % 12;
                facing = seat - facing + 13 - facing;
                int t = seat % 6;
                char seat_type;
                if (t == 0 || t == 1)
                    seat_type = 'W';
                else if (t == 2 || t == 5)
                    seat_type = 'M';
                else
                    seat_type = 'A';
                Console.WriteLine(facing + " " + seat_type + "S\n");
            }
        }

        public void Anagrams()
        {
            int num = int.Parse(Console.ReadLine());
            for (int c = 0; c < num; c++)
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                int i, delNum = 0;
                var aCount = new Dictionary<char, int>();
                var bCount = new Dictionary<char, int>();
                for (i = 0; i < 26; i++)
                {
                    char ch = (char)('a' + i);
                    aCount.Add(ch, 0);
                    bCount.Add(ch, 0);
                }
                foreach (var ch in firstString)
                {
                    aCount[ch] += 1;
                }
                foreach (var ch in secondString)
                {
                    bCount[ch] += 1;
                }
                for (i = 0; i < 26; i++)
                {
                    char ch = (char)('a' + i);
                    delNum += Math.Abs(aCount[ch] - bCount[ch]);
                }
                System.Console.WriteLine(delNum);
            }
        }

        public void PalindromicString()
        {
            string firstString = Console.ReadLine();
            bool flag = true;
            for (int i = 0, j = firstString.Length - 1; i < firstString.Length; i++, j--)
            {
                if (firstString[i] != firstString[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            return;
        }

        public void FindProduct()
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = new int[num];
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long answer = 1;
            long module = 1000000007;
            foreach (int a in array)
            {
                answer = (answer * a) % module;
            }
            Console.WriteLine(answer);
        }

        public void CountDevisors()
        {
            int[] array = new int[3];
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            int devisor = array[2];
            for (int i = array[0]; i <= array[1]; i++)
            {
                if (i % devisor == 0)
                    count++;
            }
            Console.WriteLine(count);
        }

        public void Factorial()
        {
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 2; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }

        public void ToggleString()
        {
            string s = Console.ReadLine();
            string output = string.Empty;
            foreach (char c in s)
            {
                output += ((int)c > 64 && (int)c < 91) ? (char)(c + 32) : (char)(c - 32);
            }

            Console.WriteLine(output);
        }

        public void RoyAndProfilePicture()
        {
            int length = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] array = new int[2];
                array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                string output = (array[0] < length || array[1] < length) ? "UPLOAD ANOTHER" : ((array[0] == array[1]) ? "ACCEPTED" : "CROP IT");
                Console.WriteLine(output);
            }
        }

        public void TwoStrings()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int j = 0;
                int[] alphabets = new int[26];
                string[] array = new string[2];
                array = Console.ReadLine().Split(' ').ToArray();
                for (j = 0; j < array[0].Length; j++)
                {
                    alphabets[array[0][j] - 'a']++;
                    alphabets[array[1][j] - 'a']--;
                }
                for (j = 0; j < 26; j++)
                {
                    if (alphabets[j] != 0)
                        break;
                }
                if (j == 26)
                    Console.WriteLine("YES\n");
                else
                    Console.WriteLine("NO\n");
            }
        }

        public void BookOfPotionMaking()
        {
            long n = long.Parse(Console.ReadLine());
            if (n.ToString().Length == 10)
            {
                long sum = 0;
                int i = 10;
                while (n > 0)
                {
                    sum += (n % 10) * i;
                    n = n / 10;
                    i--;
                }
                if (sum % 11 == 0)
                    Console.WriteLine("Legal ISBN");
                else
                    Console.WriteLine("Illegal ISBN");
            }
            else
            {
                Console.WriteLine("Illegal ISBN");
            }
        }

        public void Hello()
        {
            Console.WriteLine("Hello Kirti");
        }

        public void LifeUniverse()
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
