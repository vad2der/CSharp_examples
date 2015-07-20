namespace CPRG253_final_project_ver2
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWellPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductionWellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInjectionWellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wellProductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.facilitiesToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.explorerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.explorerToolStripMenuItem.Text = "&Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // facilitiesToolStripMenuItem
            // 
            this.facilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWellPadToolStripMenuItem,
            this.addProductionWellToolStripMenuItem,
            this.addInjectionWellToolStripMenuItem});
            this.facilitiesToolStripMenuItem.Name = "facilitiesToolStripMenuItem";
            this.facilitiesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.facilitiesToolStripMenuItem.Text = "&Facilities";
            // 
            // addWellPadToolStripMenuItem
            // 
            this.addWellPadToolStripMenuItem.Name = "addWellPadToolStripMenuItem";
            this.addWellPadToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addWellPadToolStripMenuItem.Text = "Add Well &Pad";
            this.addWellPadToolStripMenuItem.Click += new System.EventHandler(this.addWellPadToolStripMenuItem_Click);
            // 
            // addProductionWellToolStripMenuItem
            // 
            this.addProductionWellToolStripMenuItem.Name = "addProductionWellToolStripMenuItem";
            this.addProductionWellToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addProductionWellToolStripMenuItem.Text = "Add P&roduction Well";
            this.addProductionWellToolStripMenuItem.Click += new System.EventHandler(this.addProductionWellToolStripMenuItem_Click);
            // 
            // addInjectionWellToolStripMenuItem
            // 
            this.addInjectionWellToolStripMenuItem.Name = "addInjectionWellToolStripMenuItem";
            this.addInjectionWellToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addInjectionWellToolStripMenuItem.Text = "Add &Injection Well";
            this.addInjectionWellToolStripMenuItem.Click += new System.EventHandler(this.addInjectionWellToolStripMenuItem_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wellProductionToolStripMenuItem});
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productionToolStripMenuItem.Text = "Pro&duction";
            // 
            // wellProductionToolStripMenuItem
            // 
            this.wellProductionToolStripMenuItem.Name = "wellProductionToolStripMenuItem";
            this.wellProductionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.wellProductionToolStripMenuItem.Text = "Well Prod&uction";
            this.wellProductionToolStripMenuItem.Click += new System.EventHandler(this.wellProductionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            this.statusLabel.ToolTipText = "Status of application.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 544);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWellPadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductionWellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInjectionWellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wellProductionToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

