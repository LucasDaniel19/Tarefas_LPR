using ConsoleApp5;
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite a matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a nota da primeira prova: ");
            double notaProva1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            double notaProva2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota do trabalho: ");
            double notaTrabalho = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(matricula, nome, notaProva1, notaProva2, notaTrabalho);

            Console.WriteLine("\nDados do Aluno:");
            Console.WriteLine(aluno.ToString());
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro:");
        }
    }
}
