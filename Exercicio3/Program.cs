using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Conta
    {
        public double Saldo { get; set; }

        public double CalcularTaxaAdministrativa()
        {
            return 1;
        }
    }

    public class ContaCorrente : Conta
    {
        public double CalcularTaxaAdministrativa()
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.Saldo = 1000;
            Console.WriteLine(contaCorrente.CalcularTaxaAdministrativa());
            Console.ReadLine();
        }
    }
}
