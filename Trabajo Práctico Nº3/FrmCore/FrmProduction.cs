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

        /// <summary>
        /// Builder default.
        /// </summary>
        public FrmProduction()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        /// <summary>
        /// Load form default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProduction_Load(object sender, EventArgs e)
        {
            lblTitleOperator.Text = Login.OperatorLog.ToString();
        }

        /// <summary>
        /// Hide the sub panels.
        /// </summary>
        private void CustomizeDesing()
        {
            this.pnlSubMenuOptions.Visible = false;
            this.pnlSubMenuStock.Visible = false;
        }

        /// <summary>
        /// If the panel is active it hides it.
        /// </summary>
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

        /// <summary>
        /// Depending on the state of the panel, it shows or hides it.
        /// </summary>
        /// <param name="subMenu"></param>
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

        /// <summary>
        /// Button color format move.
        /// </summary>
        /// <param name="button">Button for format</param>
        private void ButtonFormatColorMove(Button button)
        {
            button.ForeColor = Color.MediumVioletRed;
        }

        /// <summary>
        /// Button color format leave.
        /// </summary>
        /// <param name="button">Button for format</param>
        private void ButtonFormatColorLeave(Button button)
        {
            button.ForeColor = Color.Gray;
        }


        /// <summary>
        /// Button text design when hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonFormatColorMove(this.btnOrder);
        }

        /// <summary>
        /// Button text design when hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            ButtonFormatColorLeave(this.btnOrder);
        }

        /// <summary>
        /// Button text design when hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembly_MouseLeave(object sender, EventArgs e)
        {
            ButtonFormatColorLeave(this.btnAssembly);
        }

        /// <summary>
        /// Button text design when hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembly_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonFormatColorMove(this.btnAssembly);
        }

        /// <summary>
        /// Button text design when hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptions_MouseLeave(object sender, EventArgs e)
        {
            ButtonFormatColorLeave(this.btnOptions);

        }

        /// <summary>
        /// Button text design when hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptions_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonFormatColorMove(this.btnOptions);
        }

        /// <summary>
        /// Button text design when hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_MouseLeave(object sender, EventArgs e)
        {
            ButtonFormatColorLeave(this.btnStock);
        }

        /// <summary>
        /// Button text design when hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonFormatColorMove(this.btnStock);
        }

        /// <summary>
        /// Log out the operator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptionSignOff_Click(object sender, EventArgs e)
        {
            this.aux = true;
            this.Close();
            HideSubMenu();
        }

        /// <summary>
        /// Close program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptionExit_Click(object sender, EventArgs e)
        {
            this.Close();
            HideSubMenu();
        }

        /// <summary>
        /// Merge the forms into controllers. Allowing them to be added in the central panel.
        /// </summary>
        /// <param name="childForm"></param>
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

        /// <summary>
        /// Form close defautl.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Open the button's sub menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptions_Click(object sender, EventArgs e)
        {
            ShowSubMenu(this.pnlSubMenuOptions);
        }

        /// <summary>
        /// Open the button's sub menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_Click(object sender, EventArgs e)
        {
            ShowSubMenu(this.pnlSubMenuStock);
        }

        /// <summary>
        /// Open the form inside this.form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmInternalOrder());               
        }

        /// <summary>
        /// Open the form inside this.form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembly_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAssembly());
        }


        /// <summary>
        /// Open the form inside this.form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComponents_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmComponents());
        }

        /// <summary>
        /// Open the form inside this.form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDevices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDevices());
        }

        /// <summary>
        /// Open the form inside this.form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAbout());
        }
        /// <summary>
        /// Open the form inside this.form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProduction_BackColorChanged(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAssembly());
        }

        /// <summary>
        /// Close the active form within the central panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlConnected_Click(object sender, EventArgs e)
        {
            CloseChildForm();
        }

        /// <summary>
        /// Close the active form.
        /// </summary>
        private void CloseChildForm()
        {
            if (this.activeForm != null)
            {
                this.activeForm.Close();
            }
        }
    }
}
