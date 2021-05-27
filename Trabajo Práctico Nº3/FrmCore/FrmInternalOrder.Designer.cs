
namespace FrmCore
{
    partial class FrmInternalOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInternalOrder));
            this.iltSwitch01 = new System.Windows.Forms.ImageList(this.components);
            this.dgvInternalOrder = new System.Windows.Forms.DataGridView();
            this.btnAceptOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternalOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // iltSwitch01
            // 
            this.iltSwitch01.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iltSwitch01.ImageStream")));
            this.iltSwitch01.TransparentColor = System.Drawing.Color.Transparent;
            this.iltSwitch01.Images.SetKeyName(0, "TP3_ASSEMBLY_Switch_02.png");
            this.iltSwitch01.Images.SetKeyName(1, "TP3_ASSEMBLY_Switch_01.png");
            // 
            // dgvInternalOrder
            // 
            this.dgvInternalOrder.AllowUserToAddRows = false;
            this.dgvInternalOrder.AllowUserToDeleteRows = false;
            this.dgvInternalOrder.AllowUserToOrderColumns = true;
            this.dgvInternalOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInternalOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternalOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInternalOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternalOrder.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvInternalOrder.Location = new System.Drawing.Point(92, 71);
            this.dgvInternalOrder.Name = "dgvInternalOrder";
            this.dgvInternalOrder.ReadOnly = true;
            this.dgvInternalOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvInternalOrder.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvInternalOrder.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternalOrder.RowTemplate.ReadOnly = true;
            this.dgvInternalOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternalOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternalOrder.Size = new System.Drawing.Size(568, 304);
            this.dgvInternalOrder.TabIndex = 4;
            // 
            // btnAceptOrder
            // 
            this.btnAceptOrder.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAceptOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAceptOrder.FlatAppearance.BorderSize = 0;
            this.btnAceptOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.btnAceptOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnAceptOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAceptOrder.Location = new System.Drawing.Point(92, 407);
            this.btnAceptOrder.Name = "btnAceptOrder";
            this.btnAceptOrder.Size = new System.Drawing.Size(568, 38);
            this.btnAceptOrder.TabIndex = 5;
            this.btnAceptOrder.Text = "&Accept Order";
            this.btnAceptOrder.UseVisualStyleBackColor = false;
            // 
            // FrmInternalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 519);
            this.Controls.Add(this.btnAceptOrder);
            this.Controls.Add(this.dgvInternalOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInternalOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmInternalOrder";
            this.Load += new System.EventHandler(this.FrmInternalOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternalOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList iltSwitch01;
        private System.Windows.Forms.DataGridView dgvInternalOrder;
        private System.Windows.Forms.Button btnAceptOrder;
    }
}