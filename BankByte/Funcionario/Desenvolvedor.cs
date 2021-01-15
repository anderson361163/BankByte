using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankByte.Funcionario
{
    class Desenvolvedor : Funcionarios
    {
        public Desenvolvedor(string cpf) : base (cpf, 3000)
        {
            Console.WriteLine("CRIANDO DESENVOLVEDOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15; 
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
