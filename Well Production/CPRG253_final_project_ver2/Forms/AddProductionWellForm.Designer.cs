﻿namespace CPRG253_final_project_ver2
{
    partial class AddProductionWellForm
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
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddProductionWellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Name = "AddProductionWellForm";
            this.Text = "AddProductionWell";
            this.Load += new System.EventHandler(this.AddProductionWell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}