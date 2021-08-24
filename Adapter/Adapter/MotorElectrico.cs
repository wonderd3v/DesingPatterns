using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MotorElectrico
    {
        private bool conectado;

        public MotorElectrico()
        {
            conectado = false;
        }

        public void Conectar()
        {
            Console.WriteLine("Conectando motor electrico");
            
            conectado = true;
        }

        public void Activar()
        {
            if (conectado)
            {
                Console.WriteLine("Esta conectado, activando motor" +
                  " electrico....");
                
            }
            else
            {
                Console.WriteLine("No se puede activar porque no " +
                  "esta conectado el motor electrico");
            }
        }

        public void MoverMasRapido()
        {
            if (conectado)
            {
                Console.WriteLine("Aumentando voltaje...Moviendo mas rapido!!!");
                
                
            }
            else
            {
                Console.WriteLine("No se puede mover rapido el motor " +
                  "electrico porque no esta conectado...");

            }
        }

        public void Detener()
        {
            if (conectado)
            {
                Console.WriteLine("Deteniendo el motor electrico");
                
                
            }
            else
            {
                Console.WriteLine("No se puede detener motor electrico" +
                  " porque no esta conectado");

            }
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectando el motor electrico");
            
            conectado = false;
        }
    }
}
