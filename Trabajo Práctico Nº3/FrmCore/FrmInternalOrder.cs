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
        /// <summary>
        /// Builder default.
        /// </summary>
        public FrmInternalOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load form default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInternalOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        /// <summary>
        /// Loads the selected device in the selected order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptOrder_Click(object sender, EventArgs e)
        {
            if (CoreSystem.PreviewDevices.Count == 0)
            {
                CoreSystem.SelectedOrder = (InternalOrder)this.dgvInternalOrder.CurrentRow.DataBoundItem;
                ChangeBackColor();
            }
            else if (MessageBox.Show("Unsaved devices will be lost. Do you want to change your order anyway?", "ORDER IN EXECUTION", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                CoreSystem.PreviewDevices.Clear();
                CoreSystem.SelectedOrder = (InternalOrder)this.dgvInternalOrder.CurrentRow.DataBoundItem;
                ChangeBackColor();
            }
            else
            {
                ChangeBackColor();
            }

        }

        /// <summary>
        /// Load the list of pending work orders.
        /// </summary>
        private void LoadOrders()
        {
            try
            {
                InternalOrder.ReadInternalOrder();
                this.dgvInternalOrder.DataSource = null;
                this.dgvInternalOrder.DataSource = CoreSystem.InternalOrders;
                this.lblErrorList.Visible = false;

            }
            catch (Exception ex)
            {                
                this.btnAceptOrder.Enabled = false;
                this.lblErrorList.Visible = true;
                this.lblErrorList.Text = "There are no work orders to carry out.";
                InternalOrder.SaveErrorLogOrder(ex.Message);
            }
        }

        /// <summary>
        /// Close form default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInternalOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// Event generated to change the form.
        /// </summary>
        private void ChangeBackColor()
        {
            ActiveForm.BackColor = Color.White;
            ActiveForm.BackColor = Color.Black;
        }
    }
}
