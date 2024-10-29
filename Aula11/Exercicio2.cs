using System;
using ConsoleApp4;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, salarioBruto);

            Console.WriteLine(funcionario.ToString());

            Console.Write("Digite a porcentagem de aumento do salário: ");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("após o aumento:");
            Console.WriteLine(funcionario.ToString());
        }
        catch (FormatException)
        {
            Console.WriteLine("insira valores para salário e porcentagem.");
        }
    }
}
