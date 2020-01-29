using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Estatica
{
    public class ClasseNaoEstatica
    {
        public string nomeNaoEstatico;
        public string sobrenomeNaoEstatico;

        //Método para imprimir a classe estática
        public void imprimirClasseEstatica()
        {
            Console.WriteLine(ClasseEstatica.nomeEstatico + " " + ClasseEstatica.sobrenomeEstatico);
        }
    }
}
