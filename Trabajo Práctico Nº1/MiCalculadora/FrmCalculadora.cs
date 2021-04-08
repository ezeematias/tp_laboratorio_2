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
        private double resultado;

        public MiCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

            if (double.TryParse(this.txtNumero1.Text, out double aux1) || double.TryParse(this.txtNumero2.Text, out double aux2))
            {
                resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                if (resultado == double.MinValue)
                {
                    this.lblResultado.Text = "ERROR";
                    MessageBox.Show("No se puede dividir por 0 (Cero)", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
                else
                {
                    this.lblResultado.Text = resultado.ToString();
                    btnBinarioDecimal.Enabled = false;
                    btnDecimalBinario.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Se deben colocar valores numéricos", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpiar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "0";
            btnBinarioDecimal.Enabled = false;
            btnDecimalBinario.Enabled = true;
        }

        private double Operar(string numero1, string numero2, string operador)
        {
            num1 = new Numero(this.txtNumero1.Text);
            num2 = new Numero(this.txtNumero2.Text);
            return Calculadora.Operar(num1, num2, operador);
        }

        private void MiCalculadora_Load(object sender, EventArgs e)
        {
            this.lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
        }

        private void btnDecimalBinario_Click(object sender, EventArgs e)
        {
            btnDecimalBinario.Enabled = false;
            if (!(this.lblResultado.Text == "0"))
            {
                string binario = num1.DecimalBinario(this.lblResultado.Text);
                this.lblResultado.Text = binario;
            }
            btnBinarioDecimal.Enabled = true;
        }

        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            btnBinarioDecimal.Enabled = false;
            if (!(this.lblResultado.Text == "0"))
            {
                string binario = num1.BinarioDecimal(this.lblResultado.Text);
                this.lblResultado.Text = binario;
            }
            btnDecimalBinario.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
