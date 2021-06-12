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
        public FrmDevices()
        {
            InitializeComponent();
        }

        private void FrmDevices_Load(object sender, EventArgs e)
        {
            this.dgvDevices.DataSource = Stock.DevicesStock;
        }
    }
}
