using System;
using System.Collections.Generic;
using SinqiaEstude.Domain;
using SinqiaEstude.Repository;

namespace SinqiaEstude.Services
{
    public class ProfessorService
    {
        MateriaService materiaService = new MateriaService();
        public void cadastrarProfessor(string nome, int idade, string email, string cpf, string endereco)
        {
            Professor professor = new Professor(nome, idade, email, cpf, endereco);
            ProfessorRepository.Add(professor);
            Console.WriteLine("Professor: " + nome + " criado com sucesso!");
        }
        public void cadastrarMateriaProfessor(string nomeProfessor, string materia)
        {
            foreach (Professor professor in ProfessorRepository.GetAll())
            {
                if (professor.nome.Equals(nomeProfessor))
                {
                    Materia materiaDb = materiaService.FindByNome(materia);
                    if (materiaDb != null)
                    {
                        if (professor.MateriaProfessor == null)
                        {
                            professor.MateriaProfessor = new List<Materia>();
                        }
                        professor.MateriaProfessor.Add(materiaDb);
                        Console.WriteLine("Deu bom");
                    }
                }
            }
        }
        public override string ToString()
        {
            return " lista: " + ProfessorRepository.GetAll();
        }
    }
}