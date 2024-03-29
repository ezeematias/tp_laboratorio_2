﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Número.
    /// </summary>
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Constructor por defecto de la clase.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor de la clase Número.
        /// </summary>
        /// <param name="numero">Número que se instancia en el constructor.</param>
        public Numero(double numero) : this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de la clase Número.
        /// </summary>
        /// <param name="strNumero">Número en formato string, donde la propiedad lo instancia en double.</param>
        public Numero(string strNumero) : this ()
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Convierte el string del numero binario en decimal.
        /// </summary>
        /// <param name="binario">String para convertir a decinmal.</param>
        /// <returns>El número decimal sinó Valor inválido.</returns>
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
        /// <param name="numero">Double para convertir en Binario.</param>
        /// <returns>El número decimal sinó Valor inválido.</returns>
        public string DecimalBinario(double numero)
        {
            string output= "VALOR INVÁLIDO";
            if (numero < 0)
            {
                numero *= -1;
            }
            if (numero > 0)
            {
                output = Convert.ToString((int)numero, 2);
            }
            return output;
        }

        /// <summary>
        /// Convierte el string del número en string binario.
        /// </summary>
        /// <param name="numero">String para convertir en Binario.</param>
        /// <returns>El número binario sinó Valor inválido</returns>
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
        /// <param name="binario">String para validar.</param>
        /// <returns>TRUE o FALSE</returns>
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
        /// <param name="n1">Primer número para operar.</param>
        /// <param name="n2">Segundo número para operar.</param>
        /// <returns>n1.numero - n2.numero</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador + para clase Numero
        /// </summary>
        /// <param name="n1">Primer número para operar.</param>
        /// <param name="n2">Segundo número para operar.</param>
        /// <returns>n1.numero + n2.numero;</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador * para clase Numero
        /// </summary>
        /// <param name="n1">Primer número para operar.</param>
        /// <param name="n2">Segundo número para operar.</param>
        /// <returns>n1.numero * n2.numero</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador / para clase Numero
        /// </summary>
        /// <param name="n1">Primer número para operar.</param>
        /// <param name="n2">Segundo número para operar.</param>
        /// <returns>output = n1.numero / n2.numero</returns>
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
        /// <param name="strNumero">String para validar que sea numerico.</param>
        /// <returns>El número parseado a double.</returns>
        private static double ValidarNumero(string strNumero)
        {
            double.TryParse(strNumero, out double retorno);
            return retorno;
        }

        /// <summary>
        /// Propiedad Setter de Número.
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
