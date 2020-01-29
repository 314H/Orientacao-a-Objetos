using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class PessoaFisica : Pessoa //Herdando Tudo o que vem da classe Pessoa
    {
        //Atributos
        public int IdCPF;
        public string CPF;
        public string RG;
        public string Profissao;
    }
}
