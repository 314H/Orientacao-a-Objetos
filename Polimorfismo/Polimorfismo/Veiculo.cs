using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Veiculo
    {
        private string tipo;
        
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Veiculo()
        {

        }

        public Veiculo(string tipoVeiculo)
        {
            this.tipo = tipoVeiculo;
        }

        public virtual void Mover()
        {
           
        }

        public virtual void Parar()
        {
           
        }
    }
}