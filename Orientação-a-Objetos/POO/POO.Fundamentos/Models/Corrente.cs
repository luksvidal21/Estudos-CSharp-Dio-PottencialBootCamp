using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Fundamentos.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal credito)
        {
            saldo += credito;
        }
    }
}