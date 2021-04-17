using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Constructor
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero) : this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero) : this ()
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Convierte el string del numero binario en decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                return Convert.ToInt32(binario, 2).ToString();
            }
            return "VALOR INVÁLIDO";
        }

        /// <summary>
        /// Convierte el bouble del número en string binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            if (numero > 0)
            {
                return Convert.ToString((int)numero, 2);
            }
            return "VALOR INVÁLIDO";
        }

        /// <summary>
        /// Convierte el string del número en string binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero, out double doubleNum))
            {
                return DecimalBinario(doubleNum);
            }
            return "VALOR INVÁLIDO";
        }

        /// <summary>
        /// Comprueba que el string recibido sea un número binario.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool output = false;
            if (binario.Length > 0)
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] == '1' || binario[i] == '0')
                    {
                        output = true;
                    }
                    else
                    {
                        output = false;
                    }
                }
            }
            return output;
        }

        /// <summary>
        /// Sobrecarga del operador - para clase Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador + para clase Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador * para clase Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador / para clase Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double output = double.MinValue;
            if (n2.numero != 0)
            {
                output = n1.numero / n2.numero;
            }
            return output;
        }

        /// <summary>
        /// Valida que el número recibido en string sea correcto.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private static double ValidarNumero(string strNumero)
        {
            double.TryParse(strNumero, out double retorno);
            return retorno;
        }

        /// <summary>
        /// Propiedad Setter de Numero.
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
    }
}
