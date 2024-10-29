using ConsoleApp3;
using System;

class  Progam

{
    static void Main()
    {
        try
        {
            Console.Write("Digite a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(altura, largura);

            Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro do retângulo: {retangulo.CalcularPerimetro()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("insira valores para altura e largura.");
        }
    }
}
