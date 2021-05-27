
namespace FrmCore
{
    partial class FrmAssembly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssembly));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.btnP = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.NumberOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETypeDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Black;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "FingerPrint",
            "Display",
            "Module Relay",
            "Spiral RFID",
            "Module Temperature",
            "Camera FaceID"});
            this.checkedListBox1.Location = new System.Drawing.Point(150, 351);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(175, 126);
            this.checkedListBox1.TabIndex = 0;
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "TP3_Switch_03.png");
            this.imlButton.Images.SetKeyName(1, "TP3_Switch_04.png");
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatAppearance.BorderSize = 0;
            this.btnP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.ImageIndex = 1;
            this.btnP.ImageList = this.imlButton;
            this.btnP.Location = new System.Drawing.Point(277, 315);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(101, 87);
            this.btnP.TabIndex = 1;
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOrder,
            this.NameDevice,
            this.ETypeDevice,
            this.CountDevice});
            this.dgvOrder.Location = new System.Drawing.Point(74, 55);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(647, 45);
            this.dgvOrder.TabIndex = 2;
            // 
            // NumberOrder
            // 
            this.NumberOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberOrder.HeaderText = "NumberOrder";
            this.NumberOrder.Name = "NumberOrder";
            this.NumberOrder.ReadOnly = true;
            this.NumberOrder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NameDevice
            // 
            this.NameDevice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameDevice.HeaderText = "NameDevice";
            this.NameDevice.Name = "NameDevice";
            this.NameDevice.ReadOnly = true;
            this.NameDevice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ETypeDevice
            // 
            this.ETypeDevice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ETypeDevice.HeaderText = "ETypeDevice";
            this.ETypeDevice.Name = "ETypeDevice";
            this.ETypeDevice.ReadOnly = true;
            this.ETypeDevice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CountDevice
            // 
            this.CountDevice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CountDevice.HeaderText = "CountDevice";
            this.CountDevice.Name = "CountDevice";
            this.CountDevice.ReadOnly = true;
            this.CountDevice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleName = "";
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(215, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Access Control";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.button2);
            this.pnlButton.Controls.Add(this.button1);
            this.pnlButton.Controls.Add(this.btnExit);
            this.pnlButton.Location = new System.Drawing.Point(74, 116);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(656, 32);
            this.pnlButton.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.AccessibleName = "";
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(215, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Attendance";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AccessibleName = "";
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(430, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Panel Access";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(74, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 120);
            this.panel2.TabIndex = 7;
            // 
            // FrmAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 519);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAssembly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAssembly";
            this.Load += new System.EventHandler(this.FrmAssembly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ImageList imlButton;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETypeDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountDevice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}