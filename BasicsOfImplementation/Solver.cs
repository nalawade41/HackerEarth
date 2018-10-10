using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth.BasicsOfImplementation
{
    class Solver
    {
        public void ArrayInserts()
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array = new int[num[0]];
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long[] preSum = new long[num[0] + 1];
            for (int i = 0; i < num[1]; i++)
            {
                int[] queryArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (queryArray[0] == 2)
                {
                    int sum = 0;
                    for (int j = queryArray[1]; j <= queryArray[2]; j++)
                    {
                        sum += array[j];
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    array[queryArray[1]] = queryArray[2];
                }
            }
        }

        public void TheGreatKian()
        {
            long num = long.Parse(Console.ReadLine());
            long[] array = new long[num];
            array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] arraySum = new long[3];
            for (int i = 0; i < array.Length; i++)
            {
                decimal j = i + 1;
                if (j % 3 == 1)
                {
                    arraySum[0] += array[i];
                }
                else if (j % 3 == 2)
                {
                    arraySum[1] += array[i];
                }
                else if (j % 3 == 0)
                {
                    arraySum[2] += array[i];
                }
            }
            foreach (long a in arraySum)
            {
                Console.Write(a + " ");
            }
        }

        public void PrintHackerEarth()
        {
            long num = long.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] array = new int[7];
            foreach (char c in input)
            {
                if (c == 'h')
                    array[0]++;
                else if (c == 'a')
                    array[1]++;
                else if (c == 'c')
                    array[2]++;
                else if (c == 'k')
                    array[3]++;
                else if (c == 'e')
                    array[4]++;
                else if (c == 'r')
                    array[5]++;
                else if (c == 't')
                    array[6]++;
            }
            array[0] = array[0] / 2;
            array[1] = array[1] / 2;
            array[4] = array[4] / 2;
            array[5] = array[5] / 2;
            Console.WriteLine(array.Min());
        }

        public void LittleJhoolPsychichPower()
        {
            string input = Console.ReadLine();
            bool isGood = true;
            int zeroCounter = 0;
            int oneCounter = 0;
            foreach (char c in input)
            {
                if (oneCounter >= 6 || zeroCounter >= 6)
                {
                    isGood = false;
                    break;
                }
                if (c == '0')
                {
                    zeroCounter++;
                    oneCounter = 0;
                }
                else if (c == '1')
                {
                    oneCounter++;
                    zeroCounter = 0;
                }
            }

            if (isGood)
                Console.WriteLine("Good luck!");
            else
                Console.WriteLine("Sorry, sorry!");
        }

        public void MinMax()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = array.Max();
            int min = array.Min();
            bool isPresent = true;
            for (int i = min + 1; i < max; i++)
            {
                isPresent = array.Contains(i);
                if (!isPresent)
                    break;
            }

            if (isPresent)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        public void BestBrowser()
        {
            var line1 = System.Console.ReadLine().Trim();
            var N = Int32.Parse(line1);
            List<string> oweles = new List<string>();
            oweles.Add("a");
            oweles.Add("e");
            oweles.Add("i");
            oweles.Add("o");
            oweles.Add("u");
            List<string> anserToDiplay = new List<string>();
            for (var i = 0; i < N; i++)
            {

                var siteName = System.Console.ReadLine().Trim();
                var orignalLength = siteName.Length;
                siteName = siteName.ToLower().Replace("www.", "");
                siteName = new string(siteName.Where(x => !oweles.Contains(x.ToString())).ToArray());
                var bestBrowserlentgh = siteName.Length + 1;
                anserToDiplay.Add(bestBrowserlentgh + "/" + orignalLength);
            }

            foreach (string value in anserToDiplay)
                System.Console.WriteLine(value);
        }

        public void ArraySum()
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');
            BigInteger sum = new BigInteger();
            foreach (string a in array)
            {
                sum += BigInteger.Parse(a);
            }
            Console.WriteLine(sum);
        }

        public void HawkeyeAndFloodFill()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] valueArray = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int valueForPostions = Math.Max(Math.Abs(array[0] - i), Math.Abs(array[1] - j));
                    if (valueForPostions >= array[2])
                        valueArray[i, j] = 0;
                    else
                        valueArray[i, j] = array[2] - valueForPostions;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(valueArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void FindThePattern()
        {
            string input = Console.ReadLine();
            // This was needed because last test case input is wrong
            if (input.Split(' ').Length > 1)
            {
                long[] array = input.Split(' ').Select(long.Parse).ToArray();
                long sum = array.Min() + array.Max();
                Console.WriteLine(sum);
            }
            else
            {
                int n = int.Parse(input);
                long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                long sum = array.Min() + array.Max();
                Console.WriteLine(sum);
            }
        }

        public void Queu2()
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isPresent = true;
            for (int i = 0; i < array.Length; i++)
            {
                isPresent = array[i] >= n[1] && array[i] <= n[2];
                if (!isPresent)
                    break;
            }

            if (isPresent)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        public void PlusPlus()
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] array = new int[n[0], n[1]];
            for (int i = 0; i < n[0]; i++)
            {
                int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n[1]; j++)
                {
                    array[i, j] = data[j];
                }
            }
            int ans = 0;
            for (int i = 1; i < n[0] - 1; i++)
            {
                for (int j = 1; j < n[1] - 1; j++)
                {
                    for (int k = 1; k < n[0] - 1; k++)
                    {
                        for (int l = 1; l < n[1] - 1; l++)
                        {
                            if (Math.Abs(i - k) + Math.Abs(j - l) > 2)
                            {
                                ans = Math.Max(ans, (array[i, j] * array[k, l]) + (array[i, j - 1] * array[k, l - 1]) + (array[i - 1, j] * array[k - 1, l]) + (array[i + 1, j] * array[k + 1, l]) + (array[i, j + 1] * array[k, l + 1]));
                            }
                        }
                    }
                }
            }

            Console.WriteLine(ans);
        }

        public void HackersWithBits()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ans = count(n, array);
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ans = Math.Max(ans, count(n, array));
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            Console.WriteLine(ans);
        }

        private int count(int n, int[] array)
        {
            int ones = 0;
            int ret = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 1)
                    ++ones;
                else ones = 0;
                ret = Math.Max(ret, ones);
            }
            return ret;
        }
    }
}
