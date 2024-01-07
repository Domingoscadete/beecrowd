using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n1 = Console.ReadLine().Split(' ');
            int n2, n3;
            n2 = int.Parse(n1[0]);
            n3 = int.Parse(n1[1]);
            if (n2 > n3)
            {
                Console.WriteLine($"O JOGO DUROU {(24-n2)+n3} HORA(S)");
            }
            else if(n3 > n2)
            {
                Console.WriteLine($"O JOGO DUROU {n3 - n2} HORA(S)");
            }
            else if (n3 == n2)
            {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
            }

        }
    }
}
