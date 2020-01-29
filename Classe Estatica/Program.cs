using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Estatica
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASSE PROGRAM - CLASSE DO PROGRAMA C#

            //CLASSE NÃO ESTATICA
            //Criou-se o objeto CNE
            ClasseNaoEstatica CNE= new ClasseNaoEstatica();
            CNE.nomeNaoEstatico = "Marcio";
            CNE.sobrenomeNaoEstatico = "Godoy";

            //Criou-se o objeto CNE2
            ClasseNaoEstatica CNE2 = new ClasseNaoEstatica();
            CNE2.nomeNaoEstatico = "Joaquim";
            CNE2.sobrenomeNaoEstatico = "Alves";

            //CLASSE ESTATICA
            //Não necessita criar um objeto ou instanciar a classe
            ClasseEstatica.nomeEstatico = "Jucilei";
            ClasseEstatica.sobrenomeEstatico = "Rodrigues";


            Console.WriteLine(CNE.nomeNaoEstatico + ' ' + CNE.sobrenomeNaoEstatico);
            Console.WriteLine(CNE2.nomeNaoEstatico + ' ' + CNE2.sobrenomeNaoEstatico);

            CNE.imprimirClasseEstatica();
            Console.ReadKey();
        }
    }
}
