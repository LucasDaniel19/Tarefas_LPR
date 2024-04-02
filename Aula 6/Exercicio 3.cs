using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        for (int numero = 50; numero <= 500; numero++)
        {
            if (numero % 2 != 0 && numero % 3 == 0)
            {
                soma += numero;
            }
        }

        Console.WriteLine("A soma dos números múltiplos e " + soma);
    }
}
