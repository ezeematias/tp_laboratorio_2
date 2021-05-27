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
        public FrmInternalOrder()
        {
            InitializeComponent(); 
        }

        private void FrmInternalOrder_Load(object sender, EventArgs e)
        {
            dgvInternalOrder.DataSource = null;
            dgvInternalOrder.DataSource = CoreSystem.InternalOrders;
        }
    }
}
