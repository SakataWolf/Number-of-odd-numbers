using System;

namespace Quantidade_de_números_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantidade de números ímpares.\n");
            Console.Write("Digite um número: ");
            int a, b, i = 0, mn, Mn;
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            b = int.Parse(Console.ReadLine());
            if (a <= b)
            {
                mn = a;
                Mn = b;
            }
            else
            {
                mn = b;
                Mn = a;
            }
            for (int x = mn; x <= Mn; x++)
            {
                if (x % 2 != 0) { i++; }
            }
            Console.WriteLine("Quantidade de números ímpares entre {0} e {1} é {2}", mn, Mn, i);
        }
    }
}
