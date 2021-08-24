using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy2
{
    class CGerencial : IEstrategia
    {
        public void CalcularBono(double salario)
        {
            Console.WriteLine("BONO EMPLEADO GERENCIAL:");
            Console.WriteLine(salario += salario * 0.50);
        }
    }
}
