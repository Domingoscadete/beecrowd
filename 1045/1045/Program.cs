using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1045
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n1 = Console.ReadLine().Split(' ');
            int n2, n3, n4,n5,n6,n7;
            n2 = int.Parse(n1[0]);
            n3 = int.Parse(n1[1]);
            n4 = int.Parse(n1[2]);
            n5 = n2 * n2;
            n6 = n3 * n3;
            n7 = n4 * n4;
            if (n2 >= n3 + n4)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (n5 == n6 + n7)
            
            {
                Console.WriteLine("TRIANGULO RETANGULO");
                if(n2==n3 || n3==n4 || n2 == n4)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");

                }
                else if(n2==n3 && n2==n4 && n4 == n3)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
            }

            else if (n5 > n6 + n7)

            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (n2 == n3 || n3 == n4 || n2 == n4)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");

                }
                else if (n2 == n3 && n2 == n4 && n4 == n3)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
            }

            else if (n5 < n6 + n7)

            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
                if (n2 == n3 || n3 == n4 || n2 == n4)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");

                }
                else if (n2 == n3 && n2 == n4 && n4 == n3)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
            }
        }
    }
}
