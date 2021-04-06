using System;
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
    public partial class MiCalculadora : Form
    {
        private Numero num1;
        private Numero num2;
        private string operador;
        private double resultado;

        public MiCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            num1 = new Numero(this.txtNumero1.Text);
            num2 = new Numero(this.txtNumero2.Text);
            operador = this.cboOperador.Text;
            resultado = Calculadora.Operar(num1, num2, operador);
            if (resultado == double.MinValue)
            {
                this.lblResultado.Text = "ERROR";
            }
            else
            {
                this.lblResultado.Text = resultado.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "0";
  
        }
    }
}
