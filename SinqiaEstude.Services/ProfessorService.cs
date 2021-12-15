using System;
using System.Collections.Generic;
using SinqiaEstude.Domain;
using SinqiaEstude.Repository;

namespace SinqiaEstude.Services
{
    public class ProfessorService
    {
        public bool statusAtribuicaoMateria;
        MateriaService materiaService = new MateriaService();
        public void cadastrarProfessor(string nome, int idade, string email, string cpf, string endereco)
        {
            Professor professor = new Professor(nome, idade, email, cpf, endereco);
            ProfessorRepository.Add(professor);
            Console.WriteLine("Professor: " + nome + " criado com sucesso!");
        }
        public void cadastrarMateriaProfessor(string nomeProfessor, string materia)
        {
            if (ProfessorRepository.FindByDescricao(nomeProfessor) == null)
            {
                Console.WriteLine("Professor inválido");
            }
            else
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
                                Console.WriteLine("Matéria atribuída com sucesso!");
                                professor.MateriaProfessor = materiaDb;
                                statusAtribuicaoMateria = true;
                            }
                            else
                            {
                                Console.WriteLine("matéria já atribuida");
                            }
                            //professor.MateriaProfessor.Add(materiaDb);
                            
                            
                        }
                        else
                        {
                            Console.WriteLine("Matéria não encontrada");
                            statusAtribuicaoMateria = false;
                        }
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