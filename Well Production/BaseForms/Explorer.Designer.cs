namespace BaseForms
{
    partial class Explorer
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
            this.uxTreeView = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.uxListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // uxTreeView
            // 
            this.uxTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.uxTreeView.Location = new System.Drawing.Point(0, 0);
            this.uxTreeView.Name = "uxTreeView";
            this.uxTreeView.Size = new System.Drawing.Size(225, 490);
            this.uxTreeView.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(225, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 490);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // uxListView
            // 
            this.uxListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxListView.Location = new System.Drawing.Point(235, 0);
            this.uxListView.Name = "uxListView";
            this.uxListView.Size = new System.Drawing.Size(622, 490);
            this.uxListView.TabIndex = 2;
            this.uxListView.UseCompatibleStateImageBehavior = false;
            this.uxListView.View = System.Windows.Forms.View.Details;
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 490);
            this.Controls.Add(this.uxListView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.uxTreeView);
            this.Name = "Explorer";
            this.Text = "Explorer";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView uxTreeView;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.ListView uxListView;
    }
}