using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeCaixa
{
    public class Calculadora
    {
        public decimal Valor;
        public int Qtd;

        public decimal Total()
        {
            return Qtd * 1.99m;
        }
        public decimal Troco()
        {
            return Valor - Total();
        }

    }
}
