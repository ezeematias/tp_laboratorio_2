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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NO DATA DEVICES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
