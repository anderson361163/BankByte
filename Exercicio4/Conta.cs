using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public abstract class Conta
    {
        public int Numero { get; private set; }
        public int Agencia { get; private set; }

        public Conta(int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
        }
    }
}
