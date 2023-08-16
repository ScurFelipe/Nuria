using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano em que você nasceu: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine($"O ano {ano} é bissexto.");
            }
            else
            {
                Console.WriteLine($"O ano {ano} não é bissexto.");
            }
        }
    }
}