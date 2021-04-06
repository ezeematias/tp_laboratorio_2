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

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            SetNumero(strNumero);
        }

        public string BinarioDecimal(string binario)
        {
            /*
            int exponente = binario.Length - 1;
            int numDecimal = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if (int.Parse(binario.Substring(i, 1)) == 1)
                {
                    numDecimal += int.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }
            return numDecimal.ToString();
            */
            if (EsBinario(binario))
            {
                return Convert.ToInt32(binario, 2).ToString();
            }
            return "Valor Inválido";
        }

        public string DecimalBinario(double numero)
        {
            if(numero>0)
            {
                return Convert.ToString((int)numero, 2);
            }
            return "Valor Inválido";
        }
        public string DecimalBinario(string numero)
        {
            if(double.TryParse(numero, out double doubleNum))
            {
             return DecimalBinario(doubleNum);
            }
            return "Valor Inválido";
        }

        private bool EsBinario(string binario)
        {
            bool output = false;
            if (binario.Length > 0)
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] == '1' && binario[i] == '0')
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

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double output = double.MinValue;
            if (n2.numero != 0)
            {
                output = n1.numero / n2.numero;
            }
            return output;
        }
        private static double ValidarNumero(string strNumero)
        {
            //double retorno = 0;
            double.TryParse(strNumero, out double retorno);
            return retorno;
        }

        public void SetNumero(string strNumero)
        {
            this.numero = ValidarNumero(strNumero);
        }
    }
}
