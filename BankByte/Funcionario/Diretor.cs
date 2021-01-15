using BankByte.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankByte.Funcionario
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("CRIANDO DIRETOR");
        }
        
        //MESMO COM O ATRIBUTO SALARIO NA CLASSE PAI, NOS CONSEGUIMOS ACESSAR
        //NA CLASSE FILHA, JÁ QUE ELA HERDA ESSES ATRIBUTOS
        public override double GetBonificacao()
        {
            return Salario * 1.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
