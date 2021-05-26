using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

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
            dgvInternalOrder.DataSource = null;
            dgvInternalOrder.DataSource = CoreSystem.InternalOrders;
        }


        // este es el swithc
        private void button1_Click(object sender, EventArgs e)
        {
            if(!switchP)
            {
                btnP.ImageIndex = 1;
                //dgvInternalOrder.DataSource = CoreSystem.InternalOrders; //este lo puse para probar recien, pero nop.
            }
            else
            {
                btnP.ImageIndex = 0;
            }
            switchP = !switchP;
        }
    }
}
