using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaEstude.Domain
{
    public class Professor : PessoaBase
    {
        public Professor(string nome, int idade, string email, string cpf, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.CPF = cpf;
            this.endereco = endereco;
        }

        public Materia MateriaProfessor { get; set; }

        public override string ToString()
        {
            return "\nnome: " + nome + "\nidade: "+idade+ "\nemail: " + email +
                "\ncpf: " + CPF + "\nendereço: " + endereco+MateriaProfessor;
        }

    }
}
