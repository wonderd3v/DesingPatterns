using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy2
{
    class Program
    {
        static void Main(string[] args)
        {
            CContexto contexto=null;//Variable de referencia
            Console.Clear();
            Console.Write("[G]GERENCIAL [A]ADMINISTRATIVO [O]OPERATIVO ");
            string opcion = Console.ReadLine().ToLower();
            switch (opcion)
            {
                case "g": 
                    CGerencial gerente = new CGerencial();
                    contexto = new CContexto(gerente);//Objeto
                    break;
                case "a":
                    CAdministrativo administrador = new CAdministrativo();
                    contexto = new CContexto(administrador);
                    break;
                case "o":
                    COperativo operador = new COperativo();
                    contexto = new CContexto(operador);
                    break;
                default:
                    Console.WriteLine("OPCION INCORRECTA!!!");
                    Main(args);
                    break;                      
            }
            contexto.Ejecutar(1000);
            Console.ReadKey();
            Main(args);



        }
    }
}
