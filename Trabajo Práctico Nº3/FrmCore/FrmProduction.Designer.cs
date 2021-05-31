
namespace FrmCore
{
    partial class FrmProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduction));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlSubMenuStock = new System.Windows.Forms.Panel();
            this.btnDevices = new System.Windows.Forms.Button();
            this.btnComponents = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.pnlSubMenuOptions = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOptionSignOff = new System.Windows.Forms.Button();
            this.btnOptionExit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnAssembly = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlConnected = new System.Windows.Forms.Panel();
            this.pnlTitliOperator = new System.Windows.Forms.Panel();
            this.lblTitleOperator = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu.SuspendLayout();
            this.pnlSubMenuStock.SuspendLayout();
            this.pnlSubMenuOptions.SuspendLayout();
            this.pnlTitliOperator.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSideMenu.Controls.Add(this.pnlSubMenuStock);
            this.pnlSideMenu.Controls.Add(this.btnStock);
            this.pnlSideMenu.Controls.Add(this.pnlSubMenuOptions);
            this.pnlSideMenu.Controls.Add(this.btnOptions);
            this.pnlSideMenu.Controls.Add(this.btnAssembly);
            this.pnlSideMenu.Controls.Add(this.btnOrder);
            this.pnlSideMenu.Controls.Add(this.pnlConnected);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(229, 561);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlSubMenuStock
            // 
            this.pnlSubMenuStock.Controls.Add(this.btnDevices);
            this.pnlSubMenuStock.Controls.Add(this.btnComponents);
            this.pnlSubMenuStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuStock.Location = new System.Drawing.Point(0, 332);
            this.pnlSubMenuStock.Name = "pnlSubMenuStock";
            this.pnlSubMenuStock.Size = new System.Drawing.Size(229, 77);
            this.pnlSubMenuStock.TabIndex = 6;
            this.pnlSubMenuStock.Visible = false;
            // 
            // btnDevices
            // 
            this.btnDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevices.FlatAppearance.BorderSize = 0;
            this.btnDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevices.ForeColor = System.Drawing.Color.Gray;
            this.btnDevices.Location = new System.Drawing.Point(0, 31);
            this.btnDevices.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.btnDevices.Name = "btnDevices";
            this.btnDevices.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDevices.Size = new System.Drawing.Size(229, 31);
            this.btnDevices.TabIndex = 4;
            this.btnDevices.Text = "Devices";
            this.btnDevices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevices.UseVisualStyleBackColor = false;
            this.btnDevices.Click += new System.EventHandler(this.btnDevices_Click);
            // 
            // btnComponents
            // 
            this.btnComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComponents.FlatAppearance.BorderSize = 0;
            this.btnComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComponents.ForeColor = System.Drawing.Color.Gray;
            this.btnComponents.Location = new System.Drawing.Point(0, 0);
            this.btnComponents.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.btnComponents.Name = "btnComponents";
            this.btnComponents.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnComponents.Size = new System.Drawing.Size(229, 31);
            this.btnComponents.TabIndex = 3;
            this.btnComponents.Text = "Components";
            this.btnComponents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComponents.UseVisualStyleBackColor = false;
            this.btnComponents.Click += new System.EventHandler(this.btnComponents_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.Silver;
            this.btnStock.Location = new System.Drawing.Point(0, 289);
            this.btnStock.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(229, 43);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            this.btnStock.MouseLeave += new System.EventHandler(this.btnStock_MouseLeave);
            this.btnStock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnStock_MouseMove);
            // 
            // pnlSubMenuOptions
            // 
            this.pnlSubMenuOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnlSubMenuOptions.Controls.Add(this.button1);
            this.pnlSubMenuOptions.Controls.Add(this.btnOptionSignOff);
            this.pnlSubMenuOptions.Controls.Add(this.btnOptionExit);
            this.pnlSubMenuOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSubMenuOptions.Location = new System.Drawing.Point(0, 411);
            this.pnlSubMenuOptions.Name = "pnlSubMenuOptions";
            this.pnlSubMenuOptions.Size = new System.Drawing.Size(229, 107);
            this.pnlSubMenuOptions.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(0, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(229, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "About";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOptionSignOff
            // 
            this.btnOptionSignOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnOptionSignOff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOptionSignOff.FlatAppearance.BorderSize = 0;
            this.btnOptionSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionSignOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionSignOff.ForeColor = System.Drawing.Color.Gray;
            this.btnOptionSignOff.Location = new System.Drawing.Point(0, 45);
            this.btnOptionSignOff.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.btnOptionSignOff.Name = "btnOptionSignOff";
            this.btnOptionSignOff.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnOptionSignOff.Size = new System.Drawing.Size(229, 31);
            this.btnOptionSignOff.TabIndex = 1;
            this.btnOptionSignOff.Text = "Sign Off";
            this.btnOptionSignOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionSignOff.UseVisualStyleBackColor = false;
            this.btnOptionSignOff.Click += new System.EventHandler(this.btnOptionSignOff_Click);
            // 
            // btnOptionExit
            // 
            this.btnOptionExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnOptionExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOptionExit.FlatAppearance.BorderSize = 0;
            this.btnOptionExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionExit.ForeColor = System.Drawing.Color.Gray;
            this.btnOptionExit.Location = new System.Drawing.Point(0, 76);
            this.btnOptionExit.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.btnOptionExit.Name = "btnOptionExit";
            this.btnOptionExit.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnOptionExit.Size = new System.Drawing.Size(229, 31);
            this.btnOptionExit.TabIndex = 0;
            this.btnOptionExit.Text = "Exit";
            this.btnOptionExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptionExit.UseVisualStyleBackColor = false;
            this.btnOptionExit.Click += new System.EventHandler(this.btnOptionExit_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.Silver;
            this.btnOptions.Location = new System.Drawing.Point(0, 518);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOptions.Size = new System.Drawing.Size(229, 43);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "End";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            this.btnOptions.MouseLeave += new System.EventHandler(this.btnOptions_MouseLeave);
            this.btnOptions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOptions_MouseMove);
            // 
            // btnAssembly
            // 
            this.btnAssembly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAssembly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssembly.FlatAppearance.BorderSize = 0;
            this.btnAssembly.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.btnAssembly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.btnAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssembly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssembly.ForeColor = System.Drawing.Color.Silver;
            this.btnAssembly.Location = new System.Drawing.Point(0, 246);
            this.btnAssembly.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btnAssembly.Name = "btnAssembly";
            this.btnAssembly.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAssembly.Size = new System.Drawing.Size(229, 43);
            this.btnAssembly.TabIndex = 3;
            this.btnAssembly.Text = "Assembly";
            this.btnAssembly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssembly.UseVisualStyleBackColor = false;
            this.btnAssembly.Click += new System.EventHandler(this.btnAssembly_Click);
            this.btnAssembly.MouseLeave += new System.EventHandler(this.btnAssembly_MouseLeave);
            this.btnAssembly.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAssembly_MouseMove);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(71)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Silver;
            this.btnOrder.Location = new System.Drawing.Point(0, 203);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(229, 43);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            this.btnOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOrder_MouseMove);
            // 
            // pnlConnected
            // 
            this.pnlConnected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlConnected.BackgroundImage")));
            this.pnlConnected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlConnected.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnected.Location = new System.Drawing.Point(0, 0);
            this.pnlConnected.Name = "pnlConnected";
            this.pnlConnected.Size = new System.Drawing.Size(229, 203);
            this.pnlConnected.TabIndex = 1;
            // 
            // pnlTitliOperator
            // 
            this.pnlTitliOperator.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitliOperator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitliOperator.BackgroundImage")));
            this.pnlTitliOperator.Controls.Add(this.lblTitleOperator);
            this.pnlTitliOperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitliOperator.Location = new System.Drawing.Point(229, 0);
            this.pnlTitliOperator.Name = "pnlTitliOperator";
            this.pnlTitliOperator.Size = new System.Drawing.Size(774, 32);
            this.pnlTitliOperator.TabIndex = 1;
            // 
            // lblTitleOperator
            // 
            this.lblTitleOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleOperator.AutoEllipsis = true;
            this.lblTitleOperator.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOperator.ForeColor = System.Drawing.Color.White;
            this.lblTitleOperator.Location = new System.Drawing.Point(388, 8);
            this.lblTitleOperator.Name = "lblTitleOperator";
            this.lblTitleOperator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleOperator.Size = new System.Drawing.Size(380, 16);
            this.lblTitleOperator.TabIndex = 0;
            this.lblTitleOperator.Text = "Name Operador";
            this.lblTitleOperator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.Transparent;
            this.pnlCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCenter.BackgroundImage")));
            this.pnlCenter.Controls.Add(this.ptbLogo);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(229, 32);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(774, 529);
            this.pnlCenter.TabIndex = 2;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbLogo.BackgroundImage")));
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLogo.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(774, 529);
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // FrmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1003, 561);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTitliOperator);
            this.Controls.Add(this.pnlSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONNECTED - Production";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProduction_FormClosing);
            this.Load += new System.EventHandler(this.FrmProduction_Load);
            this.BackColorChanged += new System.EventHandler(this.FrmProduction_BackColorChanged);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSubMenuStock.ResumeLayout(false);
            this.pnlSubMenuOptions.ResumeLayout(false);
            this.pnlTitliOperator.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnAssembly;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnlConnected;
        private System.Windows.Forms.Panel pnlSubMenuOptions;
        private System.Windows.Forms.Button btnOptionSignOff;
        private System.Windows.Forms.Button btnOptionExit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel pnlTitliOperator;
        private System.Windows.Forms.Label lblTitleOperator;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlSubMenuStock;
        private System.Windows.Forms.Button btnDevices;
        private System.Windows.Forms.Button btnComponents;
    }
}