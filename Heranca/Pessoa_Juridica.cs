using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Pessoa_Juridica : Pessoa   //Herdando tudo o que vem da classe Pessoa
    {
        //Atributos
        public int IdPJ;
        public string CNPJ;
        public string InscricaoEstadual;
        public string PrincipalAtividadeEconomica;
    }
}
