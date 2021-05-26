﻿using System;
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
    public partial class FrmLogin : Form
    {
        public static Operator op = new Operator("Ezequiel", "Unía", 8080, 8624);
        public static FrmProduction production;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ValidateUser();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go out?", "EXIT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                this.Show();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void ValidateUser()
        {
            production = new FrmProduction();

            if (int.TryParse(tbxUser.Text, out int user) && user == op.UserID && int.TryParse(tbxPass.Text, out int pass) && pass == op.Pass)
            {
                this.Hide();
                DialogResult dialogResult = production.ShowDialog();  
                if (DialogResult.Abort == dialogResult)
                {
                    this.Dispose();
                }
                else if (DialogResult.Cancel == dialogResult)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect operator number or password", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenForm()
        {
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxUser_Click(object sender, EventArgs e)
        {
            this.tbxUser.Text = "";
        }

        private void tbxPass_Click(object sender, EventArgs e)
        {
            this.tbxPass.Text = "";
        }

        private void btnSignIn_Enter(object sender, EventArgs e)
        {
            ValidateUser();
        }

        private void tbxUser_TextChanged(object sender, EventArgs e)
        {
            this.tbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular);
        }

        private void tbxPass_TextChanged(object sender, EventArgs e)
        {
            this.tbxPass.UseSystemPasswordChar = true;
            this.tbxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular);

        }
    }
}

