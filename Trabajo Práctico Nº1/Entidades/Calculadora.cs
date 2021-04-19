using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Calculadora.
    /// </summary>
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operación recibida por parametro y devuelve el resultado.
        /// </summary>
        /// <param name="num1">Primer número para realizar la operación.</param>
        /// <param name="num2">Segund número para realizar la operación.</param>
        /// <param name="operador">Operador para realizar la operación.</param>
        /// <returns>El resultado de la operación.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double output = 0;
            char auxOperador;
            if (operador == "")
            {
                auxOperador = '+';
            }
            else
            {
                auxOperador = operador[0];
            }
            switch (ValidarOperador(auxOperador))
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

        /// <summary>
        /// Valida que el operador sea válido para la operación.
        /// </summary>
        /// <param name="operador">Operador para ser validado.</param>
        /// <returns>Operador en formato string.</returns>
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
