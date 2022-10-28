using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Fundamentos.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá! Sou professor {Nome} e tenho {Idade} anos ");
        }
    }
}