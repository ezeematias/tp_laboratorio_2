
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
            this.dgvInternalOrder = new System.Windows.Forms.DataGridView();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDecive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignOff = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.iltSwitch01 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternalOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInternalOrder
            // 
            this.dgvInternalOrder.AllowUserToAddRows = false;
            this.dgvInternalOrder.AllowUserToDeleteRows = false;
            this.dgvInternalOrder.AllowUserToResizeColumns = false;
            this.dgvInternalOrder.AllowUserToResizeRows = false;
            this.dgvInternalOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternalOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInternalOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.nameDecive,
            this.componentDevice,
            this.countDevice});
            this.dgvInternalOrder.Location = new System.Drawing.Point(23, 55);
            this.dgvInternalOrder.MultiSelect = false;
            this.dgvInternalOrder.Name = "dgvInternalOrder";
            this.dgvInternalOrder.ReadOnly = true;
            this.dgvInternalOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInternalOrder.ShowEditingIcon = false;
            this.dgvInternalOrder.Size = new System.Drawing.Size(424, 263);
            this.dgvInternalOrder.TabIndex = 0;
            // 
            // orderNumber
            // 
            this.orderNumber.HeaderText = "Order Nº";
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.ReadOnly = true;
            this.orderNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameDecive
            // 
            this.nameDecive.HeaderText = "Name";
            this.nameDecive.Name = "nameDecive";
            this.nameDecive.ReadOnly = true;
            this.nameDecive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // componentDevice
            // 
            this.componentDevice.HeaderText = "Components";
            this.componentDevice.Name = "componentDevice";
            this.componentDevice.ReadOnly = true;
            this.componentDevice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // countDevice
            // 
            this.countDevice.HeaderText = "Count";
            this.countDevice.Name = "countDevice";
            this.countDevice.ReadOnly = true;
            this.countDevice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignOff
            // 
            this.btnSignOff.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOff.ForeColor = System.Drawing.Color.White;
            this.btnSignOff.Location = new System.Drawing.Point(408, 4);
            this.btnSignOff.Name = "btnSignOff";
            this.btnSignOff.Size = new System.Drawing.Size(75, 23);
            this.btnSignOff.TabIndex = 2;
            this.btnSignOff.Text = "Sign off";
            this.btnSignOff.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnP.FlatAppearance.BorderSize = 0;
            this.btnP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.ImageIndex = 0;
            this.btnP.ImageList = this.iltSwitch01;
            this.btnP.Location = new System.Drawing.Point(256, 370);
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
            // FrmInternalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 530);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnSignOff);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvInternalOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInternalOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInternalOrder";
            this.Load += new System.EventHandler(this.FrmInternalOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternalOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInternalOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDecive;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDevice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSignOff;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.ImageList iltSwitch01;
        private System.Windows.Forms.Timer timer1;
    }
}