using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            return resultado;

        }
        
        private static string ValidarOperador(char operador)
        {
            string retorno;
            switch (operador)
            {
                case '-':
                    retorno = "-";
                    break;
                case '/':
                    retorno = "/";
                    break;
                case '*':
                    retorno = "*";
                    break;
                default:
                    retorno = "+";
                    break;
            }
            return retorno;
        }

    }
}
