using BankByte.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankByte.Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //INSTANCIA O FUNCIONÁRIO CARLOS
            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            //SOMA A BONIFICAÇÃO DE CARLOS COM A DA EMPRESA
            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;

            //SOMA A BONIFICAÇÃO DE ROBERTA COM A DA EMPRESA
            gerenciador.Registrar(roberta);

            //IMPRIMIE OS DADOS DE CARLOS
            Console.WriteLine("Nome Funcionario: {0}", carlos.Nome);
            Console.WriteLine("Valor de Bonificações: {0}", carlos.GetBonificacao().ToString("C2"));

            //IMPRIME OS DADOS DA ROBERTA
            Console.WriteLine("Nome Funcionario: {0}", roberta.Nome);
            Console.WriteLine("Valor de Bonificações: {0}", roberta.GetBonificacao().ToString("C2"));

            //IMPRIME O GASTO FINAL DA EMPRESA COM O SALARIO E AS BONIFICAÇÕES
            Console.WriteLine("Custo final de bonificações: {0}", gerenciador.GetTotalBonicacao());


            //FINALIZA O PROGRAMA
            Console.WriteLine("\nPressione a tecla Enter para finalizar o programa . . .");
            Console.ReadLine();

        }
    }
}
