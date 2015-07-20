namespace BaseForms
{
    partial class AddWell
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
            this.WellPadComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SpudDateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WaterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // WellPadComboBox
            // 
            this.WellPadComboBox.FormattingEnabled = true;
            this.WellPadComboBox.Location = new System.Drawing.Point(101, 6);
            this.WellPadComboBox.Name = "WellPadComboBox";
            this.WellPadComboBox.Size = new System.Drawing.Size(171, 21);
            this.WellPadComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Well Pad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(101, 37);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(171, 20);
            this.IDTextBox.TabIndex = 3;
            // 
            // SpudDateTextBox
            // 
            this.SpudDateTextBox.Location = new System.Drawing.Point(101, 63);
            this.SpudDateTextBox.Name = "SpudDateTextBox";
            this.SpudDateTextBox.Size = new System.Drawing.Size(171, 20);
            this.SpudDateTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spud Date";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(197, 120);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Water Type";
            // 
            // WaterTypeComboBox
            // 
            this.WaterTypeComboBox.FormattingEnabled = true;
            this.WaterTypeComboBox.Location = new System.Drawing.Point(101, 89);
            this.WaterTypeComboBox.Name = "WaterTypeComboBox";
            this.WaterTypeComboBox.Size = new System.Drawing.Size(171, 21);
            this.WaterTypeComboBox.TabIndex = 7;
            // 
            // AddWell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WaterTypeComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SpudDateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WellPadComboBox);
            this.Name = "AddWell";
            this.Text = "AddWell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox WellPadComboBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox IDTextBox;
        public System.Windows.Forms.TextBox SpudDateTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox WaterTypeComboBox;
    }
}