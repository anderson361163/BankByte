using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
        }
    }
}
