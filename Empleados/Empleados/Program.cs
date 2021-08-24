using System;
using System.Collections.Generic;

namespace Empleados
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Administrative> EmploAdm = new List<Administrative>();
            string ced;
            string co;
            string Na;
            string LastN;
            string Em;
            string TP;
            string Dept;
            string Car;
            double Sph;
            double Wh;
            double Salario;
            double SalarioNeto;

            string opt = null;
            Menu();
            opt = Console.ReadLine();
            switch (opt)
            {
                case "a": 
                    int elec = 0;
                    
                    MenuEmpleados();
                    elec = int.Parse(Console.ReadLine());

                    Console.Write("Cedula: ");
                    ced = Console.ReadLine();

                    Console.Write("Nombre: ");
                    Na = Console.ReadLine();

                    Console.Write("Apellido: ");
                    LastN = Console.ReadLine();

                    Console.Write("Correo electronico: ");
                    Em = Console.ReadLine();

                    Console.Write("Telefono/Celular: ");
                    TP = Console.ReadLine();

                    Console.Write("Departamento: ");
                    Dept = Console.ReadLine();

                    co = CodeGenerator.Generator(Dept);

                    Console.Write("Cargo: ");
                    Car = Console.ReadLine();

                    Console.Write("Salario por hora: ");
                    Sph = Convert.ToDouble(Console.ReadLine());
                    
                    Console.Write("Horas trabajadas: ");
                    Wh = Convert.ToDouble(Console.ReadLine());

                    Salario = Sph * Wh;


                    if (elec == 1)
                    {
                        Mangerial Gerente = Mangerial.GetManager(ced, co, Na, LastN, Em, TP, Dept, Car, Sph, Wh, Salario);
                        Gerente.NetSalary = Gerente.Payment(Salario);
                        Console.Write("Gerente creado con exito!");
                        Console.ReadKey();
                    }

                    if (elec == 2)
                    {
                        IPayment payment = Factory.GetEmployee(elec);
                        SalarioNeto = payment.Payment(Salario);
                    }

                    if (elec == 3)
                    {
                        IPayment payment = Factory.GetEmployee(elec);
                        SalarioNeto = payment.Payment(Salario);
                    }
                    break;
                case "v":
                    Mangerial.ShowManager();

                    break;

            }
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Write
                ("==============================================\n" +
                "================Manejo de nomina===============" +
                " \n==============================================\n" +
                "\n a. Agregar empleado." +
                "\n v. Ver empleados" +
                "\n r. Recibo de pagos" +
                "\n Especifique su opción. -> "
                 );
        }

        static void MenuEmpleados()
        {
            Console.Write("Especifique que tipo de empleado quiere crear \n" +
                       "1. Gerente \n" +
                       "2. Administrativo \n" +
                       "3. Operativo \n"
                       );
        }
    }
}
