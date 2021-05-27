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
    public partial class FrmAssembly : Form
    {
        bool switchP = false;
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
            LoadOrderSelected();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (!switchP)
            {
                btnP.ImageIndex = 1;
            }
            else
            {
                btnP.ImageIndex = 0;
            }
            switchP = !switchP;
        }

        private void LoadOrderSelected(int index = 0)
        {
            int n = dgvOrder.Rows.Add();
            /*
            dgvOrder.Rows[n].SetValues(CoreSystem.InternalOrders[index].NumberOrder);
            dgvOrder.Rows[n].SetValues(CoreSystem.InternalOrders[index].NameDevice); 
            dgvOrder.Rows[n].SetValues(CoreSystem.InternalOrders[index].ETypeDevice);
            dgvOrder.Rows[n].SetValues(CoreSystem.InternalOrders[index].CountDevice); 
            */
            dgvOrder.Rows[0].Cells[0].Value = CoreSystem.InternalOrders[index].NumberOrder;
            dgvOrder.Rows[0].Cells[1].Value = CoreSystem.InternalOrders[index].NameDevice;
            dgvOrder.Rows[0].Cells[2].Value = CoreSystem.InternalOrders[index].ETypeDevice;
            dgvOrder.Rows[0].Cells[3].Value = CoreSystem.InternalOrders[index].CountDevice;

        }


    }
}
