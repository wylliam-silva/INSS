using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Model
{
    public class AnoContabil2012: IAnoContabil
    {
        #region Propriedades
        public decimal Teto { get; }

        public decimal Aliquota { get; }

        private struct PrimeiraFaixa
        {
            public readonly static decimal Minimo = 0.00M;
            public readonly static decimal Maximo = 1000.00M;
            public readonly static decimal Aliquota = 7.00M;
        }

        private struct SegundaFaixa
        {
            public readonly static decimal Minimo = 1000.01M;
            public readonly static decimal Maximo = 1500.00M;
            public readonly static decimal Aliquota = 8.00M;
        }

        private struct TerceiraFaixa
        {
            public readonly static decimal Minimo = 1500.01M;
            public readonly static decimal Maximo = 3000.00M;
            public readonly static decimal Aliquota = 9.00M;
        }

        private struct QuartaFaixa
        {
            public readonly static decimal Minimo = 3001.01M;
            public readonly static decimal Maximo = 4000.00M;
            public readonly static decimal Aliquota = 11.00M;
        }
        #endregion

        #region Construtores
        public AnoContabil2012(decimal salario)
        {
            this.Teto = 500.00M;

            if (salario >= PrimeiraFaixa.Minimo && salario <= PrimeiraFaixa.Maximo)
                this.Aliquota = PrimeiraFaixa.Aliquota;

            else if (salario >= SegundaFaixa.Minimo && salario <= SegundaFaixa.Maximo)
                this.Aliquota = SegundaFaixa.Aliquota;

            else if (salario >= TerceiraFaixa.Minimo && salario <= TerceiraFaixa.Maximo)
                this.Aliquota = TerceiraFaixa.Aliquota;

            else if (salario >= QuartaFaixa.Minimo && salario <= QuartaFaixa.Maximo)
                this.Aliquota = QuartaFaixa.Aliquota;
        }
        #endregion
    }
}
