using System;

struct Produto
{
    public string Nome;
    public int Codigo;
    public decimal Preco;
    public int Quantidade;
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Nome do produto: ");
            produtos[i].Nome = Console.ReadLine();

            Console.Write("Código do produto: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine());

            Console.Write("Preço do produto: ");
            produtos[i].Preco = decimal.Parse(Console.ReadLine());

            Console.Write("Quantidade do produto: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        decimal valorTotalEstoque = 0;
        for (int i = 0; i < 3; i++)
        {
            valorTotalEstoque += produtos[i].Preco * produtos[i].Quantidade;
        }

        Console.WriteLine($"Valor total em estoque: {valorTotalEstoque}");
    }
}
