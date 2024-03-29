﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    /// <summary>
    /// Clase MiCalculadora Form.
    /// </summary>
    public partial class MiCalculadora : Form
    {
        private static Numero num1;
        private static Numero num2;
        private static double resultado;

        /// <summary>
        /// Contructor por defecto.
        /// </summary>
        public MiCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento generado al presionar el botón Operar. 
        /// Realiza las operaciones declaradas por el usuario dentro de los campos del Forms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtNumero1.Text.Replace(".", ","), out _) && double.TryParse(this.txtNumero2.Text.Replace(".", ","), out _))
            {
                resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                if (resultado == double.MinValue)
                {
                    this.lblResultado.Text = "ERROR";
                    MessageBox.Show("No se puede dividir por 0(Cero)", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.lblResultado.Text = resultado.ToString();
                    btnConvertirADecimal.Enabled = false;
                    btnConvertirABinario.Enabled = true;
                }
            }
            else
            {
                this.lblResultado.Text = "ERROR";
                MessageBox.Show("Se deben colocar solo valores numéricos", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento generado al presionar el botón Limpiar. 
        /// Vuelve a los campos a su estado inicial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Método que inicializa los campos del forms.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "0";
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
        }

        /// <summary>
        /// Método que realiza las operaciones solicitadas en el Forms.
        /// Llama a la lógica del programa para su funcionamiento.
        /// </summary>
        /// <param name="numero1">Primer número para operar.</param>
        /// <param name="numero2">Segundo número para operar</param>
        /// <param name="operador">Operador para poder operar.</param>
        /// <returns>Resultado de la operación.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            num1 = new Numero(numero1.Replace(".", ","));
            num2 = new Numero(numero2.Replace(".", ","));
            return Calculadora.Operar(num1, num2, operador);
        }

        /// <summary>
        /// Establece los campos en su estado inicial al abrir el Forms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiCalculadora_Load(object sender, EventArgs e)
        {
            this.lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento generado al presionar el botón Decimal a Binario. 
        /// Realiza la conversioens del resultado de la operación en Binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            double.TryParse(this.lblResultado.Text, out double aux);
            if (aux <= int.MaxValue)
            {
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = true;
            }
            else
            {
                MessageBox.Show("En esta versión no se puede convertir un número tan grande a binario,\nRealice otra operación por favor.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aux = 0;
            }
            if (aux < 0)
            {
                MessageBox.Show("En esta versión nos quedamos con el valor absoluto de los números negativos", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (aux != 0)
            {
                string binario = num1.DecimalBinario(this.lblResultado.Text);
                this.lblResultado.Text = binario;
            }
        }

        /// <summary>
        /// Evento generado al presionar el botón Binario a Decimal. 
        /// Realiza la conversioens del resultado de la operación en Decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            btnConvertirADecimal.Enabled = false;
            if (!(this.lblResultado.Text == "0"))
            {
                string binario = num1.BinarioDecimal(this.lblResultado.Text);
                this.lblResultado.Text = binario;
            }
            btnConvertirABinario.Enabled = true;
        }

        /// <summary>
        /// Evento generado al presionar el botón Cerrar.
        /// Cierra el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento para cerrar el Forms.
        /// Cierra el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MiCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "¡CERRAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
