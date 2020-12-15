using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Base
    {
        public int Numero { get; set; }
        public virtual void M()
        {
            Console.WriteLine("M");
        }

    }
}
