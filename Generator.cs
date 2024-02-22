using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeling_Task_4
{
    class Generator
    {
        public int Longest_Period_length = -1;
        public List<int> RandomNumbers = new List<int>();
        public int ActualPeriodLength = 0;
        public List<int> LCG(int a, int X, int c, int m, int itr)
        {
            int r = ((a * X) + c) % m;
            RandomNumbers.Add(r);
            int prev = r;
            for (int i = 1; i < itr; i++)
            {
                r = ((a * prev) + c) % m;
                RandomNumbers.Add(r);
                prev = r;
            }
            List<int> L = new List<int>();
            
            for (int j = 0; j < RandomNumbers.Count; j++)
            {
                if (L.Contains(RandomNumbers[j]))
                    break;
                else
                {
                    L.Add(RandomNumbers[j]);
                    ActualPeriodLength++;
                }
            }
            return RandomNumbers;
        }

        public int LongestPeriod(int X,int c, int m, int a)
        {
            
            int k = m - 1;

            if ((m > 0 && (m & (m - 1)) == 0) && c != 0)
            {
                 
                int x = 4 * k + 1;
                
                //Longest_Period_length = -1;
                if (AreRelativelyPrime(c, m) && (a == x))
                {
                    Longest_Period_length = m;
                }
            }
            else if ((m > 0 && (m & (m - 1)) == 0) && c == 0)
            {
                 
                //Longest_Period_length = -1;
                if ((X % 2 != 0) && ((a == 5 + 8 * k) || (a == 3 + 8 * k)))
                {
                    Longest_Period_length = m / 4;
                }
            }
            else if ((isPrime(m)) && c == 0)
            {
                
                //Longest_Period_length = -1;
                if (IsDivisible(a, k, m))
                {
                    Longest_Period_length = m - 1;
                }
            }
             else
                Longest_Period_length = -1;
           
            return Longest_Period_length;
        }

        // Function to check if two numbers are relatively prime
        static bool AreRelativelyPrime(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            
            return a == 1;
        }

        
        private bool isPrime(int n)
        {
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsDivisible(int a, int k, int m)
        {
            // Using modular exponentiation to calculate (a^k) % m efficiently
            long result = 1;
            for (int i = 0; i < k; i++)
            {
                result = (result * a) % m;
            }

            // Check if (a^k - 1) is divisible by m
            return (result - 1) % m == 0;
        }

    }
}
