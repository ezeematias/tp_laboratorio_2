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
using SQL;
using System.Threading;

namespace FrmCore
{
    public partial class FrmProduction : Form
    {
        Thread thread;
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
            try
            {                
                this.lblTitleOperator.Text = Login.OperatorLog.ToString();
                ButtonAssemblyFalse();
                Stock.DevicesStock = DAO.LoadDevice();
                Stock.ComponentsStock = DAO.LoadComponent();
                thread = new Thread(ThreadLogo);
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR DATA BASE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            ButtonFormatColorLeave(this.btnAbout);
        }

        /// <summary>
        /// Button text design when hovering.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonFormatColorMove(this.btnAbout);
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
                    ThreadAbort();
                }
            }
            else if (MessageBox.Show("Are you sure you want to go out?", "EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                DialogResult = DialogResult.Abort;
                ThreadAbort();
            }
        }

        /// <summary>
        /// Thread abort
        /// </summary>
        private void ThreadAbort()
        {
            if (!(thread is null) && this.thread.IsAlive)
            {
                this.thread.Abort();
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
            FrmInternalOrder internalOrder = new FrmInternalOrder();
            internalOrder.ChangeForm += this.ChangeChild;
            OpenChildForm(internalOrder);
        }

        /// <summary>
        /// Open the form inside this.form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembly_Click(object sender, EventArgs e)
        {
            FrmAssembly assembly = new FrmAssembly();
            assembly.ChangeForm += this.ChangeChildAssemble;
            OpenChildForm(assembly);
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
        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAbout());
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

        /// <summary>
        /// Button assembly appearance ans status.
        /// </summary>
        private void ButtonAssemblyFormat()
        {
            if (this.btnAssembly.Enabled == true)
            {
                this.btnAssembly.BackColor = Color.FromArgb(20, 20, 20);
            }
            else
            {
                this.btnAssembly.BackColor = Color.Transparent;
            }
        }

        /// <summary>
        /// Config. button assembly.
        /// </summary>
        private void ButtonAssemblyFalse()
        {
            btnAssembly.Enabled = false;
            ButtonAssemblyFormat();
        }

        /// <summary>
        /// Changes the active child form.
        /// </summary>
        public void ChangeChild()
        {
            this.btnAssembly.Enabled = true;
            ButtonAssemblyFormat();
            FrmAssembly assembly = new FrmAssembly();
            assembly.ChangeForm += this.ChangeChildAssemble;
            OpenChildForm(assembly);
        }

        /// <summary>
        /// Changes the active child form.
        /// </summary>
        public void ChangeChildAssemble()
        {
            CloseChildForm();
            ButtonAssemblyFalse();
        }

        /// <summary>
        /// Play logo.
        /// </summary>
        public void ThreadLogo()
        {
            do
            {
                for (int i = 1; i < 13; i++)
                {
                    this.pnlConnected.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"TP4_LOGO_Hilos_{i}");
                    System.Threading.Thread.Sleep(100);
                }
            } while (true);
        }

    }
}
