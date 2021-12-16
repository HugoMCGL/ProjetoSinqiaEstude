using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinqiaEstude.Domain;

namespace SinqiaEstude.Repository
{
    public class ProfessorRepository
    {
        public static List<Professor> ProfessorDB = new List<Professor>();

        public static void Add(Professor Professor)
        {
            ProfessorDB.Add(Professor);
        }

        public static void Delete(Professor Professor)
        {
            ProfessorDB.Remove(Professor);
        }

        public static Professor FindByDescricao(string descricao)
        {
            foreach (Professor professor in ProfessorDB)
            {
                if (professor.nome.Contains(descricao, StringComparison.OrdinalIgnoreCase))
                {
                    return professor;
                }
            }
            return null;
        }

        public static List<Professor> GetAll()
        {
            return ProfessorDB;
        }
    }
}
