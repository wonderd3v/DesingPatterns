using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MotorComun : IMotor
    {
        public void Acelerar()
        {
            Console.WriteLine("Halando el cable");
            
        }

        public void Apagar()
        {
            Console.WriteLine("Paralo y se apaga solo");
            
        }

        public void Encender()
        {
            Console.WriteLine("Dando patada (brummm!!)");
            
        }

       
    }
}
