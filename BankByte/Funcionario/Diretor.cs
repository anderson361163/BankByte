using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankByte.Funcionario
{
    class Diretor : Funcionario
    {
        //MESMO COM O ATRIBUTO SALARIO NA CLASSE PAI, NOS CONSEGUIMOS ACESSAR
        //NA CLASSE FILHA, JÁ QUE ELA HERDA ESSES ATRIBUTOS
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
