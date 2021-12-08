using SinqiaEstude.Domain;
using System;
using System.Collections.Generic;

namespace SinqiaEstude.Repository
{
    public class AlunoRepository
    {
        private static List<Aluno> AlunoDB = new List<Aluno>();

        public static void Add(Aluno Aluno)
        {
            AlunoDB.Add(Aluno);
        }
        public static Aluno FindByDescricao(string descricao)
        {
            // materia é uma função "generia" e após o => vem a condição de filtro
            foreach (Aluno aluno in AlunoDB)
            {
                if (aluno.nome.Contains(descricao, StringComparison.OrdinalIgnoreCase))
                {
                    return aluno;
                }
            }
            return null;
        }
        public static List<Aluno> GetAll()
        {
            return AlunoDB;
        }
    }
}