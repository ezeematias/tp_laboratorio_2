﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComponents));
            this.dgvComponents = new System.Windows.Forms.DataGridView();
            this.btnAddComponents = new System.Windows.Forms.Button();
            this.nudCountComponents = new System.Windows.Forms.NumericUpDown();
            this.lblErrorList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComponents
            // 
            this.dgvComponents.AllowUserToAddRows = false;
            this.dgvComponents.AllowUserToDeleteRows = false;
            this.dgvComponents.AllowUserToResizeColumns = false;
            this.dgvComponents.AllowUserToResizeRows = false;
            this.dgvComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComponents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComponents.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComponents.Location = new System.Drawing.Point(201, 48);
            this.dgvComponents.MultiSelect = false;
            this.dgvComponents.Name = "dgvComponents";
            this.dgvComponents.ReadOnly = true;
            this.dgvComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComponents.Size = new System.Drawing.Size(330, 351);
            this.dgvComponents.TabIndex = 0;
            // 
            // btnAddComponents
            // 
            this.btnAddComponents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddComponents.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddComponents.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddComponents.FlatAppearance.BorderSize = 0;
            this.btnAddComponents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btnAddComponents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddComponents.Location = new System.Drawing.Point(201, 437);
            this.btnAddComponents.Name = "btnAddComponents";
            this.btnAddComponents.Size = new System.Drawing.Size(330, 26);
            this.btnAddComponents.TabIndex = 3;
            this.btnAddComponents.Text = "Request components";
            this.btnAddComponents.UseVisualStyleBackColor = false;
            this.btnAddComponents.Click += new System.EventHandler(this.btnAddComponents_Click);
            // 
            // nudCountComponents
            // 
            this.nudCountComponents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCountComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCountComponents.Location = new System.Drawing.Point(201, 405);
            this.nudCountComponents.Name = "nudCountComponents";
            this.nudCountComponents.Size = new System.Drawing.Size(330, 26);
            this.nudCountComponents.TabIndex = 4;
            // 
            // lblErrorList
            // 
            this.lblErrorList.AutoSize = true;
            this.lblErrorList.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorList.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorList.Location = new System.Drawing.Point(198, 9);
            this.lblErrorList.Name = "lblErrorList";
            this.lblErrorList.Size = new System.Drawing.Size(98, 13);
            this.lblErrorList.TabIndex = 5;
            this.lblErrorList.Text = "Error to charged list";
            // 
            // FrmComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 490);
            this.Controls.Add(this.lblErrorList);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComponents;
        private System.Windows.Forms.Button btnAddComponents;
        private System.Windows.Forms.NumericUpDown nudCountComponents;
        private System.Windows.Forms.Label lblErrorList;
    }
}