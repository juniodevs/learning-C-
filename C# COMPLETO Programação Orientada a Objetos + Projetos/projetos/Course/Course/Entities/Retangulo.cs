using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;

        public void DefinirMedidias(double comprimento, double largura)
        {
            this.comprimento = comprimento;
            this.largura = largura;
        }

        public double ObterArea()
        {
            return comprimento * largura;
        }
    }
}
