using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS.Model
{
    public class AnoContabil: IAnoContabil
    {
        #region Propriedades
        public decimal Teto { get; set; }
        public decimal Aliquota { get; set; }
        #endregion

    }
}
