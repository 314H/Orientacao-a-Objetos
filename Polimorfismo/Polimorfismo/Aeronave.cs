using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Aeronave : Veiculo
    {
        public Aeronave(string tipoVeiculo) : base (tipoVeiculo)
        {

        }
        public override void Mover()
        {
            Console.WriteLine("Decolando Aeronave");
        }

        public override void Parar()
        {
            Console.WriteLine("Aterrisando Aeronave");
        }
    }
}