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
        /// <summary>
        /// Builder default.
        /// </summary>
        public FrmComponents()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load Form Default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmComponents_Load(object sender, EventArgs e)
        {
            try
            {
                this.lblErrorList.Visible = false;
                Stock.ReadComponents();
                this.dgvComponents.DataSource = Stock.ComponentsStock;
            }
            catch (Exception ex)
            {
                this.lblErrorList.Visible = true;
                this.lblErrorList.Text = "A new list was created because a loaded one was not found.\nA log was generated with the specified path.";
                Components.SaveErrorLogComponents(ex.InnerException.Message);                
                Stock.InitializeComponents();
                this.dgvComponents.DataSource = Stock.ComponentsStock;
            }
        }

        /// <summary>
        /// Add the quantity requested by the user to the stock of components.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddComponents_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Components)this.dgvComponents.CurrentRow.DataBoundItem + (int)this.nudCountComponents.Value)
                {
                    this.dgvComponents.DataSource = null;
                    this.dgvComponents.DataSource = Stock.ComponentsStock;
                    Stock.SaveComponents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NO SAVE COMPONENTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
