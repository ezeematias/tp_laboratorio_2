
namespace MiCalculadora
{
    partial class MiCalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiCalculadora));
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDecimalBinario = new System.Windows.Forms.Button();
            this.btnBinarioDecimal = new System.Windows.Forms.Button();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumero1.Font = new System.Drawing.Font("Calibri", 28F);
            this.txtNumero1.Location = new System.Drawing.Point(20, 110);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(165, 53);
            this.txtNumero1.TabIndex = 1;
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.MintCream;
            this.btnOperar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOperar.FlatAppearance.BorderSize = 3;
            this.btnOperar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnOperar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnOperar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOperar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOperar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnOperar.Location = new System.Drawing.Point(20, 170);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(148, 50);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "&Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero2.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumero2.Font = new System.Drawing.Font("Calibri", 28F);
            this.txtNumero2.Location = new System.Drawing.Point(299, 110);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumero2.Size = new System.Drawing.Size(165, 53);
            this.txtNumero2.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MintCream;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 3;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnLimpiar.Location = new System.Drawing.Point(174, 170);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 50);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.MintCream;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatAppearance.BorderSize = 3;
            this.btnCerrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(316, 170);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(148, 50);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDecimalBinario
            // 
            this.btnDecimalBinario.BackColor = System.Drawing.Color.MintCream;
            this.btnDecimalBinario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDecimalBinario.FlatAppearance.BorderSize = 3;
            this.btnDecimalBinario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnDecimalBinario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnDecimalBinario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDecimalBinario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecimalBinario.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnDecimalBinario.Location = new System.Drawing.Point(20, 225);
            this.btnDecimalBinario.Name = "btnDecimalBinario";
            this.btnDecimalBinario.Size = new System.Drawing.Size(216, 50);
            this.btnDecimalBinario.TabIndex = 7;
            this.btnDecimalBinario.Text = "Convertir a &Binario";
            this.btnDecimalBinario.UseVisualStyleBackColor = false;
            this.btnDecimalBinario.Click += new System.EventHandler(this.btnDecimalBinario_Click);
            // 
            // btnBinarioDecimal
            // 
            this.btnBinarioDecimal.BackColor = System.Drawing.Color.MintCream;
            this.btnBinarioDecimal.CausesValidation = false;
            this.btnBinarioDecimal.Enabled = false;
            this.btnBinarioDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBinarioDecimal.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnBinarioDecimal.Location = new System.Drawing.Point(242, 225);
            this.btnBinarioDecimal.Name = "btnBinarioDecimal";
            this.btnBinarioDecimal.Size = new System.Drawing.Size(222, 50);
            this.btnBinarioDecimal.TabIndex = 8;
            this.btnBinarioDecimal.Text = "Convertir a &Decimal";
            this.btnBinarioDecimal.UseVisualStyleBackColor = false;
            this.btnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimal_Click);
            // 
            // cmbOperador
            // 
            this.cmbOperador.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.cmbOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOperador.CausesValidation = false;
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbOperador.Font = new System.Drawing.Font("Calibri", 28F);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperador.Location = new System.Drawing.Point(191, 110);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOperador.Size = new System.Drawing.Size(102, 53);
            this.cmbOperador.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.AutoEllipsis = true;
            this.lblResultado.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Calibri", 36F);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(20, 18);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(444, 68);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MiCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(483, 289);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.btnBinarioDecimal);
            this.Controls.Add(this.btnDecimalBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiCalculadora";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Ezequiel Unía del curso 2ºD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MiCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.MiCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnDecimalBinario;
        private System.Windows.Forms.Button btnBinarioDecimal;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label lblResultado;
    }
}

