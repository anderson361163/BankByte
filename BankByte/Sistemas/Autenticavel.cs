using BankByte.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankByte
{
    public interface Autenticavel
    {

        bool Autenticar(string senha);

    }
}
