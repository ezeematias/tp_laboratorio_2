
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnAccessControl = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnPanelAccess = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.pnlAdditional = new System.Windows.Forms.Panel();
            this.lblAdditional = new System.Windows.Forms.Label();
            this.btnRs32 = new System.Windows.Forms.Button();
            this.imlButtonRs32 = new System.Windows.Forms.ImageList(this.components);
            this.btnTemperature = new System.Windows.Forms.Button();
            this.imlButtonTemp = new System.Windows.Forms.ImageList(this.components);
            this.btnLAdms = new System.Windows.Forms.Button();
            this.imlButtonAdms = new System.Windows.Forms.ImageList(this.components);
            this.btnWiFi = new System.Windows.Forms.Button();
            this.imlButtonWiFi = new System.Windows.Forms.ImageList(this.components);
            this.lblRs32 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblADMS = new System.Windows.Forms.Label();
            this.lblWiFi = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.pnlAdditional.SuspendLayout();
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
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(60, 22);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(647, 45);
            this.dgvOrder.TabIndex = 2;
            // 
            // btnAccessControl
            // 
            this.btnAccessControl.AccessibleName = "";
            this.btnAccessControl.BackColor = System.Drawing.Color.Transparent;
            this.btnAccessControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccessControl.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAccessControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAccessControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.btnPanelAccess);
            this.pnlButton.Controls.Add(this.btnAttendance);
            this.pnlButton.Controls.Add(this.btnAccessControl);
            this.pnlButton.Location = new System.Drawing.Point(60, 73);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(656, 29);
            this.pnlButton.TabIndex = 6;
            // 
            // btnPanelAccess
            // 
            this.btnPanelAccess.AccessibleName = "";
            this.btnPanelAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnPanelAccess.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPanelAccess.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPanelAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPanelAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.btnAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAttendance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
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
            // pnlAdditional
            // 
            this.pnlAdditional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdditional.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdditional.Controls.Add(this.lblAdditional);
            this.pnlAdditional.Controls.Add(this.btnRs32);
            this.pnlAdditional.Controls.Add(this.btnTemperature);
            this.pnlAdditional.Controls.Add(this.btnLAdms);
            this.pnlAdditional.Controls.Add(this.btnWiFi);
            this.pnlAdditional.Controls.Add(this.lblRs32);
            this.pnlAdditional.Controls.Add(this.lblTemp);
            this.pnlAdditional.Controls.Add(this.lblADMS);
            this.pnlAdditional.Controls.Add(this.lblWiFi);
            this.pnlAdditional.Location = new System.Drawing.Point(60, 144);
            this.pnlAdditional.Name = "pnlAdditional";
            this.pnlAdditional.Size = new System.Drawing.Size(645, 41);
            this.pnlAdditional.TabIndex = 7;
            // 
            // lblAdditional
            // 
            this.lblAdditional.AutoSize = true;
            this.lblAdditional.BackColor = System.Drawing.Color.Transparent;
            this.lblAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditional.ForeColor = System.Drawing.Color.White;
            this.lblAdditional.Location = new System.Drawing.Point(3, 0);
            this.lblAdditional.Name = "lblAdditional";
            this.lblAdditional.Size = new System.Drawing.Size(61, 15);
            this.lblAdditional.TabIndex = 9;
            this.lblAdditional.Text = "Additional";
            // 
            // btnRs32
            // 
            this.btnRs32.BackColor = System.Drawing.Color.Transparent;
            this.btnRs32.FlatAppearance.BorderSize = 0;
            this.btnRs32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRs32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRs32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRs32.ImageIndex = 0;
            this.btnRs32.ImageList = this.imlButtonRs32;
            this.btnRs32.Location = new System.Drawing.Point(600, 16);
            this.btnRs32.Name = "btnRs32";
            this.btnRs32.Size = new System.Drawing.Size(40, 28);
            this.btnRs32.TabIndex = 1;
            this.btnRs32.UseVisualStyleBackColor = false;
            this.btnRs32.Click += new System.EventHandler(this.btnRs32_Click);
            // 
            // imlButtonRs32
            // 
            this.imlButtonRs32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButtonRs32.ImageStream")));
            this.imlButtonRs32.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButtonRs32.Images.SetKeyName(0, "TP3_Switch_03.png");
            this.imlButtonRs32.Images.SetKeyName(1, "TP3_Switch_04.png");
            // 
            // btnTemperature
            // 
            this.btnTemperature.BackColor = System.Drawing.Color.Transparent;
            this.btnTemperature.FlatAppearance.BorderSize = 0;
            this.btnTemperature.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTemperature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemperature.ImageIndex = 0;
            this.btnTemperature.ImageList = this.imlButtonTemp;
            this.btnTemperature.Location = new System.Drawing.Point(422, 16);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(41, 28);
            this.btnTemperature.TabIndex = 1;
            this.btnTemperature.UseVisualStyleBackColor = false;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // imlButtonTemp
            // 
            this.imlButtonTemp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButtonTemp.ImageStream")));
            this.imlButtonTemp.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButtonTemp.Images.SetKeyName(0, "TP3_Switch_03.png");
            this.imlButtonTemp.Images.SetKeyName(1, "TP3_Switch_04.png");
            // 
            // btnLAdms
            // 
            this.btnLAdms.BackColor = System.Drawing.Color.Transparent;
            this.btnLAdms.FlatAppearance.BorderSize = 0;
            this.btnLAdms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLAdms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLAdms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLAdms.ImageIndex = 0;
            this.btnLAdms.ImageList = this.imlButtonAdms;
            this.btnLAdms.Location = new System.Drawing.Point(244, 16);
            this.btnLAdms.Name = "btnLAdms";
            this.btnLAdms.Size = new System.Drawing.Size(41, 28);
            this.btnLAdms.TabIndex = 1;
            this.btnLAdms.UseVisualStyleBackColor = false;
            this.btnLAdms.Click += new System.EventHandler(this.btnAdms_Click);
            // 
            // imlButtonAdms
            // 
            this.imlButtonAdms.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButtonAdms.ImageStream")));
            this.imlButtonAdms.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButtonAdms.Images.SetKeyName(0, "TP3_Switch_03.png");
            this.imlButtonAdms.Images.SetKeyName(1, "TP3_Switch_04.png");
            // 
            // btnWiFi
            // 
            this.btnWiFi.BackColor = System.Drawing.Color.Transparent;
            this.btnWiFi.FlatAppearance.BorderSize = 0;
            this.btnWiFi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWiFi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWiFi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWiFi.ImageIndex = 0;
            this.btnWiFi.ImageList = this.imlButtonWiFi;
            this.btnWiFi.Location = new System.Drawing.Point(66, 16);
            this.btnWiFi.Name = "btnWiFi";
            this.btnWiFi.Size = new System.Drawing.Size(41, 28);
            this.btnWiFi.TabIndex = 1;
            this.btnWiFi.UseVisualStyleBackColor = false;
            this.btnWiFi.Click += new System.EventHandler(this.btnWiFi_Click);
            // 
            // imlButtonWiFi
            // 
            this.imlButtonWiFi.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButtonWiFi.ImageStream")));
            this.imlButtonWiFi.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButtonWiFi.Images.SetKeyName(0, "TP3_Switch_03.png");
            this.imlButtonWiFi.Images.SetKeyName(1, "TP3_Switch_04.png");
            // 
            // lblRs32
            // 
            this.lblRs32.AutoSize = true;
            this.lblRs32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRs32.ForeColor = System.Drawing.Color.White;
            this.lblRs32.Location = new System.Drawing.Point(526, 22);
            this.lblRs32.Name = "lblRs32";
            this.lblRs32.Size = new System.Drawing.Size(45, 16);
            this.lblRs32.TabIndex = 0;
            this.lblRs32.Text = "RS32";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(350, 22);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(48, 16);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Temp";
            // 
            // lblADMS
            // 
            this.lblADMS.AutoSize = true;
            this.lblADMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADMS.ForeColor = System.Drawing.Color.White;
            this.lblADMS.Location = new System.Drawing.Point(173, 22);
            this.lblADMS.Name = "lblADMS";
            this.lblADMS.Size = new System.Drawing.Size(51, 16);
            this.lblADMS.TabIndex = 0;
            this.lblADMS.Text = "ADMS";
            // 
            // lblWiFi
            // 
            this.lblWiFi.AutoSize = true;
            this.lblWiFi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWiFi.ForeColor = System.Drawing.Color.White;
            this.lblWiFi.Location = new System.Drawing.Point(3, 22);
            this.lblWiFi.Name = "lblWiFi";
            this.lblWiFi.Size = new System.Drawing.Size(44, 16);
            this.lblWiFi.TabIndex = 0;
            this.lblWiFi.Text = "Wi-Fi";
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
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(60, 296);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.Size = new System.Drawing.Size(647, 175);
            this.dgvPreview.TabIndex = 2;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddDevice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddDevice.FlatAppearance.BorderSize = 0;
            this.btnAddDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.btnAddDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddDevice.Location = new System.Drawing.Point(285, 229);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(418, 29);
            this.btnAddDevice.TabIndex = 3;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = false;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUpload.Location = new System.Drawing.Point(60, 480);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(308, 29);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Upload List";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRemoveDevice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoveDevice.FlatAppearance.BorderSize = 0;
            this.btnRemoveDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.btnRemoveDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnRemoveDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRemoveDevice.Location = new System.Drawing.Point(399, 480);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(308, 29);
            this.btnRemoveDevice.TabIndex = 3;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = false;
            // 
            // pnlAC
            // 
            this.pnlAC.BackColor = System.Drawing.Color.Transparent;
            this.pnlAC.Controls.Add(this.btnFingerAC);
            this.pnlAC.Controls.Add(this.btnFaceAC);
            this.pnlAC.Location = new System.Drawing.Point(60, 109);
            this.pnlAC.Name = "pnlAC";
            this.pnlAC.Size = new System.Drawing.Size(213, 29);
            this.pnlAC.TabIndex = 6;
            // 
            // btnFingerAC
            // 
            this.btnFingerAC.AccessibleName = "";
            this.btnFingerAC.BackColor = System.Drawing.Color.Transparent;
            this.btnFingerAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFingerAC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFingerAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFingerAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.btnFaceAC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFaceAC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFaceAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFaceAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.pnlAT.BackColor = System.Drawing.Color.Transparent;
            this.pnlAT.Controls.Add(this.btnFingerAT);
            this.pnlAT.Controls.Add(this.btnFaceAT);
            this.pnlAT.Location = new System.Drawing.Point(275, 109);
            this.pnlAT.Name = "pnlAT";
            this.pnlAT.Size = new System.Drawing.Size(213, 29);
            this.pnlAT.TabIndex = 6;
            // 
            // btnFingerAT
            // 
            this.btnFingerAT.AccessibleName = "";
            this.btnFingerAT.BackColor = System.Drawing.Color.Transparent;
            this.btnFingerAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFingerAT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFingerAT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFingerAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.btnFaceAT.BackColor = System.Drawing.Color.Transparent;
            this.btnFaceAT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFaceAT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFaceAT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFaceAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.pnlPA.BackColor = System.Drawing.Color.Transparent;
            this.pnlPA.Controls.Add(this.btnRFIDPA);
            this.pnlPA.Controls.Add(this.btnFingerRFIDPA);
            this.pnlPA.Location = new System.Drawing.Point(490, 109);
            this.pnlPA.Name = "pnlPA";
            this.pnlPA.Size = new System.Drawing.Size(213, 29);
            this.pnlPA.TabIndex = 6;
            // 
            // btnRFIDPA
            // 
            this.btnRFIDPA.AccessibleName = "";
            this.btnRFIDPA.BackColor = System.Drawing.Color.Transparent;
            this.btnRFIDPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRFIDPA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRFIDPA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRFIDPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.btnFingerRFIDPA.BackColor = System.Drawing.Color.Transparent;
            this.btnFingerRFIDPA.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFingerRFIDPA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFingerRFIDPA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFingerRFIDPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
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
            this.btnViewListDevice.BackColor = System.Drawing.Color.AliceBlue;
            this.btnViewListDevice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewListDevice.FlatAppearance.BorderSize = 0;
            this.btnViewListDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.btnViewListDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnViewListDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewListDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewListDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnViewListDevice.Location = new System.Drawing.Point(60, 229);
            this.btnViewListDevice.Name = "btnViewListDevice";
            this.btnViewListDevice.Size = new System.Drawing.Size(223, 29);
            this.btnViewListDevice.TabIndex = 3;
            this.btnViewListDevice.Text = "View List Components";
            this.btnViewListDevice.UseVisualStyleBackColor = false;
            this.btnViewListDevice.Click += new System.EventHandler(this.btnViewListDevice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Number:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(223, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmAssembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemoveDevice);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnViewListDevice);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.pnlAdditional);
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
            this.pnlAdditional.ResumeLayout(false);
            this.pnlAdditional.PerformLayout();
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
        private System.Windows.Forms.Panel pnlAdditional;
        private System.Windows.Forms.Button btnRs32;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Button btnLAdms;
        private System.Windows.Forms.Button btnWiFi;
        private System.Windows.Forms.Label lblRs32;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblADMS;
        private System.Windows.Forms.Label lblWiFi;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.ImageList imlButtonWiFi;
        private System.Windows.Forms.ImageList imlButtonAdms;
        private System.Windows.Forms.ImageList imlButtonTemp;
        private System.Windows.Forms.ImageList imlButtonRs32;
        private System.Windows.Forms.Panel pnlAC;
        private System.Windows.Forms.Button btnFingerAC;
        private System.Windows.Forms.Button btnFaceAC;
        private System.Windows.Forms.Panel pnlAT;
        private System.Windows.Forms.Button btnFingerAT;
        private System.Windows.Forms.Button btnFaceAT;
        private System.Windows.Forms.Panel pnlPA;
        private System.Windows.Forms.Button btnRFIDPA;
        private System.Windows.Forms.Button btnFingerRFIDPA;
        private System.Windows.Forms.Label lblAdditional;
        private System.Windows.Forms.Button btnViewListDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}