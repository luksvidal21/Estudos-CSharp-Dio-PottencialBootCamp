using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Fundamentos.Models
{
    
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
    {
        
    }
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá me chamo {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}