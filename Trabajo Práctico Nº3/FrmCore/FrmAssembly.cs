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
    public partial class FrmAssembly : Form
    {
        public FrmAssembly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmAssembly_Load(object sender, EventArgs e)
        {
            this.lblOperatorName.Text = FrmLogin.op.ToString();
        }

        private void FrmAssembly_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!(this.DialogResult == DialogResult.OK)&&(MessageBox.Show("All data will be lost.\nAre you sure you want to go out?", "EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No))
            {
                this.DialogResult = DialogResult.Abort;               
            }
        }
    }
}
