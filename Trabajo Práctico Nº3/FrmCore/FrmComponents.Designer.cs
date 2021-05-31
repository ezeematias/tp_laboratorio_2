
namespace FrmCore
{
    partial class FrmComponents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComponents));
            this.dgvComponents = new System.Windows.Forms.DataGridView();
            this.btnAddComponents = new System.Windows.Forms.Button();
            this.nudCountComponents = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComponents
            // 
            this.dgvComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponents.Location = new System.Drawing.Point(201, 30);
            this.dgvComponents.Name = "dgvComponents";
            this.dgvComponents.Size = new System.Drawing.Size(330, 369);
            this.dgvComponents.TabIndex = 0;
            // 
            // btnAddComponents
            // 
            this.btnAddComponents.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddComponents.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddComponents.FlatAppearance.BorderSize = 0;
            this.btnAddComponents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle;
            this.btnAddComponents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.btnAddComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddComponents.Location = new System.Drawing.Point(201, 437);
            this.btnAddComponents.Name = "btnAddComponents";
            this.btnAddComponents.Size = new System.Drawing.Size(330, 26);
            this.btnAddComponents.TabIndex = 3;
            this.btnAddComponents.Text = "Request components";
            this.btnAddComponents.UseVisualStyleBackColor = false;
            // 
            // nudCountComponents
            // 
            this.nudCountComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCountComponents.Location = new System.Drawing.Point(201, 405);
            this.nudCountComponents.Name = "nudCountComponents";
            this.nudCountComponents.Size = new System.Drawing.Size(330, 26);
            this.nudCountComponents.TabIndex = 4;
            // 
            // FrmComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 490);
            this.Controls.Add(this.nudCountComponents);
            this.Controls.Add(this.btnAddComponents);
            this.Controls.Add(this.dgvComponents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmComponents";
            this.ShowInTaskbar = false;
            this.Text = "FrmComponents";
            this.Load += new System.EventHandler(this.FrmComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComponents;
        private System.Windows.Forms.Button btnAddComponents;
        private System.Windows.Forms.NumericUpDown nudCountComponents;
    }
}