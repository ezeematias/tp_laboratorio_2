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

        }

        public string BinarioDecimal(string binario)
        {
            
            return binario;
        }

        public string DecimalBinario(double numero)
        {
            return numero.ToString();
        }
        public string DecimalBinario(string numero)
        {
            return numero;
        }

        private bool EsBinario(string binario)
        {
            return true;
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
            return n1.numero / n2.numero;
        }

        private static double ValidarNumero (string strNumero)
        {
            double retorno = 0;
            double.TryParse(strNumero, out retorno);        
            return retorno;
        }

        public void SetNumero(string strNumero)
        {
            this.numero = ValidarNumero(strNumero);
        }

    }
}
