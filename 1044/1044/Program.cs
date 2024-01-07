using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n1 = Console.ReadLine().Split(' ');
            int n3, n2;
            n2 = int.Parse(n1[0]);
            n3 = int.Parse(n1[1]);
            if (n2 > n3)
            {
                if (n2 % n3 == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                } 
                else if (n2 % n3 != 0)
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }
            else if(n3 > n2)
            {
                if (n3 % n2 == 0)
                {
                    Console.WriteLine("Sao Multiplos");
                }
                else if (n3 % n2 != 0)
                {
                    Console.WriteLine("Nao sao Multiplos");
                }
            }

        }
    }
}
