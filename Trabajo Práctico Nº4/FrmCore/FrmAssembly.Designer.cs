
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssembly));
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnAccessControl = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnPanelAccess = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.pnlAC = new System.Windows.Forms.Panel();
            this.btnFingerAC = new System.Windows.Forms.Button();
            this.btnFaceAC = new System.Windows.Forms.Button();
            this.pnlAT = new System.Windows.Forms.Panel();
            this.btnFingerAT = new System.Windows.Forms.Button();
            this.btnFaceAT = new System.Windows.Forms.Button();
            this.pnlPA = new System.Windows.Forms.Panel();
            this.btnRFIDPA = new System.Windows.Forms.Button();
            this.btnFingerRFIDPA = new System.Windows.Forms.Button();
            this.btnViewListDevice = new System.Windows.Forms.Button();
            this.lblSerialNumberText = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.lblErrorList = new System.Windows.Forms.Label();
            this.pgbStatusOrder = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.pnlAC.SuspendLayout();
            this.pnlAT.SuspendLayout();
            this.pnlPA.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.Location = new System.Drawing.Point(60, 21);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(643, 45);
            this.dgvOrder.TabIndex = 2;
            // 
            // btnAccessControl
            // 
            this.btnAccessControl.AccessibleName = "";
            this.btnAccessControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccessControl.BackColor = System.Drawing.Color.Transparent;
            this.btnAccessControl.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAccessControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnAccessControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnAccessControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessControl.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAccessControl.Location = new System.Drawing.Point(0, 0);
            this.btnAccessControl.Name = "btnAccessControl";
            this.btnAccessControl.Size = new System.Drawing.Size(215, 29);
            this.btnAccessControl.TabIndex = 5;
            this.btnAccessControl.Text = "Access Control";
            this.btnAccessControl.UseVisualStyleBackColor = false;
            this.btnAccessControl.Click += new System.EventHandler(this.btnAccessControl_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.btnPanelAccess);
            this.pnlButton.Controls.Add(this.btnAttendance);
            this.pnlButton.Controls.Add(this.btnAccessControl);
            this.pnlButton.Location = new System.Drawing.Point(60, 72);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(656, 29);
            this.pnlButton.TabIndex = 6;
            // 
            // btnPanelAccess
            // 
            this.btnPanelAccess.AccessibleName = "";
            this.btnPanelAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanelAccess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPanelAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnPanelAccess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPanelAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnPanelAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnPanelAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelAccess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPanelAccess.Location = new System.Drawing.Point(430, 0);
            this.btnPanelAccess.Name = "btnPanelAccess";
            this.btnPanelAccess.Size = new System.Drawing.Size(213, 29);
            this.btnPanelAccess.TabIndex = 7;
            this.btnPanelAccess.Text = "Panel Access";
            this.btnPanelAccess.UseVisualStyleBackColor = false;
            this.btnPanelAccess.Click += new System.EventHandler(this.btnPanelAccess_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.AccessibleName = "";
            this.btnAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAttendance.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAttendance.Location = new System.Drawing.Point(215, 0);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(215, 29);
            this.btnAttendance.TabIndex = 6;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.AllowUserToResizeColumns = false;
            this.dgvPreview.AllowUserToResizeRows = false;
            this.dgvPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPreview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreview.Location = new System.Drawing.Point(60, 297);
            this.dgvPreview.MultiSelect = false;
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.ReadOnly = true;
            this.dgvPreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreview.Size = new System.Drawing.Size(643, 149);
            this.dgvPreview.TabIndex = 2;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDevice.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddDevice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddDevice.FlatAppearance.BorderSize = 0;
            this.btnAddDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btnAddDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddDevice.Location = new System.Drawing.Point(60, 218);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(643, 29);
            this.btnAddDevice.TabIndex = 3;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = false;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUpload.Location = new System.Drawing.Point(60, 486);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(643, 30);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload List";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDevice.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveDevice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoveDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.btnRemoveDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRemoveDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDevice.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDevice.Location = new System.Drawing.Point(60, 451);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(643, 30);
            this.btnRemoveDevice.TabIndex = 3;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = false;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // pnlAC
            // 
            this.pnlAC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAC.BackColor = System.Drawing.Color.Transparent;
            this.pnlAC.Controls.Add(this.btnFingerAC);
            this.pnlAC.Controls.Add(this.btnFaceAC);
            this.pnlAC.Location = new System.Drawing.Point(60, 108);
            this.pnlAC.Name = "pnlAC";
            this.pnlAC.Size = new System.Drawing.Size(213, 29);
            this.pnlAC.TabIndex = 6;
            // 
            // btnFingerAC
            // 
            this.btnFingerAC.AccessibleName = "";
            this.btnFingerAC.BackColor = System.Drawing.Color.Transparent;
            this.btnFingerAC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFingerAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnFingerAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnFingerAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFingerAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFingerAC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFingerAC.Location = new System.Drawing.Point(107, 0);
            this.btnFingerAC.Name = "btnFingerAC";
            this.btnFingerAC.Size = new System.Drawing.Size(106, 29);
            this.btnFingerAC.TabIndex = 8;
            this.btnFingerAC.Text = "Finger ID";
            this.btnFingerAC.UseVisualStyleBackColor = false;
            this.btnFingerAC.Click += new System.EventHandler(this.btnFingerAC_Click);
            // 
            // btnFaceAC
            // 
            this.btnFaceAC.AccessibleName = "";
            this.btnFaceAC.BackColor = System.Drawing.Color.Transparent;
            this.btnFaceAC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFaceAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnFaceAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnFaceAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaceAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaceAC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFaceAC.Location = new System.Drawing.Point(0, 0);
            this.btnFaceAC.Name = "btnFaceAC";
            this.btnFaceAC.Size = new System.Drawing.Size(107, 29);
            this.btnFaceAC.TabIndex = 7;
            this.btnFaceAC.Text = "Face ID";
            this.btnFaceAC.UseVisualStyleBackColor = false;
            this.btnFaceAC.Click += new System.EventHandler(this.btnFaceAC_Click);
            // 
            // pnlAT
            // 
            this.pnlAT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAT.BackColor = System.Drawing.Color.Transparent;
            this.pnlAT.Controls.Add(this.btnFingerAT);
            this.pnlAT.Controls.Add(this.btnFaceAT);
            this.pnlAT.Location = new System.Drawing.Point(275, 108);
            this.pnlAT.Name = "pnlAT";
            this.pnlAT.Size = new System.Drawing.Size(213, 29);
            this.pnlAT.TabIndex = 6;
            // 
            // btnFingerAT
            // 
            this.btnFingerAT.AccessibleName = "";
            this.btnFingerAT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFingerAT.BackColor = System.Drawing.Color.Transparent;
            this.btnFingerAT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFingerAT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnFingerAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnFingerAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFingerAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFingerAT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFingerAT.Location = new System.Drawing.Point(107, 0);
            this.btnFingerAT.Name = "btnFingerAT";
            this.btnFingerAT.Size = new System.Drawing.Size(106, 29);
            this.btnFingerAT.TabIndex = 8;
            this.btnFingerAT.Text = "Finger ID";
            this.btnFingerAT.UseVisualStyleBackColor = false;
            this.btnFingerAT.Click += new System.EventHandler(this.btnFingerAT_Click);
            // 
            // btnFaceAT
            // 
            this.btnFaceAT.AccessibleName = "";
            this.btnFaceAT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFaceAT.BackColor = System.Drawing.Color.Transparent;
            this.btnFaceAT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFaceAT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnFaceAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnFaceAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaceAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaceAT.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFaceAT.Location = new System.Drawing.Point(0, 0);
            this.btnFaceAT.Name = "btnFaceAT";
            this.btnFaceAT.Size = new System.Drawing.Size(107, 29);
            this.btnFaceAT.TabIndex = 7;
            this.btnFaceAT.Text = "Face ID";
            this.btnFaceAT.UseVisualStyleBackColor = false;
            this.btnFaceAT.Click += new System.EventHandler(this.btnFaceAT_Click);
            // 
            // pnlPA
            // 
            this.pnlPA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPA.BackColor = System.Drawing.Color.Transparent;
            this.pnlPA.Controls.Add(this.btnRFIDPA);
            this.pnlPA.Controls.Add(this.btnFingerRFIDPA);
            this.pnlPA.Location = new System.Drawing.Point(490, 108);
            this.pnlPA.Name = "pnlPA";
            this.pnlPA.Size = new System.Drawing.Size(213, 29);
            this.pnlPA.TabIndex = 6;
            // 
            // btnRFIDPA
            // 
            this.btnRFIDPA.AccessibleName = "";
            this.btnRFIDPA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRFIDPA.BackColor = System.Drawing.Color.Transparent;
            this.btnRFIDPA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRFIDPA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnRFIDPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnRFIDPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRFIDPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRFIDPA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRFIDPA.Location = new System.Drawing.Point(107, 0);
            this.btnRFIDPA.Name = "btnRFIDPA";
            this.btnRFIDPA.Size = new System.Drawing.Size(106, 29);
            this.btnRFIDPA.TabIndex = 8;
            this.btnRFIDPA.Text = "RFID";
            this.btnRFIDPA.UseVisualStyleBackColor = false;
            this.btnRFIDPA.Click += new System.EventHandler(this.btnRFIDPA_Click);
            // 
            // btnFingerRFIDPA
            // 
            this.btnFingerRFIDPA.AccessibleName = "";
            this.btnFingerRFIDPA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFingerRFIDPA.BackColor = System.Drawing.Color.Transparent;
            this.btnFingerRFIDPA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFingerRFIDPA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnFingerRFIDPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnFingerRFIDPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFingerRFIDPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFingerRFIDPA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFingerRFIDPA.Location = new System.Drawing.Point(0, 0);
            this.btnFingerRFIDPA.Name = "btnFingerRFIDPA";
            this.btnFingerRFIDPA.Size = new System.Drawing.Size(107, 29);
            this.btnFingerRFIDPA.TabIndex = 7;
            this.btnFingerRFIDPA.Text = "Finger RFID";
            this.btnFingerRFIDPA.UseVisualStyleBackColor = false;
            this.btnFingerRFIDPA.Click += new System.EventHandler(this.btnFingerRFIDPA_Click);
            // 
            // btnViewListDevice
            // 
            this.btnViewListDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewListDevice.BackColor = System.Drawing.Color.Transparent;
            this.btnViewListDevice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewListDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(6)))), ((int)(((byte)(119)))));
            this.btnViewListDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(4)))), ((int)(((byte)(155)))));
            this.btnViewListDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewListDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewListDevice.ForeColor = System.Drawing.Color.White;
            this.btnViewListDevice.Location = new System.Drawing.Point(60, 183);
            this.btnViewListDevice.Name = "btnViewListDevice";
            this.btnViewListDevice.Size = new System.Drawing.Size(643, 29);
            this.btnViewListDevice.TabIndex = 3;
            this.btnViewListDevice.Text = "View List Components";
            this.btnViewListDevice.UseVisualStyleBackColor = false;
            this.btnViewListDevice.Click += new System.EventHandler(this.btnViewListDevice_Click);
            // 
            // lblSerialNumberText
            // 
            this.lblSerialNumberText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSerialNumberText.AutoSize = true;
            this.lblSerialNumberText.BackColor = System.Drawing.Color.DimGray;
            this.lblSerialNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumberText.ForeColor = System.Drawing.Color.White;
            this.lblSerialNumberText.Location = new System.Drawing.Point(191, 154);
            this.lblSerialNumberText.Name = "lblSerialNumberText";
            this.lblSerialNumberText.Size = new System.Drawing.Size(97, 16);
            this.lblSerialNumberText.TabIndex = 0;
            this.lblSerialNumberText.Text = "Serial Number:";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSerialNumber.AutoEllipsis = true;
            this.lblSerialNumber.BackColor = System.Drawing.Color.DimGray;
            this.lblSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.ForeColor = System.Drawing.Color.White;
            this.lblSerialNumber.Location = new System.Drawing.Point(169, 151);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblSerialNumber.Size = new System.Drawing.Size(428, 22);
            this.lblSerialNumber.TabIndex = 7;
            this.lblSerialNumber.Text = "--";
            this.lblSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblErrorList
            // 
            this.lblErrorList.AutoSize = true;
            this.lblErrorList.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorList.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorList.Location = new System.Drawing.Point(60, 252);
            this.lblErrorList.Name = "lblErrorList";
            this.lblErrorList.Size = new System.Drawing.Size(98, 13);
            this.lblErrorList.TabIndex = 8;
            this.lblErrorList.Text = "Error to charged list";
            // 
            // pgbStatusOrder
            // 
            this.pgbStatusOrder.BackColor = System.Drawing.Color.DimGray;
            this.pgbStatusOrder.ForeColor = System.Drawing.Color.Indigo;
            this.pgbStatusOrder.Location = new System.Drawing.Point(60, 268);
            this.pgbStatusOrder.Name = "pgbStatusOrder";
            this.pgbStatusOrder.Size = new System.Drawing.Size(643, 23);
            this.pgbStatusOrder.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbStatusOrder.TabIndex = 9;
            // 
            // FrmAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.pgbStatusOrder);
            this.Controls.Add(this.lblErrorList);
            this.Controls.Add(this.lblSerialNumberText);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.btnRemoveDevice);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnViewListDevice);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.pnlPA);
            this.Controls.Add(this.pnlAT);
            this.Controls.Add(this.pnlAC);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.dgvPreview);
            this.Controls.Add(this.dgvOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAssembly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmAssembly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.pnlAC.ResumeLayout(false);
            this.pnlAT.ResumeLayout(false);
            this.pnlPA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnAccessControl;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnPanelAccess;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.Panel pnlAC;
        private System.Windows.Forms.Button btnFingerAC;
        private System.Windows.Forms.Button btnFaceAC;
        private System.Windows.Forms.Panel pnlAT;
        private System.Windows.Forms.Button btnFingerAT;
        private System.Windows.Forms.Button btnFaceAT;
        private System.Windows.Forms.Panel pnlPA;
        private System.Windows.Forms.Button btnRFIDPA;
        private System.Windows.Forms.Button btnFingerRFIDPA;
        private System.Windows.Forms.Button btnViewListDevice;
        private System.Windows.Forms.Label lblSerialNumberText;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label lblErrorList;
        private System.Windows.Forms.ProgressBar pgbStatusOrder;
    }
}