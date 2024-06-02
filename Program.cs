using System;

class Program
{
    static void Main(string[] args)
    {
        Suite suiteLuxo = new("Luxo", 150.00m);
        Reserva reserva = new(suiteLuxo, 5);

        reserva.AdicionarHospede(new Pessoa("João da Silva", 30));
        reserva.AdicionarHospede(new Pessoa("Maria da Silva", 28));

        decimal valorTotal = reserva.CalcularValorTotal();
        Console.WriteLine($"Valor total da reserva: {valorTotal:C}");
    }
}
