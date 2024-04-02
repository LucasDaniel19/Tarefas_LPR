using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double media = 0;
            int contPar = 0;
            int cont = 0;
            
            Console.WriteLine("Digite os numeros que voce deseja");
            int quantidade = int.Parse(Console.ReadLine());

            while (cont < quantidade)
            {
                Console.Write("Digite um numero: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    soma += numero;
                   contPar++;
                }
                cont++;
            }
                media = soma / contPar;
                Console.WriteLine("A média dos numeros e " + media);

        }
    }
}
