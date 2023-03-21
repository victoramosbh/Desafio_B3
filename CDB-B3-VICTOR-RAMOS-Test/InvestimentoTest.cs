using CDB_B3_VICTOR_RAMOS_Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CDB_B3_VICTOR_RAMOS_Test
{
    [TestClass]
    public class InvestimentoTest
    {
        [TestMethod]
        public void Cdb_DeveCalcularCorretoComPrazo6()
        {
            Investimento investimento = new Cdb(20000, 6);
            investimento.Calcular();

            Assert.AreEqual(21195.113540297963, investimento.ValorBruto);
        }

        [TestMethod]
        public void Cdb_DeveCalcularCorretoComPrazo12()
        {
            Investimento investimento = new Cdb(20000, 10);
            investimento.Calcular();

            Assert.AreEqual(22031.272482865064, investimento.ValorBruto);
        }

        [TestMethod]
        public void Cdb_DeveCalcularCorretoComPrazo24()
        {
            Investimento investimento = new Cdb(20000, 18);
            investimento.Calcular();

            Assert.AreEqual(23803.852517865344, investimento.ValorBruto);
        }

        [TestMethod]
        public void Cdb_DeveCalcularCorretoComPrazoMais24()
        {
            Investimento investimento = new Cdb(20000, 36);
            investimento.Calcular();

            Assert.AreEqual(28331.169734614206, investimento.ValorBruto);
        }

        [TestMethod]
        [DataRow(50000, 4)]
        [DataRow(1000.88, 11)]
        [DataRow(57896, 48)]
        [DataRow(1000000, 2)]
        public void Cdb_DeveCalcularBrutoMaiorLiquido(double valor,int prazo)
        {
            Investimento investimento = new Cdb(valor, prazo);
            investimento.Calcular();

            Assert.IsTrue(investimento.ValorBruto > investimento.ValorLiquido);
        }

        [DataTestMethod]
        [DataRow(-50000,10)]
        public void Cdb_DeveValidarValorNegativo(double valor,int prazo)
        {            
            var ex = Assert.ThrowsException<ArgumentException>(() => new Cdb(valor, prazo));            
            Assert.AreEqual("O valor inicial deve ser positivo.", ex.Message);

        }

        [DataTestMethod]
        [DataRow(20000, 1)]
        public void Cdb_DeveValidarPrazoResgate(double valor, int prazo)
        {
            var ex = Assert.ThrowsException<ArgumentException>(() => new Cdb(valor, prazo));
            Assert.AreEqual("O prazo para resgate (em meses) deve ser maior que 1.", ex.Message);

        }
    }
}
