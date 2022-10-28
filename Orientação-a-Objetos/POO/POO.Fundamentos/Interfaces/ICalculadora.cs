using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Fundamentos.Interfaces
{
    public interface ICalculadora
    {
        //Uma interface não implementa modificadores de acesso pois já é implícito que é public
        int Somar(int a, int b);
        int Subtrair(int a, int b);
        int Multiplicar(int a, int b);
        //Se implementarmos um corpo num método de Interface, esse método perde a obrigação de implementação quando alguma classe implementar a interface, porém todo método sem corpo tem obrigação de ser implementado quando qualquer classe implementar a interface.
        int Dividir(int a, int b)
        {
            return a/b;
        }
    }
}