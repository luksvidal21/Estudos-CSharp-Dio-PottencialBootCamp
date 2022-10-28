using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Fundamentos.Models
{
    public abstract class Conta
    {
        protected decimal saldo;
        public abstract void Creditar(decimal credito);
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de {saldo}");
        }
    }
}