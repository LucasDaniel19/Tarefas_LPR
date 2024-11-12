using ConsoleApp7;

class Program
{
    static void Main(string[] args)
    {
        
        Biblioteca biblioteca = new Biblioteca();

        Livro livro1 = new Livro("Vidas Secas", "Graciliano Ramos", 1938);
        Livro livro2 = new Livro("Dom Casmurro", "Machado de Assis", 1899);
        Livro livro3 = new Livro("O Cortiço", "Aluísio Azevedo", 1890);


        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);
        biblioteca.AdicionarLivro(livro3);

        
        biblioteca.ListarLivros();
    }
}
