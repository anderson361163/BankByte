﻿using BankByte.Funcionario;
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
            CalcularBonificacao();
            //FINALIZA O PROGRAMA
            Console.WriteLine("\nPressione a tecla Enter para finalizar o programa . . .");
            Console.ReadLine();

        }

        public static  void CalcularBonificacao()
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor anderson = new Desenvolvedor("456.175.468-20");
            anderson.Nome = "Anderson";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(anderson);

            Console.WriteLine("Total de bonificações do mês {0}.",
                            gerenciador.GetTotalBonicacao());



        }
    }
}
