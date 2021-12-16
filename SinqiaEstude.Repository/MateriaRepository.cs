using SinqiaEstude.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaEstude.Repository
{
    public static class MateriaRepository
    {
        private static List<Materia> MateriaDB = new List<Materia>();
        public static void Add(Materia materia)
        {
            MateriaDB.Add(materia);
        }

        public static void Delete(Materia Materia)
        {
            MateriaDB.Remove(Materia);
        }

        public static Materia FindByDescricao(string descricao) 
        {
            //return MateriaDB.FirstOrDefault(materia => materia.nome.Contains(descricao));
            // materia é uma função "generia" e após o => vem a condição de filtro
            foreach (Materia materia in MateriaDB)
            {
                if (materia.nome.Contains(descricao, StringComparison.OrdinalIgnoreCase))
                {
                    return materia;
                }
            }
            return null;
        }

        public static List<Materia> GetAll() 
        {
            return MateriaDB;
        }
    }
}
