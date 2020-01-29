using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento_POO
{
    public class Pessoa
    {
        //Classe Pessoa
        //Descrição: Trata-se de uma classe do tipo pessoa

        //Declaração de Atributos da Classe
        private string Nome;
        private string Sobrenome;
        public string NomeSobrenome;
        private int idade;
        //Fim da Declaração de Atributos da Classe

        //Declaração do GET e SET
        public int Idade
        {
            //get { return idade; }
            set { idade = value; } //Encapsulando o atributo Idade
        }
        //Fim da Declaração do GET e SET

        //Declaração dos Métodos da Classe
        public void escreverNomeCompleto(string Nome, string Sobrenome) //Métodos
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            NomeSobrenome = Nome + " " + Sobrenome;
            Console.WriteLine("O nome é:" + NomeSobrenome);
            Console.WriteLine(idade);
        }
        //Fim da Declaração dos Métodos da Classe
    }
}
