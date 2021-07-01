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
using System.IO;
using LoginOperators;

namespace FrmCore
{
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// Builder default.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load form default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            SetTextBox();
            try
            {
                Operator.ReadOperator();
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Operator database not found. You must be logged in as an administrator", "ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Login.LoadAdministrator();
                Operator.SaveOperator();
                Operator.SaveErrorLogOperator(ex.Message + " " + DateTime.Now);
            }
        }

        /// <summary>
        /// Validation User.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ValidateUser();
        }

        /// <summary>
        /// Close form default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go out?", "EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                this.Show();
            }
        }

        /// <summary>
        /// Texbox configurations.
        /// </summary>
        private void SetTextBox()
        {
            this.tbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Italic);
            this.tbxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Italic);
            this.tbxPass.UseSystemPasswordChar = false;
            this.tbxUser.Text = "Operator";
            this.tbxPass.Text = "Password";
        }

        /// <summary>
        /// Validate the user.
        /// </summary>
        private void ValidateUser()
        {
            bool invalidUser = true;
            if (int.TryParse(tbxUser.Text, out int user) && int.TryParse(tbxPass.Text, out int pass))
            {
                if (Login.LogIn(user, pass))
                {
                    invalidUser = false;
                    FrmProduction production = new FrmProduction();
                    this.Hide();
                    SetTextBox();                    
                    DialogResult dialogResult = production.ShowDialog();
                    if (DialogResult.Abort == dialogResult)
                    {
                        this.Dispose();
                    }
                    else if (DialogResult.Cancel == dialogResult)
                    {
                        SetTextBox();
                        this.Show();
                    }
                }
            }
            if (invalidUser)
            {
                MessageBox.Show("Incorrect operator number or password", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clean the textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxUser_Click(object sender, EventArgs e)
        {
            this.tbxUser.Text = "";
        }

        /// <summary>
        /// Clean the textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPass_Click(object sender, EventArgs e)
        {
            this.tbxPass.Text = "";
        }

        /// <summary>
        /// Change the style of the grace font.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxUser_TextChanged(object sender, EventArgs e)
        {
            this.tbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular);
        }

        /// <summary>
        /// Change the style of the grace font and hide the characters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPass_TextChanged(object sender, EventArgs e)
        {
            this.tbxPass.UseSystemPasswordChar = true;
            this.tbxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular);
        }

        /// <summary>
        /// Shows all operators with their data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llbPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Login.View(), "USER INFO", MessageBoxButtons.OK);
        }
    }
}

