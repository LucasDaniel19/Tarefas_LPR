using ConsoleApp8;

class Program
{
    static void Main(string[] args)
    {
    
        Aluno aluno1 = new Aluno("Lucas");
        Aluno aluno2 = new Aluno("Bruno");

    
        Turma turma1 = new Turma("Matematica");
        Turma turma2 = new Turma("Portugues");

        aluno1.AdicionarMatricula(turma1);
        aluno1.AdicionarMatricula(turma2);
        aluno2.AdicionarMatricula(turma1);

        aluno1.AdicionarMatricula(turma1);

       
        Console.WriteLine($"Alunos na turma {turma1.Nome}:");
        foreach (var aluno in turma1.ObterAlunosMatriculados())
        {
            Console.WriteLine(aluno.Nome);
        }
    }
}

