using System;
using System.Threading;
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
            
            int menu;
            int idade;
            int escolha;
            string nome, endereco, email, cpf, nomeMateria;
            bool continua = true;
            bool continuaMenu = true;
            
            materiaService.cadastrarMateria("Geografia");
            materiaService.cadastrarMateria("Programacao");

            while (continuaMenu == true)
            {
                Thread.Sleep(500);
                Console.WriteLine("\n--Bem vindo ao Sistema Sinqia Estude--\n  Digite 1 para Gestão de aluno \n  Digite 2 para Gestão de professores \n  Digite 3 para Gestão de matérias \n  Digite 4 para Gestão financeira\n  Digite 0 para sair");
                menu = Convert.ToInt32(Console.ReadLine());
                continua = true;
                switch (menu)
                {
                    case 1:

                        while (continua == true)
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("\n Digite 1 para cadastrar Aluno \n Digite 2 para Excluir aluno \n Digite 3 para atribuir matéria para o Aluno\n Digite 4 para listar todos os alunos cadastrados\n Digite 0 para voltar");
                            escolha = Convert.ToInt32(Console.ReadLine());
                            if (escolha == 1)//cadastrar aluno
                            {
                                Console.WriteLine("\nDigite o nome do Aluno: ");
                                nome = Console.ReadLine();
                                Console.WriteLine("Digite a idade do Aluno: ");
                                idade = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Digite o cpf do Aluno: ");
                                cpf = Console.ReadLine();
                                Console.WriteLine("Digite o email do Aluno: ");
                                email = Console.ReadLine();
                                Console.WriteLine("Digite o endereço do Aluno: ");
                                endereco = Console.ReadLine();
                                alunoService.CadastrarAluno(nome, idade, email, cpf, endereco);
                                continua = false;
                            }
                            else if (escolha == 2)//excluir aluno
                            {
                                Console.WriteLine("Digite o nome do Aluno a ser excluído: ");
                                nome = Console.ReadLine();
                                alunoService.ExcluirAluno(nome);
                                continua = false;
                            }
                           
                            else if (escolha == 3)//atribuir matéria para o aluno
                            {
                                Console.WriteLine("\nDigite o nome do Aluno: ");
                                nome = Console.ReadLine();
                                Console.WriteLine("Digite o nome da matéria: ");
                                nomeMateria = Console.ReadLine();

                                alunoService.CadastrarMateriaAluno(nome, nomeMateria);
                                if (alunoService.statusAtribuicaoMateria)
                                {
                                    continua = false;
                                } 
                            }
                            else if (escolha == 4)//listar alunos
                            {
                                foreach (Aluno alunoSearch in AlunoRepository.GetAll())
                                {
                                    Console.WriteLine("\nAluno(a): " + alunoSearch);
                                }
                            }
                            else if (escolha == 0)
                            {
                                continua = false;
                            }
                            else
                            {
                                Thread.Sleep(500);
                                Console.WriteLine("Escolha inválida! ");
                            }

                        }
                        break;

                    case 2:

                        while (continua == true)
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("\n Digite 1 para cadastrar Professor\n Digite 2 para Excluir professor\n Digite 3 para atribuir matéria para o Professor\n Digite 0 para voltar");
                            escolha = Convert.ToInt32(Console.ReadLine());
                            if (escolha == 1)//cadastrar professor
                            {
                                Console.WriteLine("\nDigite o nome do Professor: ");
                                nome = Console.ReadLine();

                                Console.WriteLine("Digite a idade do Professor: ");
                                idade = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Digite o cpf do Professor: ");
                                cpf = Console.ReadLine();
                                Console.WriteLine("Digite o email do Professor: ");
                                email = Console.ReadLine();
                                Console.WriteLine("Digite o endereço do Professor: ");
                                endereco = Console.ReadLine();
                                professorService.cadastrarProfessor(nome, idade, email, cpf, endereco);
                                continua = false;
                            }

                            else if (escolha == 2)//excluir professor
                            {

                            }
      
                            else if (escolha == 3)//atribuir matéria para o professor
                            {
                                Console.WriteLine("Digite o nome do Professor: ");
                                nome = Console.ReadLine();
                                Console.WriteLine("Digite o nome da matéria: ");
                                nomeMateria = Console.ReadLine();

                                professorService.cadastrarMateriaProfessor(nome, nomeMateria);
                                if (professorService.statusAtribuicaoMateria)
                                {
                                    continua = false;
                                }
                            }
                            else if (escolha == 4)//listar professor
                            {
                                foreach (Professor professorSearch in ProfessorRepository.GetAll())
                                {
                                    Console.WriteLine("\nProfessor: " + professorSearch);
                                }
                            }
                            else if (escolha == 0)
                            {
                                continua = false;
                            }
                            else
                            {
                                Thread.Sleep(500);
                                Console.WriteLine("Escolha inválida! ");
                            }

                        }
                        break;

                    case 3:

                        Thread.Sleep(500);
                        Console.WriteLine("\n Digite 1 para cadastrar Materia \n Digite 2 para Excluir Materia\n Digite 0 para voltar");
                        escolha = Convert.ToInt32(Console.ReadLine());
                        if (escolha == 1)//cadastrar matéria
                        {
                            Console.WriteLine("Digite o nome da Matéria: ");
                            nomeMateria = Console.ReadLine();
                            materiaService.cadastrarMateria(nomeMateria);
                            continua = false;
                        }
                        else if (escolha == 2)
                        {

                        }
                        else if (escolha == 3)//listar materia
                        {
                            foreach (Materia materialist in materiaService.GetAll())
                            {
                                Console.WriteLine("\n" + materialist);
                            }
                        }
                        else if(escolha == 0)
                        {
                            continua = false;
                        }
                        else
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("Escolha inválida! ");
                        }

                        break;

                    case 4:
                        Console.WriteLine(" --WORK IN PROGRESS--\n Digite 0 para voltar");
                        escolha = Convert.ToInt32(Console.ReadLine());
                        if (escolha == 0)
                        {
                            continua = false;
                        }
                        break;

                    case 0:

                        continuaMenu = false;
                        break;

                    default:

                        Console.WriteLine("Escolha inválida");
                        break;
                }
            }

//            alunoService.cadastrarAluno("Hugo Lima", "hugo.lima@sinqia.com.br", "177.070.267.99", "Benfica");
  //          alunoService.cadastrarAluno("Jonathan Santos", "jonathan.santos@sinqia.com.br", "123.456.789-33", "Campo Grande");

            //professorService.cadastrarProfessor("Bruno Chel", "bruno.chel@sinqia.com.br", "231.233.444.77", "Rio de Janeiro");
            //professorService.cadastrarProfessor("Tauan Silva", "tauan.silva@sinqia.com.br", "214.933.444.77", "Rio de Janeiro");

            //alunoService.cadastrarMateriaAluno("Hugo Lima", "Programacao");

            foreach (Materia materialist in materiaService.GetAll())
            {
                Console.WriteLine("\n" + materialist);
            }

            foreach (Aluno alunoSearch in AlunoRepository.GetAll())
            {
                Console.WriteLine("\nAluno: "+alunoSearch);
                
            }

            foreach (Professor professorSearch in ProfessorRepository.GetAll())
            {
                Console.WriteLine("\nProfessor: " + professorSearch);
            }
        }
    }
}
