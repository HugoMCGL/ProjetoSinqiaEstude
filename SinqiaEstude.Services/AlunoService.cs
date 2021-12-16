using System;
using System.Collections.Generic;
using SinqiaEstude.Domain;
using SinqiaEstude.Repository;

namespace SinqiaEstude.Services
{
    public class AlunoService
    {
        public bool statusAtribuicaoMateria;
        MateriaService materiaService = new MateriaService();
        public void CadastrarAluno(string nome, int idade, string email, string cpf, string endereco)
        {

            Aluno aluno = new Aluno(nome, idade, email, cpf, endereco);
            AlunoRepository.Add(aluno);
            Console.WriteLine("\naluno/a " + nome + " criado com sucesso!");

        }
        public void ExcluirAluno(string nome)
        {

            AlunoRepository.Delete(AlunoRepository.FindByDescricao(nome));
            if(AlunoRepository.FindByDescricao(nome)== null)
            {
                Console.WriteLine("Aluno Excluido com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro!");
            }

        }

        public void CadastrarMateriaAluno(string nomeAluno, string materia)
        {
            if (AlunoRepository.FindByDescricao(nomeAluno) == null)
            {
                Console.WriteLine("Aluno inválido");
            }
            else
            {
                foreach (Aluno aluno in AlunoRepository.GetAll())
                {
                    if (aluno.nome.Equals(nomeAluno))
                    {
                        Materia materiaDb = materiaService.FindByNome(materia);
                        if (materiaDb != null)
                        {
                            if (aluno.MateriaAluno == null)
                            {
                                aluno.MateriaAluno = new List<Materia>();
                            }
                            aluno.MateriaAluno.Add(materiaDb);
                            Console.WriteLine("Matéria atribuída com sucesso!");
                            statusAtribuicaoMateria = true;
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
            return " lista: " + AlunoRepository.GetAll();
        }
    }
}


