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
    public partial class FrmComponents : Form
    {
        public FrmComponents()
        {
            InitializeComponent();
        }

        private void FrmComponents_Load(object sender, EventArgs e)
        {
            this.dgvComponents.DataSource = Stock.ComponentsStock;
        }

        private void btnAddComponents_Click(object sender, EventArgs e)
        {
            if((Components)this.dgvComponents.CurrentRow.DataBoundItem + (int)this.nudCountComponents.Value)
            {
                this.dgvComponents.DataSource = null;
                this.dgvComponents.DataSource = Stock.ComponentsStock;
                Stock.SaveComponents();
            }
        }
    }
}
