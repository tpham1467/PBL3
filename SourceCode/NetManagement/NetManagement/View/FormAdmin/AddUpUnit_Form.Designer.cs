﻿namespace NetManagement.View.FormAdmin
{
    partial class AddUpUnit_Form
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
            this.lbNameUnit = new System.Windows.Forms.Label();
            this.txtNameUnit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNameUnit
            // 
            this.lbNameUnit.AutoSize = true;
            this.lbNameUnit.Location = new System.Drawing.Point(33, 25);
            this.lbNameUnit.Name = "lbNameUnit";
            this.lbNameUnit.Size = new System.Drawing.Size(70, 16);
            this.lbNameUnit.TabIndex = 0;
            this.lbNameUnit.Text = "Name Unit";
            // 
            // txtNameUnit
            // 
            this.txtNameUnit.Location = new System.Drawing.Point(138, 22);
            this.txtNameUnit.Name = "txtNameUnit";
            this.txtNameUnit.Size = new System.Drawing.Size(215, 22);
            this.txtNameUnit.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddUpUnit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetManagement.Properties.Resources.color_background;
            this.ClientSize = new System.Drawing.Size(365, 129);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNameUnit);
            this.Controls.Add(this.lbNameUnit);
            this.Name = "AddUpUnit_Form";
            this.Text = "AddUpUnit_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameUnit;
        private System.Windows.Forms.TextBox txtNameUnit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}