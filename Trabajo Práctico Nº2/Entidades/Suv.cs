using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Suv que hereda de Vehículo.
    /// </summary>
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Constructor de Suv.
        /// </summary>
        /// <param name="marca">Atributo marca para el vehículo.</param>
        /// <param name="chasis">Atributo chasis para el vehículo.</param>
        /// <param name="color">Atributo color para el vehículo.</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Lista los datos del Suv.
        /// </summary>
        /// <returns>Retorna los datos en string del Suv.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
    }
}
