using System;

namespace exercicio_Ze
{
    class Program
    {
        static void Main(string[] args)
        {
            int a , b;

            Console.WriteLine("Digite um numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero ");
            b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0){
                Console.WriteLine(" Seus numeros sao multiplos");
            }
            else {
                Console.WriteLine("Seus numeros nao sao multiplos");
            }
        }
    }
}
