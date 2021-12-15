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
                Console.WriteLine("\n--Bem vindo ao Sistema Sinqia Estude--\nDigite 1 para Gestão de aluno \nDigite 2 para Gestão de professores \n Digite 3 para Gestão de matérias \n Digite 4 para Gestão financeira");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("menu: "+menu);
                continua = true;
                switch (menu)
                {
                    case 1:

                        while (continua == true)
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("\n Digite 1 para cadastrar Aluno \nDigite 2 para Excluir aluno \nDigite 3 para atribuir matéria para o Aluno");
                            escolha = Convert.ToInt32(Console.ReadLine());
                            if (escolha == 1)//cadastrar aluno
                            {
                                Console.WriteLine("Digite o nome do Aluno: ");
                                nome = Console.ReadLine();
                                Console.WriteLine("Digite a idade do Aluno: ");
                                idade = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Digite o cpf do Aluno: ");
                                cpf = Console.ReadLine();
                                Console.WriteLine("Digite o email do Aluno: ");
                                email = Console.ReadLine();
                                Console.WriteLine("Digite o endereço do Aluno: ");
                                endereco = Console.ReadLine();
                                alunoService.cadastrarAluno(nome, idade, email, cpf, endereco);
                                continua = false;
                            }
                            else if (escolha == 2)//excluir aluno
                            {

                                
                            }
                           
                            else if (escolha == 3)//atribuir matéria para o aluno
                            {
                                Console.WriteLine("Digite o nome do Aluno: ");
                                nome = Console.ReadLine();
                                Console.WriteLine("Digite o nome da matéria: ");
                                nomeMateria = Console.ReadLine();

                                alunoService.cadastrarMateriaAluno(nome, nomeMateria);
                                if (alunoService.statusAtribuicaoMateria)
                                {
                                    continua = false;
                                } 
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
                            Console.WriteLine("\n Digite 1 para cadastrar Professor \nDigite 2 para Excluir professor \nDigite 3 para atribuir matéria para o Professor");
                            escolha = Convert.ToInt32(Console.ReadLine());
                            if (escolha == 1)//cadastrar professor
                            {
                                Console.WriteLine("Digite o nome do Professor: ");
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
                                Console.WriteLine("Digite o nome do Aluno: ");
                                nome = Console.ReadLine();
                                Console.WriteLine("Digite o nome da matéria: ");
                                nomeMateria = Console.ReadLine();

                                alunoService.cadastrarMateriaAluno(nome, nomeMateria);
                                if (alunoService.statusAtribuicaoMateria)
                                {
                                    continua = false;
                                }
                            }
                            else
                            {
                                Thread.Sleep(500);
                                Console.WriteLine("Escolha inválida! ");
                            }

                        }
                        break;

                    case 3:
                        continuaMenu = false;
                        break;
                    default:
                        Console.WriteLine("passou direto");
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
