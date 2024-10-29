using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string> {
            "sergio", "ana", "maria", "carlos", "eva", "joaquim", "jo",
            "mara", "laura", "lucas", "ari", "paulo"
        };

        
        var groupedByLength = nomes.OrderBy(n => n.Length).GroupBy(n => n.Length);

       
        foreach (var group in groupedByLength)
        {
            Console.WriteLine(string.Join(", ", group));
        }
    }
}
