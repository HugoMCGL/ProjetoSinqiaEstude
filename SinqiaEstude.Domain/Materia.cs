using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaEstude.Domain
{
    public class Materia
    {
        public string nome { get; set; }
        public double nota { get; set; }

        public Materia (string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return "\nMateria: " + nome;
        }
    }

}
