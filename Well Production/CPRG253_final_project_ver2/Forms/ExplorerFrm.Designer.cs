﻿namespace CPRG253_final_project_ver2
{
    partial class ExplorerFrm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // uxTreeView
            // 
            this.uxTreeView.LineColor = System.Drawing.Color.Black;
            this.uxTreeView.Size = new System.Drawing.Size(225, 531);
            this.uxTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.uxTreeView_AfterSelect);
            // 
            // uxListView
            // 
            this.uxListView.Size = new System.Drawing.Size(610, 531);
            // 
            // ExplorerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 531);
            this.Name = "ExplorerFrm";
            this.Text = "ExplorerFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExplorerFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}