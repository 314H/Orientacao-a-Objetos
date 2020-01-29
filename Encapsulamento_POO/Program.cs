using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa P = new Pessoa(); //Instânciando a classe Pessoa com o nome do objeto P

            P.Idade = 21;
            P.escreverNomeCompleto("Marcio", "Godoy");
           
            Console.WriteLine(P.NomeSobrenome);
            Console.ReadKey();
        }
    }
}
