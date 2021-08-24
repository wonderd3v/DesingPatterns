using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{
    class Mangerial : IPayment
    {
        private static Mangerial Manager;
        private string Cedula;
        private string Code;
        private string Name;
        private string LastName;
        private string Email;
        private string TelPhone;
        private string Department;
        private string Cargo;
        private double SalaryPerHour;
        private double WorkedHours;
        private double Salary;
        private static int i;

        public double NetSalary{ get; set; }
        private Mangerial(string C, string Cc, string N, string LN, string E, string T, string D, string Cag, double SPH, double WH, double S)
        {
            Cedula = C;
            Code = Cc;
            Name = N;
            LastName = LN;
            Email = E;
            TelPhone = T;
            Department = D;
            Cargo = Cag;
            SalaryPerHour = SPH;
            WorkedHours = WH;
            Salary = S;

        }

        public static Mangerial GetManager(string C, string Cc, string N, string LN, string E, string T, string D, string Cag, double SPH, double WH, double S)
        {
            if (Manager == null)//Validando si la instancia no existe
            {
                Manager = new Mangerial(C, Cc, N, LN, E, T, D, Cag, SPH, WH, S); //Crea la instancia

            }

            return Manager; //Devuelve la instancia
        }

        public static void ShowManager()
        {
           if(Manager != null)
            {
                Console.Write($"Gerente: \nNombre: {Manager.Name}\nApellido: {Manager.LastName}\nCódigo: {Manager.Code}\nCedula: {Manager.Cedula}\nEmail: {Manager.Email} \nTelefono:{Manager.TelPhone}\nDepartamento: {Manager.Department} \nCargo: {Manager.Cargo}\nSalario: {Manager.Salary}\nSalario Neto {Manager.NetSalary}");
            }
        }

        public double Payment(double Salary)
        {
            double bono = 0.5;
            this.NetSalary = Salary + (Salary * bono);

            return NetSalary;
        }
    }
}


