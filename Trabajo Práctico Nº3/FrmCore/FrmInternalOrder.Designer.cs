
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
            this.btnP = new System.Windows.Forms.Button();
            this.iltSwitch01 = new System.Windows.Forms.ImageList(this.components);
            this.dgvInternalOrder = new System.Windows.Forms.DataGridView();
            this.lsvInternalOrder = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternalOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnP
            // 
            this.btnP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnP.BackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnP.FlatAppearance.BorderSize = 0;
            this.btnP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.ImageIndex = 0;
            this.btnP.ImageList = this.iltSwitch01;
            this.btnP.Location = new System.Drawing.Point(479, 193);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(41, 23);
            this.btnP.TabIndex = 3;
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.button1_Click);
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
            this.dgvInternalOrder.Location = new System.Drawing.Point(107, 39);
            this.dgvInternalOrder.Name = "dgvInternalOrder";
            this.dgvInternalOrder.ReadOnly = true;
            this.dgvInternalOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvInternalOrder.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvInternalOrder.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternalOrder.RowTemplate.ReadOnly = true;
            this.dgvInternalOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternalOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternalOrder.Size = new System.Drawing.Size(413, 139);
            this.dgvInternalOrder.TabIndex = 4;
            // 
            // lsvInternalOrder
            // 
            this.lsvInternalOrder.HideSelection = false;
            this.lsvInternalOrder.Location = new System.Drawing.Point(107, 238);
            this.lsvInternalOrder.Name = "lsvInternalOrder";
            this.lsvInternalOrder.Size = new System.Drawing.Size(413, 141);
            this.lsvInternalOrder.TabIndex = 5;
            this.lsvInternalOrder.UseCompatibleStateImageBehavior = false;
            // 
            // FrmInternalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(619, 415);
            this.Controls.Add(this.lsvInternalOrder);
            this.Controls.Add(this.dgvInternalOrder);
            this.Controls.Add(this.btnP);
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
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.ImageList iltSwitch01;
        private System.Windows.Forms.DataGridView dgvInternalOrder;
        private System.Windows.Forms.ListView lsvInternalOrder;
    }
}