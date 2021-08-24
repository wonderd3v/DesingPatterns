using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy2
{
    class CAdministrativo : IEstrategia
    {
        public void CalcularBono(double salario)
        {
            Console.WriteLine("BONO EMPLEADO ADMINISTRATIVO:");
            Console.WriteLine(salario += salario * 0.25);
        }
    }
}
