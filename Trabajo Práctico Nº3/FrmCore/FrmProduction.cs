using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCore
{
    public partial class FrmProduction : Form
    {
        bool aux = false;
        public FrmProduction()
        {
            InitializeComponent();
        }

        private void FrmProduction_Load(object sender, EventArgs e)
        {
        }

        private void btnOrder_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnOrder.ForeColor = Color.MediumVioletRed;
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            this.btnOrder.ForeColor = Color.Gray;
        }

        private void btnAssembly_MouseLeave(object sender, EventArgs e)
        {
            this.btnAssembly.ForeColor = Color.Gray;
        }

        private void btnAssembly_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnAssembly.ForeColor = Color.MediumVioletRed;
        }

        private void btnOptions_MouseLeave(object sender, EventArgs e)
        {
            this.btnOptions.ForeColor = Color.Gray;

        }

        private void btnOptions_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnOptions.ForeColor = Color.MediumVioletRed;
        }

        private void btnOptionSignOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            aux = true;

        }

        private void btnOptionExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProduction_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to go out?", "EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;               
            }
            else if (aux)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.Abort;
            }

        }
    }
}
