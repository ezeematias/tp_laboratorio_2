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
using LoginOperators;

namespace FrmCore
{
    public partial class FrmProduction : Form
    {
        bool aux = false;
        private Form activeForm = null;

        public FrmProduction()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        private void CustomizeDesing()
        {
            this.pnlSubMenuOptions.Visible = false;
            this.pnlSubMenuStock.Visible = false;
        }

        private void HideSubMenu()
        {
            if (this.pnlSubMenuOptions.Visible)
            {
                this.pnlSubMenuOptions.Visible = false;
            }
            if (this.pnlSubMenuStock.Visible)
            {
                this.pnlSubMenuStock.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void FrmProduction_Load(object sender, EventArgs e)
        {
            lblTitleOperator.Text = Login.OperatorLog.ToString();
        }

        private void btnOrder_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnOrder.ForeColor = Color.MediumVioletRed;
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            this.btnOrder.ForeColor = Color.Gray;
        }

        private void btnAssembly_MouseLeave(object sender, EventArgs e)
        {
            this.btnAssembly.ForeColor = Color.Gray;
        }

        private void btnAssembly_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnAssembly.ForeColor = Color.MediumVioletRed;
        }

        private void btnOptions_MouseLeave(object sender, EventArgs e)
        {
            this.btnOptions.ForeColor = Color.Gray;

        }

        private void btnOptions_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnOptions.ForeColor = Color.MediumVioletRed;
        }

        private void btnOptionSignOff_Click(object sender, EventArgs e)
        {
            this.aux = true;
            this.Close();
            HideSubMenu();
        }

        private void btnOptionExit_Click(object sender, EventArgs e)
        {
            this.Close();
            HideSubMenu();
        }

        private void OpenChildForm(Form childForm)
        {
            CloseChildForm();
            this.activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlCenter.Controls.Add(childForm);
            this.pnlCenter.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void FrmProduction_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.aux)
            {
                if (MessageBox.Show("Do you want to log out?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.aux = false;
                    e.Cancel = true;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            else if (MessageBox.Show("Are you sure you want to go out?", "EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                DialogResult = DialogResult.Abort;
            }
        }

        private void btnStock_MouseLeave(object sender, EventArgs e)
        {
            this.btnStock.ForeColor = Color.Gray;
        }

        private void btnStock_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnStock.ForeColor = Color.MediumVioletRed;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            ShowSubMenu(this.pnlSubMenuOptions);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmInternalOrder());               
        }

        private void btnAssembly_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAssembly());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ShowSubMenu(this.pnlSubMenuStock);
        }

        private void btnComponents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmComponents());
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDevices());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAbout());
        }

        private void FrmProduction_BackColorChanged(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAssembly());
        }

        private void pnlConnected_Click(object sender, EventArgs e)
        {
            CloseChildForm();
        }

        private void CloseChildForm()
        {
            if (this.activeForm != null)
            {
                this.activeForm.Close();
            }
        }
    }
}
