using INSS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS._2___DAL
{
    public static class AnoContabilRepository
    {
        public static AnoContabil Obter(DateTime data, decimal salario)
        {
            AnoContabil anoContabil = new AnoContabil();

            switch (data.Year)
            {
                case 2011:
                    var anocontabil2011 = new AnoContabil2011(salario);

                    anoContabil.Aliquota = anocontabil2011.Aliquota;
                    anoContabil.Teto = anocontabil2011.Teto;
                    break;
                case 2012:
                    var anocontabil2012 = new AnoContabil2012(salario);
                    
                    anoContabil.Aliquota = anocontabil2012.Aliquota;
                    anoContabil.Teto = anocontabil2012.Teto;
                    break;
            }

            return anoContabil;
        }
    }
}
