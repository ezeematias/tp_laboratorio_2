using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double output = 0;
            switch (ValidarOperador(operador[0]))
            {
                case "-":
                    output = num1 - num2;
                    break;
                case "/":                    
                    output = num1 / num2;
                    break;
                case "*":
                    output = num1 * num2;
                    break;
                case "+":
                    output = num1 + num2;
                    break;
            }
            return output;
        }
        
        private static string ValidarOperador(char operador)
        {
            string output;
            switch (operador)
            {
                case '-':
                    output = "-";
                    break;
                case '/':
                    output = "/";
                    break;
                case '*':
                    output = "*";
                    break;
                default:
                    output = "+";
                    break;
            }
            return output;
        }
    }
}
