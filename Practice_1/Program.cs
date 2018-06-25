using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");

            string[] s = sr.ReadLine().Split();

            int N = int.Parse(s[0]);
            int A = int.Parse(s[1]);
            int B = int.Parse(s[2]);

            BigInteger r = c(N + 1, A) * c(N + 1, B);
            sw.WriteLine(r);

            sr.Close();
            sw.Close();
        }

        static BigInteger c(int n, int k)
        {
            return f(n + k - 1) / (f(k) * f(n - 1));
        }

        static BigInteger f(int n)
        {
            BigInteger r = 1;

            for (int i = 2; i <= n; i++)
                r *= i;

            return r;
        }
    }
}
