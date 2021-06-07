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
            LoadOrders();
        }

        private void btnAceptOrder_Click(object sender, EventArgs e)
        {
            if (CoreSystem.PreviewDevices.Count == 0)
            {
                CoreSystem.SelectedOrder = (InternalOrder)dgvInternalOrder.CurrentRow.DataBoundItem;
                //FrmProduction.orderAssembly = true;
                ChangeBackColor();
            }
            else if (MessageBox.Show("Unsaved devices will be lost. Do you want to change your order anyway?", "ORDER IN EXECUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                CoreSystem.PreviewDevices.Clear();
                CoreSystem.SelectedOrder = (InternalOrder)dgvInternalOrder.CurrentRow.DataBoundItem;
                ChangeBackColor();
            }
            else
            {
                ChangeBackColor();
            }

        }

        private void LoadOrders()
        {
            dgvInternalOrder.DataSource = null;
            dgvInternalOrder.DataSource = CoreSystem.InternalOrders;
        }

        private void FrmInternalOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void ChangeBackColor()
        {
            ActiveForm.BackColor = Color.White;
            ActiveForm.BackColor = Color.Black;
        }
    }
}
