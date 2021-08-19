using INSS._2___DAL;
using INSS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalcularInss : ICalculadorInss
    {
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            //Define qual base de cálculo irá ser acatada
            IAnoContabil dadosContabeis = AnoContabilRepository.Obter(data, salario);

            decimal valorDesconto = dadosContabeis.Teto;

            if (dadosContabeis.Aliquota != 0)
            {
                //Efetua cálculo do desconto do INSS
                valorDesconto = (salario * dadosContabeis.Aliquota) / 100;

                //Case o desconto ultrapasse o teto, o mesmo será utilizado como desconto
                valorDesconto = valorDesconto > dadosContabeis.Teto ? dadosContabeis.Teto : valorDesconto;
            }
                
            return valorDesconto;
        }
    }
}
