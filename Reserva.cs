using System;
using System.Collections.Generic;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(Suite suite, int diasReservados)
    {
        Suite = suite;
        DiasReservados = diasReservados;
        Hospedes = [];
    }

    public void AdicionarHospede( Pessoa pessoa)
    {
        Hospedes.Add(pessoa);
    }

    public decimal CalcularValorTotal()
    {
        decimal valorTotal = DiasReservados * Suite.ValorDiaria;
        if (DiasReservados > 10)
        {
            valorTotal *= 0.9m;
        }
        return valorTotal;
    }
}
