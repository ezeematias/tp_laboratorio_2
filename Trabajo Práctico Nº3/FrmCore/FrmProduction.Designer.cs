
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
            this.pnlSubMenuOptions = new System.Windows.Forms.Panel();
            this.btnOptionSignOff = new System.Windows.Forms.Button();
            this.btnOptionExit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnAssembly = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlSubMenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSideMenu.Controls.Add(this.pnlSubMenuOptions);
            this.pnlSideMenu.Controls.Add(this.btnOptions);
            this.pnlSideMenu.Controls.Add(this.btnAssembly);
            this.pnlSideMenu.Controls.Add(this.btnOrder);
            this.pnlSideMenu.Controls.Add(this.panel1);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(211, 591);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlSubMenuOptions
            // 
            this.pnlSubMenuOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnlSubMenuOptions.Controls.Add(this.btnOptionSignOff);
            this.pnlSubMenuOptions.Controls.Add(this.btnOptionExit);
            this.pnlSubMenuOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSubMenuOptions.Location = new System.Drawing.Point(0, 481);
            this.pnlSubMenuOptions.Name = "pnlSubMenuOptions";
            this.pnlSubMenuOptions.Size = new System.Drawing.Size(211, 67);
            this.pnlSubMenuOptions.TabIndex = 1;
            // 
            // btnOptionSignOff
            // 
            this.btnOptionSignOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnOptionSignOff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOptionSignOff.FlatAppearance.BorderSize = 0;
            this.btnOptionSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionSignOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionSignOff.ForeColor = System.Drawing.Color.Gray;
            this.btnOptionSignOff.Location = new System.Drawing.Point(0, 9);
            this.btnOptionSignOff.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.btnOptionSignOff.Name = "btnOptionSignOff";
            this.btnOptionSignOff.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOptionSignOff.Size = new System.Drawing.Size(211, 29);
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
            this.btnOptionExit.Location = new System.Drawing.Point(0, 38);
            this.btnOptionExit.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.btnOptionExit.Name = "btnOptionExit";
            this.btnOptionExit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOptionExit.Size = new System.Drawing.Size(211, 29);
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
            this.btnOptions.Location = new System.Drawing.Point(0, 548);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOptions.Size = new System.Drawing.Size(211, 43);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.UseVisualStyleBackColor = false;
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
            this.btnAssembly.Size = new System.Drawing.Size(211, 43);
            this.btnAssembly.TabIndex = 3;
            this.btnAssembly.Text = "Assembly";
            this.btnAssembly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssembly.UseVisualStyleBackColor = false;
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
            this.btnOrder.Size = new System.Drawing.Size(211, 43);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            this.btnOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOrder_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 203);
            this.panel1.TabIndex = 1;
            // 
            // FrmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 591);
            this.Controls.Add(this.pnlSideMenu);
            this.Name = "FrmProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProduction_FormClosing);
            this.Load += new System.EventHandler(this.FrmProduction_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSubMenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnAssembly;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSubMenuOptions;
        private System.Windows.Forms.Button btnOptionSignOff;
        private System.Windows.Forms.Button btnOptionExit;
        private System.Windows.Forms.Button btnOptions;
    }
}