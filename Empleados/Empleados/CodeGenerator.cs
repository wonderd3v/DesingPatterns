using System;
using System.Collections.Generic;
using System.Text;


namespace Empleados
{
    public class CodeGenerator
    {
        public static string Generator(string nome)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 999);
            int size = nome.Length;
            string text = nome.Substring(0, 3);
            string code = ($" {text} {num} ");

            return code;
        }
    }
}
