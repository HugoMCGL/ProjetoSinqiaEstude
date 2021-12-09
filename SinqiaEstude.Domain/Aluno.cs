using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaEstude.Domain
{
    public class Aluno : PessoaBase
    {
        public Aluno(string nome, string email, string cpf, string endereco) {
            this.nome = nome;
            this.email = email;
            this.CPF = cpf;
            this.endereco = endereco;
        }
        //teste
        public List<Materia> MateriaAluno { get; set; }

        public override string ToString()
        {
            return "\nnome: " + nome + " \nemail: " + email+
                "\ncpf: " +CPF+ "\nendereço: " +endereco+ (MateriaAluno != null ? string.Join(",", MateriaAluno) : "\nMateria: Nenhuma cadastrada");
        }
    }
}