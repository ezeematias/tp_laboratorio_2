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
    public partial class FrmInternalOrder : Form
    {
        bool switchP = false;
        public FrmInternalOrder()
        {
            InitializeComponent();
        }

        private void FrmInternalOrder_Load(object sender, EventArgs e)
        {
            dgvInternalOrder.Rows.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!switchP)
            {
                btnP.ImageIndex = 1;
            }
            else
            {
                btnP.ImageIndex = 0;
            }
            switchP = !switchP;
        }
    }
}
