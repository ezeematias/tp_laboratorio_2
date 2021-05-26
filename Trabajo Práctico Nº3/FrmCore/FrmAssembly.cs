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
    }
}
