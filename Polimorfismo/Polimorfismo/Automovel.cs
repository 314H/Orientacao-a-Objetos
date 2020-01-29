using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Automovel : Veiculo
    {
        public Automovel(string tipoVeiculo) : base (tipoVeiculo)
        {

        }

        public override void Mover()
        {
            Console.WriteLine("Acelerando Veiculo");
        }

        public override void Parar()
        {
            Console.WriteLine("Freiando Veiculo");
        }
    }
}