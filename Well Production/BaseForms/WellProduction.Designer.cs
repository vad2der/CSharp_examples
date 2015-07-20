namespace BaseForms
{
    partial class WellProduction
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
            this.WellPadcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WellComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BarrelsProducedTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WellPadcomboBox
            // 
            this.WellPadcomboBox.FormattingEnabled = true;
            this.WellPadcomboBox.Location = new System.Drawing.Point(100, 12);
            this.WellPadcomboBox.Name = "WellPadcomboBox";
            this.WellPadcomboBox.Size = new System.Drawing.Size(172, 21);
            this.WellPadcomboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Well Pads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Production Wells";
            // 
            // WellComboBox
            // 
            this.WellComboBox.FormattingEnabled = true;
            this.WellComboBox.Location = new System.Drawing.Point(100, 39);
            this.WellComboBox.Name = "WellComboBox";
            this.WellComboBox.Size = new System.Drawing.Size(172, 21);
            this.WellComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Barrels Produced";
            // 
            // BarrelsProducedTextBox
            // 
            this.BarrelsProducedTextBox.Location = new System.Drawing.Point(100, 64);
            this.BarrelsProducedTextBox.Name = "BarrelsProducedTextBox";
            this.BarrelsProducedTextBox.Size = new System.Drawing.Size(172, 20);
            this.BarrelsProducedTextBox.TabIndex = 5;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(197, 90);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // WellProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.BarrelsProducedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WellComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WellPadcomboBox);
            this.Name = "WellProduction";
            this.Text = "WellProduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox WellPadcomboBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox WellComboBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox BarrelsProducedTextBox;
        public System.Windows.Forms.Button SubmitButton;

    }
}