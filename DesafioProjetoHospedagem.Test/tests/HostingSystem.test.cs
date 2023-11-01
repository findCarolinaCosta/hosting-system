namespace HostingSystem.Test;

using System;
using System.Collections.Generic;
using DesafioProjetoHospedagem.Models;

public class hostingSystemTest
{
    [Fact(DisplayName = "Teste cadastro de hospedes")]
    public void TestQuantidadeHospedes()
    {
        List<Pessoa> hospedes = new List<Pessoa>
            {
                new Pessoa(nome: "Hóspede 1"),
                new Pessoa(nome: "Hóspede 2")
            };

        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        Reserva reserva = new Reserva(diasReservados: 5);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        Assert.Equal(2, reserva.ObterQuantidadeHospedes());
    }

    [Fact(DisplayName = "Teste fazer reserva")]
    public void TestValorDiaria()
    {
        List<Pessoa> hospedes = new List<Pessoa>
            {
                new Pessoa(nome: "Hóspede 1"),
                new Pessoa(nome: "Hóspede 2")
            };

        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        Reserva reserva = new Reserva(diasReservados: 5);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        Assert.Equal(150, reserva.CalcularValorDiaria());
    }
}