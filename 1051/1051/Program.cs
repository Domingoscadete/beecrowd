using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n1 = Console.ReadLine().Split(' ');
            double n2;
            n2 = double.Parse(n1[0]);
            if (n2 <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if(n2>=2000.01 && n2 <= 3000.00)
            {
                n2 -= 2000.00f;
                n2 *= 0.08;
                Console.WriteLine($"R$ {n2.ToString("F2")}");



            }
            else if (n2 >= 3000.01 && n2 <= 4500.00)
            {
                x -= 3000.00f;
                x *= 0.18;
                x += (1000 * 0.08);
                Console.WriteLine($"R$ {n2.ToString("F2")}");



            }
            else if (n2 > 4500.00)
            {
                x -= 4500.00f;
                x *= 0.28;
                x += (1500 * 0.18) + (1000 * 0.08);
                Console.WriteLine($"R$ {n2.ToString("F2")}");



            }


        }
    }
}
