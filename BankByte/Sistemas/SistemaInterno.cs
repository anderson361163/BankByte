using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankByte.Funcionario;
namespace BankByte.Sistemas
{
    public class SistemaInterno
    {

        public bool Logar(Autenticavel autenticar, string senha)
        {
            bool usuarioAutenticado = autenticar.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
