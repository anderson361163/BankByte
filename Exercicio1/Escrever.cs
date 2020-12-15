using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{ 
        public class Escrever
        {
            public void EscreveNumero(int n)
            {
                Console.WriteLine("inteiro: " + n);
            }
            public void EscreveNumero(double n)
            {
                Console.WriteLine("ponto flutuante: " + n);
            }
        }
}
