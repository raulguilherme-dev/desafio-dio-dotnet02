using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio02.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite) {
            if (suite.Capacidade < Hospedes.Count)
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suite.");
            }
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria() {
            if (DiasReservados > 10) {
                return Suite.ValorDiaria * DiasReservados * 0.9m;
            }
            return Suite.ValorDiaria * DiasReservados;
        }
    }
}