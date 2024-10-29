using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        // Exemplo de inicialização do dicionário
        pessoas.Add("Alice", 25);
        pessoas.Add("Bob", 30);
        pessoas.Add("Carol", 20);
        pessoas.Add("David", 35);
        pessoas.Add("Eve", 22);

        
        Console.WriteLine("Dicionário original:");
        ImprimirDicionario(pessoas);

        
        double mediaIdades = pessoas.Values.Average();

       
        Console.WriteLine("\nPessoas com idade acima da média:");
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > mediaIdades)
            {
                Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
            }
        }

       
        var pessoaMaisVelha = pessoas.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        Console.WriteLine($"\nPessoa mais velha: {pessoaMaisVelha}");

        
        var pessoaMaisNova = pessoas.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
        Console.WriteLine($"Pessoa mais nova: {pessoaMaisNova}");

        
        Console.Write("\nDigite a idade Y para remover pessoas com essa idade: ");
        int valorY = int.Parse(Console.ReadLine());

        
        var pessoasParaRemover = pessoas.Where(p => p.Value == valorY).ToList();
        foreach (var pessoa in pessoasParaRemover)
        {
            pessoas.Remove(pessoa.Key);
        }

        
        Console.WriteLine("\nDicionário atualizado após remoção:");
        ImprimirDicionario(pessoas);
    }

    static void ImprimirDicionario(Dictionary<string, int> dicionario)
    {
        foreach (var pessoa in dicionario)
        {
            Console.WriteLine($"{pessoa.Key} - {pessoa.Value} anos");
        }
    }
}
