using System;
using SinqiaEstude.Domain;
using SinqiaEstude.Repository;
using SinqiaEstude.Services;


namespace AppSinqiaEstude
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno;
            AlunoService teste;
            AlunoService alunoService = new AlunoService();
            ProfessorService professorService = new ProfessorService();
            MateriaService materiaService = new MateriaService();

            materiaService.cadastrarMateria("Geografia");
            materiaService.cadastrarMateria("Programacao");

            alunoService.cadastrarAluno("Hugo Lima", "hugo.lima@sinqia.com.br", "177.070.267.99", "Benfica");
            alunoService.cadastrarAluno("Jonathan Santos", "jonathan.santos@sinqia.com.br", "123.456.789-33", "Campo Grande");

            professorService.cadastrarProfessor("Bruno Chel", "bruno.chel@sinqia.com.br", "231.233.444.77", "Rio de Janeiro");
            professorService.cadastrarProfessor("Tauan Silva", "tauan.silva@sinqia.com.br", "214.933.444.77", "Rio de Janeiro");

            alunoService.cadastrarMateriaAluno("Hugo Lima", "Programacao");

            foreach (Materia materialist in materiaService.GetAll())
            {
                Console.WriteLine("\n" + materialist);
            }

            foreach (Aluno alunoSearch in AlunoRepository.GetAll())
            {
                Console.WriteLine("\nAluno: "+alunoSearch);
                
            }

            foreach (Professor professorList in professorService.listaProfessor)
            { 
                Console.WriteLine("\nProfessor: "+professorList);
            }


        }
    }
}
