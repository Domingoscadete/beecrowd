using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n1 = Console.ReadLine().Split(' ');
            int n2;
            n2 = int.Parse(n1[0]);
            if (n2 == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if (n2 == 71)
            {
                Console.WriteLine("Salvador");
            }
            else if (n2 == 11)
            {
                Console.WriteLine("Sao Paulo");
            }
            else if (n2 == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (n2 == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (n2 == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (n2 == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (n2 == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else Console.WriteLine("DDD nao cadastrado");
        }
    }
}
