using System;
using System.Collections.Generic;
using SinqiaEstude.Domain;

namespace SinqiaEstude.Services
{
    public class ProfessorService
    {
        public List<Professor> listaProfessor = new List<Professor>();
        public int tamanhoLista = 0;
        public void cadastrarProfessor(string nome, int idade, string email, string cpf, string endereco)
        {
            Professor professor = new Professor(nome,idade, email, cpf, endereco);
            listaProfessor.Add(professor);
            Console.WriteLine("professor: " + nome + " criado com sucesso!" + listaProfessor);
            tamanhoLista++;
        }
        public override string ToString()
        {
            return " lista: " + listaProfessor;
        }
    }
}