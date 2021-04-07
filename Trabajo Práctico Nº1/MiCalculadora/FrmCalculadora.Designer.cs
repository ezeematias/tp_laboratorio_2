
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
            this.cboOperador = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumero1.Font = new System.Drawing.Font("Calibri", 30F);
            this.txtNumero1.Location = new System.Drawing.Point(20, 110);
            this.txtNumero1.Multiline = true;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(165, 53);
            this.txtNumero1.TabIndex = 1;
            // 
            // btnOperar
            // 
            this.btnOperar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnOperar.Location = new System.Drawing.Point(20, 170);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(148, 50);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "&Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumero2.Font = new System.Drawing.Font("Calibri", 30F);
            this.txtNumero2.Location = new System.Drawing.Point(299, 110);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(165, 53);
            this.txtNumero2.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnLimpiar.Location = new System.Drawing.Point(174, 170);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 50);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(316, 170);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(148, 50);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnDecimalBinario
            // 
            this.btnDecimalBinario.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnDecimalBinario.Location = new System.Drawing.Point(20, 225);
            this.btnDecimalBinario.Name = "btnDecimalBinario";
            this.btnDecimalBinario.Size = new System.Drawing.Size(216, 50);
            this.btnDecimalBinario.TabIndex = 7;
            this.btnDecimalBinario.Text = "Convertir a &Binario";
            this.btnDecimalBinario.UseVisualStyleBackColor = true;
            this.btnDecimalBinario.Click += new System.EventHandler(this.btnDecimalBinario_Click);
            // 
            // btnBinarioDecimal
            // 
            this.btnBinarioDecimal.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnBinarioDecimal.Location = new System.Drawing.Point(242, 225);
            this.btnBinarioDecimal.Name = "btnBinarioDecimal";
            this.btnBinarioDecimal.Size = new System.Drawing.Size(222, 50);
            this.btnBinarioDecimal.TabIndex = 8;
            this.btnBinarioDecimal.Text = "Convertir a &Decimal";
            this.btnBinarioDecimal.UseVisualStyleBackColor = true;
            this.btnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimal_Click);
            // 
            // cboOperador
            // 
            this.cboOperador.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.cboOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboOperador.CausesValidation = false;
            this.cboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperador.Font = new System.Drawing.Font("Calibri", 28F);
            this.cboOperador.FormattingEnabled = true;
            this.cboOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboOperador.Location = new System.Drawing.Point(191, 110);
            this.cboOperador.Name = "cboOperador";
            this.cboOperador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboOperador.Size = new System.Drawing.Size(102, 53);
            this.cboOperador.TabIndex = 2;
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
            this.Controls.Add(this.cboOperador);
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
        private System.Windows.Forms.ComboBox cboOperador;
        private System.Windows.Forms.Label lblResultado;
    }
}

