using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    /// <summary>
    /// Clase Sedan que hereda de Vehículo.
    /// </summary>
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Atributo marca para el vehículo.</param>
        /// <param name="chasis">Atributo chasis para el vehículo.</param>
        /// <param name="color">Atributo color para el vehículo.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Constructor de Sedan.
        /// </summary>
        /// <param name="marca">Atributo marca para el vehículo.</param>
        /// <param name="chasis">Atributo chasis para el vehículo.</param>
        /// <param name="color">Atributo color para el vehículo.</param>
        /// <param name="tipo">Atributo tipo para el vehículo.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Lista los datos del Sedan.
        /// </summary>
        /// <returns>Retorna los datos en string del Sedan.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
    }
}
