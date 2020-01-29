using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //POLIMORFISMO

            //Instanciamos as classes
            Veiculo[] veiculo = new Veiculo[2];

            veiculo[0] = new Automovel("Pálio");
            veiculo[1] = new Aeronave("Jato");

            MovimentarVeiculo(veiculo[0]);
            MovimentarVeiculo(veiculo[1]);
            
            Console.ReadKey();

        }

        public static void MovimentarVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Tipo);
            veiculo.Mover();
        }
    }
}
