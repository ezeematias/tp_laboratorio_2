﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase Ciclomotor que hereda de Vehículo.
    /// </summary>
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Constructor Ciclomotor.
        /// </summary>
        /// <param name="marca">Atributo marca para el vehículo.</param>
        /// <param name="chasis">Atributo chasis para el vehículo.</param>
        /// <param name="color">Atributo color para el vehículo.</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }

        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary> 
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// Lista los datos del Ciclomotor.
        /// </summary>
        /// <returns>Retorna los datos en string del Ciclomotor.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            return sb.ToString();
        }
    }
}
