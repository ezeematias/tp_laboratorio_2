using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        /// <summary>
        /// Enumerado de las marcas de lso vehículos.
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Enumerados del tamaño de los vehículos.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        private EMarca marca;
        private string chasis;
        private ConsoleColor color;

        /// <summary>
        /// Constructor de clase Vehículo.
        /// </summary>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Retorna un string con los datos del vehículo.</returns>
        public virtual string Mostrar()
        {            
            return (string)this;            
        }

        /// <summary>
        /// Sobrecarga del string para listar los datos del vehículo.
        /// </summary>
        /// <param name="p">Vehículo</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");
            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Primer vehículo para comparar.</param>
        /// <param name="v2">Segundo vehículo para comparar.</param>
        /// <returns>Retorna true el número de chasis entre ambos vehículos es el mismo.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (!(v1 is null) && !(v2 is null))
            {
                 return v1.chasis == v2.chasis; 
            }
            return false;
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">Primer vehículo para comparar.</param>
        /// <param name="v2">Segundo vehículo para comparar.</param>
        /// <returns>Retorna true el número de chasis entre ambos vehículos es distinto.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {      
            return !(v1 == v2);
        }
    }
}
