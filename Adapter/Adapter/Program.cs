using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotor moto;

            Console.Clear();
            Console.Write("[1]Motor comun  [2]Motor electrico: ");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                moto = new MotorComun();
            }
            else
            {
                moto = new AdaptadorDeMotor();
            }

            moto.Encender();
            Console.WriteLine("******");
            moto.Acelerar();
            Console.WriteLine("******");
            moto.Apagar();
            Console.ReadKey();

            Main(args);
        }
    }
}
