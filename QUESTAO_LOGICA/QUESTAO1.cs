using System;

namespace CalculadoraNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double quadradoMenor = Math.Pow(numero1, 2);
            double raizMaior = Math.Sqrt(numero2);

            Console.WriteLine($"O quadrado do menor número é: {quadradoMenor}");
            
            if (raizMaior >= 0)
                Console.WriteLine($"A raiz quadrada do maior número é: {raizMaior}");
            else
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
        }
    }
}