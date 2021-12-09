using System;
using System.Collections.Generic;
using SinqiaEstude.Domain;
using SinqiaEstude.Repository;

namespace SinqiaEstude.Services
{
    public class AlunoService
    {
        MateriaService materiaService = new MateriaService();
        public void cadastrarAluno(string nome, string email, string cpf, string endereco)
        {

            Aluno aluno = new Aluno(nome, email, cpf, endereco);
            AlunoRepository.Add(aluno);
            Console.WriteLine("aluno : " + nome + " criado com sucesso!");
            
        }

        public void cadastrarMateriaAluno(string nomeAluno, string materia)
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
                        Console.WriteLine("Deu bom");
                    }
                }
                //Console.WriteLine("\nAluno: " + alunolist);
            }
        }


        public override string ToString()
        {
            return " lista: " + AlunoRepository.GetAll();
        }
    }
}


