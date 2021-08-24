using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Empleados
{
    public class Administrative : IPayment
    {
        public string Cedula { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TelPhone { get; set; }
        public string Department { get; set; }
        public string Cargo { get; set; }
        public double SalaryPerHour { get; set; }
        public double WorkedHours { get; set; }
        public double FinalSalary { get; set; }



        double IPayment.Payment(double Salary)
        {
            double bono = 0.5;
            double NetSalary = Salary + (Salary * bono);
            return NetSalary;
        }

        

    }
}
