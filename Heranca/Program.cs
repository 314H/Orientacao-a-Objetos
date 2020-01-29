using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instânciando as Classes
            //Pessoa P = new Pessoa(); 
            //Não é necessário instânciar a classe Pessoa pois, a mesma está sendo herdada por outras classes
            PessoaFisica PF = new PessoaFisica();
            Pessoa_Juridica PJ = new Pessoa_Juridica();
            Aluno A = new Aluno();
            Professor Prof = new Professor();

            PF.CPF = "";
            PJ.CNPJ = "";

            //Depois da Herança
            PF.Endereco = "";     //Herdou o atributo da Classe Pessoa
            PJ.Endereco = "";    //Herdou o atributo da Classe Pessoa
            A.ID = 0;           //Herdou o atributo da Classe Pessoa 
            Prof.ID = 0;       //Herdou o atributo da Classe Pessoa

            A.IdAluno = 1;
            Prof.IdProfessor = 1;

           
        }
    }
}
