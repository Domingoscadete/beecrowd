using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n1 = Console.ReadLine().Split(' ');
            double n2, n3, n4;
            n2 = double.Parse(n1[0]);
            n3 = double.Parse(n1[1]);
            n4 = double.Parse(n1[2]);
            if(n2< n3 + n4 && n3 <n2+n4 && n4 < n2 + n3)
            {
                Console.WriteLine($"Perimetro = {(n2+n3+n4).ToString("F1")}");

            }
            else
            {
                Console.WriteLine($"Perimetro = {((n2 + n3 )/2*n4).ToString("F1")}");
            }
        }
    }
}
