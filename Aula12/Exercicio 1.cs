class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente("João");

        cliente1.AdicionarReserva(DateTime.Now.AddDays(5)); 
        cliente1.AdicionarReserva(DateTime.Now.AddDays(-3)); 

        cliente1.ListarReservasFuturas(); 
    }
}
