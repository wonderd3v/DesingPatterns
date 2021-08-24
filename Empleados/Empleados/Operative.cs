using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados
{
    class Operative : IPayment
    {
        public String Cedula { get; set; }
        public int Code { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String TelPhone { get; set; }
        public String Department { get; set; }
        public String Cargo { get; set; }
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
