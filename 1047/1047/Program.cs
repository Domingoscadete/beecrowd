using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n1 = Console.ReadLine().Split(' ');
            int n2, n3, n4, n5,s1,s2,tempo,hr,min;
            n2 = int.Parse(n1[0]);
            n3 = int.Parse(n1[1]);
            n4 = int.Parse(n1[2]);
            n5 = int.Parse(n1[3]);
            if (n4 <= n2 && n5 <= n3)
            {
                n4 = n4 + 24;

            }
            else if (n5 <=n3)
            {
                n5 = n5 + 60;
                n4 = n4 - 1;
            }

            s1 = (n2 * 3600) + (n3 * 60);
            s2 = (n4 * 3600) + (n5 * 60);

            tempo = (s2 - s1);
            hr = tempo / 3600;
            min = (tempo - (hr * 3600)) / 60;

            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hr, min);
        }
    }
}
