using System;

namespace SinqiaEstude.Domain
{
    public class PessoaBase
    { 
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }
        public string CPF { get; protected set; }
        public string endereco { get; set; }
    }
}