using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankByte.Funcionario
{
    public abstract class FuncionarioAutenticavel : Funcionarios, Autenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(string cpf, double salario)
            : base(cpf, salario)
        {
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
