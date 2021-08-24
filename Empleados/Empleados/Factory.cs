using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{
    class Factory
    {
        public static IPayment GetEmployee(int opt)
        {
            if (opt == 2)
            {
                return new Administrative();
            }

            if (opt == 3)
            {
                return new Operative();
            }
            else
            {
                return null;
            }

        }
    }
}
