using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdaptadorDeMotor : IMotor
    {
        MotorElectrico motorEle = new MotorElectrico();
        public void Acelerar()
        {
            Console.WriteLine("Acelerando motor electrico");
            motorEle.MoverMasRapido();

        }

        public void Apagar()
        {
            Console.WriteLine("Iniciando proceso de apagado");
            motorEle.Detener();
            motorEle.Desconectar();
            Console.WriteLine("Motor electrico apagado!!!");
        }

        public void Encender()
        {
            Console.WriteLine("Iniciando proceso de encendido");
            motorEle.Conectar();
            motorEle.Activar();
            Console.WriteLine("Motor electrico encendido!!!");
        }

        
        
    }
}
