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
    public partial class FrmDevices : Form
    {
        /// <summary>
        /// Builder default.
        /// </summary>
        public FrmDevices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load form default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDevices_Load(object sender, EventArgs e)
        {
            try
            {
                Stock.ReadDevices();
                this.dgvDevices.DataSource = Stock.DevicesStock;
                this.lblErrorList.Visible = false;
            }
            catch (Exception ex)
            {
                this.lblErrorList.Visible = true;
                this.lblErrorList.Text = "There are no work orders to carry out.";
                Device.SaveErrorLogDevices(ex.Message);    
            }
        }
    }
}
