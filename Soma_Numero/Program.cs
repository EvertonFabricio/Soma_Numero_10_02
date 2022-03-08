using System;

namespace Soma_Numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 3)
            {

                Console.WriteLine("Digite um numero inteiro: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite mais um inteiro: ");
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nOs Números digitados foram {n1} e {n2}.\nA noma desses números é {n1 + n2}.");

                if (n1 + n2 == 0)
                    Console.WriteLine("\nEsse é um número neutro\n\n *=*=*=*=*=*=*=*=*=\n");
                else if ((n1 + n2) % 2 == 0)
                    Console.WriteLine("\nEsse é um numero par\n\n *=*=*=*=*=*=*=*=*=\n");
                else
                    Console.WriteLine("\nEsse é um numero impar\n\n *=*=*=*=*=*=*=*=*=\n");

                i++;
            }
        }
    }
}
