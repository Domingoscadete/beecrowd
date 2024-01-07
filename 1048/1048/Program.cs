using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n1 = Console.ReadLine().Split(' ');
            double n2,n3;
            n2 = double.Parse(n1[0]);
            if (n2 <= 400.00)
            {
                n3 = (n2 * 15) / 100;
                Console.WriteLine($"Novo salario: {(n2+n3).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(n3).ToString("F2")}");
                Console.WriteLine("Em percentual: 15 %");
            }
            else  if(n2>= 400.01 && n2<=800.00)
            {
                n3 = (n2 * 12) / 100;
                Console.WriteLine($"Novo salario: {(n2 + n3).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(n3).ToString("F2")}");
                Console.WriteLine("Em percentual: 12 %");
            }
            else if(n2 >= 800.01 && n2 <= 1200.00)
            {
                n3 = (n2 * 10) / 100;
                Console.WriteLine($"Novo salario: {(n2 + n3).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(n3).ToString("F2")}");
                Console.WriteLine("Em percentual: 10 %");
            }
            else if(n2 >= 1200.01 && n2 <= 2000.00)
            {
                n3 = (n2 * 7) / 100;
                Console.WriteLine($"Novo salario: {(n2 + n3).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(n3).ToString("F2")}");
                Console.WriteLine("Em percentual: 7 %");
            }
            else if(n2 > 2000.0)
            {
                n3 = (n2 * 4) / 100;
                Console.WriteLine($"Novo salario: {(n2 + n3).ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {(n3).ToString("F2")}");
                Console.WriteLine("Em percentual: 4 %");

            }
        }
    }
}
