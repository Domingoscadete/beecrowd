using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1042
{
    internal class Program
    {
         static void ordena(int[] vetor, int tamanho  )
        {
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = i; j < tamanho; j++)
                {
                    if(vetor[i] > vetor[j])
                    {
                        int temp = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] n1 = new int[3];
            int[] n2 = new int[3];
           
            for(int i = 0; i < 3; i++)
            {
                n1[i] = int.Parse(Console.ReadLine());
                n2[i] = n1[i];
                
            }
           
           ordena(n1, 3);
            for(int i=0; i < 3; i++)
            {
                Console.WriteLine(n1[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(n2[i]);
            }
        }
    }
}
