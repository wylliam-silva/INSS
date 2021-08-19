using INSS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class AnoContabil2011: IAnoContabil
    {
        #region Propriedades
        public decimal Teto { get; }

        public decimal Aliquota { get; }

        private struct PrimeiraFaixa
        {
            public readonly static decimal Minimo = 0.00M;
            public readonly static decimal Maximo = 1106.90M;
            public readonly static decimal Aliquota = 8.00M;
        }

        private struct SegundaFaixa
        {
            public readonly static decimal Minimo = 1106.91M;
            public readonly static decimal Maximo = 1844.83M;
            public readonly static decimal Aliquota = 9.00M;
        }

        private struct TerceiraFaixa
        {
            public readonly static decimal Minimo = 1844.84M;
            public readonly static decimal Maximo = 3689.66M;
            public readonly static decimal Aliquota = 11.00M;
        }
        #endregion

        #region Construtores
        public AnoContabil2011(decimal salario)
        {
            this.Teto = 405.86M;

            if (salario >= PrimeiraFaixa.Minimo && salario <= PrimeiraFaixa.Maximo)
                    this.Aliquota = PrimeiraFaixa.Aliquota;

            else if (salario >= SegundaFaixa.Minimo && salario <= SegundaFaixa.Maximo)
                this.Aliquota = SegundaFaixa.Aliquota;

            else if (salario >= TerceiraFaixa.Minimo && salario <= TerceiraFaixa.Maximo)
                this.Aliquota = TerceiraFaixa.Aliquota;
        }
        #endregion
    }
}
