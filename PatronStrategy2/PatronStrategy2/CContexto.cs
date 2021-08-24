using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy2
{
    class CContexto
    {
        IEstrategia estrategia;
        public CContexto(IEstrategia objeto)
        {
            this.estrategia =objeto;            
        }
        public void Ejecutar(double valor)
        {
            estrategia.CalcularBono(valor);
        }
    }
}
