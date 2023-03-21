using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDB_B3_VICTOR_RAMOS_Domain.Models
{
    public class Investimento
    {
        public Investimento(double valorInicial, int prazoResgate)
        {
            this.ValorInicial = valorInicial;
            this.PrazoResgate = prazoResgate;
            Validar();
        }

        public double ValorInicial { get; set; }
        public int PrazoResgate { get; set; }
        public double ValorBruto { get; set; }
        public double ValorLiquido { get; set; }
        public virtual void Calcular() { }

        private void Validar()
        {
            if (ValorInicial <= 0)
                throw new ArgumentException("O valor inicial deve ser positivo.");

            if (PrazoResgate <= 1)
                throw new ArgumentException("O prazo para resgate (em meses) deve ser maior que 1.");
        }

    }
}