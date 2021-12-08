using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinqiaEstude.Domain;
using SinqiaEstude.Repository;

namespace SinqiaEstude.Services
{
    public class MateriaService
    {
        
        public int tamanhoLista = 0;
        public void cadastrarMateria(string nome)
        {
          Materia materia = new Materia(nome);  
          MateriaRepository.Add(materia);
            Console.WriteLine("Materia "+ nome +" adicionada com sucesso!");
            tamanhoLista++;

        }

        public override string ToString()
        {
            return "Lista : " + MateriaRepository.GetAll();
        }

        public List<Materia> GetAll() {
            return MateriaRepository.GetAll();
        }

        public Materia FindByNome(string nome)
        {
            return MateriaRepository.FindByDescricao(nome);
        }
    }
}
