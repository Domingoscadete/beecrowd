using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            switch (n1) {
                case 1:
                    Console.WriteLine($"Total: R$ {(n2 * 4.00).ToString("F2")}"); break;
                case 2:
                    Console.WriteLine($"Total: R$ {(n2 * 4.50).ToString("F2")}"); break;
                case 3:
                    Console.WriteLine($"Total: R$ {(n2 * 5.00).ToString("F2")}"); break;
                case 4:
                    Console.WriteLine($"Total: R$ {(n2 * 2.00).ToString("F2")}"); break;
                case 5:
                    Console.WriteLine($"Total: R$ {(n2 * 1.50).ToString("F2")}"); break;
            }
           
            
            
        }
    }
}
