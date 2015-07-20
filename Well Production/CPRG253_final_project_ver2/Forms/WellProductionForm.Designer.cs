namespace CPRG253_final_project_ver2
{
    partial class WellProductionForm
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
            this.prodDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WellPadcomboBox
            // 
            this.WellPadcomboBox.SelectedIndexChanged += new System.EventHandler(this.WellProductionForm_Load);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(197, 116);
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // prodDateTextBox
            // 
            this.prodDateTextBox.Location = new System.Drawing.Point(102, 90);
            this.prodDateTextBox.Name = "prodDateTextBox";
            this.prodDateTextBox.Size = new System.Drawing.Size(170, 20);
            this.prodDateTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Production Date";
            // 
            // WellProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodDateTextBox);
            this.Name = "WellProductionForm";
            this.Text = "WellProductionForm";
            this.Load += new System.EventHandler(this.WellProductionForm_Load);
            this.Controls.SetChildIndex(this.WellPadcomboBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.WellComboBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.BarrelsProducedTextBox, 0);
            this.Controls.SetChildIndex(this.SubmitButton, 0);
            this.Controls.SetChildIndex(this.prodDateTextBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prodDateTextBox;
        private System.Windows.Forms.Label label4;
    }
}