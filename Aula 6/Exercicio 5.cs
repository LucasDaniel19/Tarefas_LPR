using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de horas de treinamento por dia: ");
        int horasPorDia = int.Parse(Console.ReadLine());

        int totalHorasPorSemana = horasPorDia * 5; 
        double semanasNecessarias = 1000.0 / totalHorasPorSemana;
        double mesesNecessarios = semanasNecessarias / 4.5;
        
        int semanas = (int)Math.Ceiling(semanasNecessarias);
        int meses = (int)Math.Ceiling(mesesNecessarios);

        Console.WriteLine($"Seriam necessários {semanas} semanas para alcançar 1000 horas de treinamento.");
        Console.WriteLine($"Isso equivale a aproximadamente {meses} meses.");

        Console.ReadLine();
    }
}