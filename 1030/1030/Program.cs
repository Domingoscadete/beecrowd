using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1030
{
    internal class Program
    {
        static int sobrevivente(int k, int n)
        {
            if (n == 1) return 0;
            return (sobrevivente(n - 1, k) + k) % n;
        }
        static void Main(string[] args)
        {
            int NC, n, k;
            NC = int.Parse(Console.ReadLine());
            for (int n1 = 1; n1 <= NC; n1++)
            {


                n = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                Console.WriteLine($"Case {n1} : {sobrevivente(n, k) + 1}");
            }
        }
    }
}
