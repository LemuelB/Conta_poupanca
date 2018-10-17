using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_poupança
{
    class Poupança
    {
        private decimal saldoPoupanca;
        private static double taxaDeJurosAnual;

        private const int MESES = 12;

        
        public Poupança()
        {
            saldoPoupanca = 0.0M;
            taxaDeJurosAnual = 0.0;
        }

       
        public Poupança(decimal saldoPoupanca)
        {
            this.saldoPoupanca = saldoPoupanca;
            taxaDeJurosAnual = 0.0;
        }

        
        public decimal Saldo
        {
            get { return saldoPoupanca; }
            set { saldoPoupanca = value; }
        }

        
        public static double TaxaJuros
        {
            get { return taxaDeJurosAnual; }
            set { taxaDeJurosAnual = value; }
        }

        
        public decimal CalcularJurosMensal()
        {
            decimal jurosMensal = (saldoPoupanca * (decimal)taxaDeJurosAnual) / MESES;
            return jurosMensal + saldoPoupanca;
        }

        
        public static void AlterarTaxaDeJuros(double taxaDeJuros)
        {
            taxaDeJurosAnual = taxaDeJuros;
        }
    }
}
