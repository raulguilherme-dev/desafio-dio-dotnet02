// See https://aka.ms/new-console-template for more information

using Desafio02.Models;

Pessoa pessoa1 = new("João", "Silva");
Pessoa pessoa2 = new("Maria", "Santos");
Pessoa pessoa3 = new("José", "Oliveira");

Suite suite1 = new("Presidencial", 2, 1000);
Suite suite2 = new("Luxo", 4, 500);

Reserva reserva = new();

reserva.CadastrarHospedes ([pessoa1, pessoa2]);
reserva.CadastrarSuite(suite1);
reserva.DiasReservados = 14;
Console.WriteLine(reserva.CalcularValorDiaria());
Console.WriteLine(reserva.ObterQuantidadeHospedes());