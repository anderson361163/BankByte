using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Escrever escrito = new Escrever();

            escrito.EscreveNumero(15);
            escrito.EscreveNumero(1.70);

            Console.WriteLine("Pressione enter para finalizar o programa . . . ");
            Console.ReadLine();

        }
    }
}
