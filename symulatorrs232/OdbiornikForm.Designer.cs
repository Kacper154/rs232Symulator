namespace SymulatorRS232
{
    partial class OdbiornikForm
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
            this.ASCIITextBox = new System.Windows.Forms.TextBox();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.censorCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ASCIITextBox
            // 
            this.ASCIITextBox.Location = new System.Drawing.Point(14, 157);
            this.ASCIITextBox.Multiline = true;
            this.ASCIITextBox.Name = "ASCIITextBox";
            this.ASCIITextBox.ReadOnly = true;
            this.ASCIITextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ASCIITextBox.Size = new System.Drawing.Size(330, 117);
            this.ASCIITextBox.TabIndex = 1;
            this.ASCIITextBox.TextChanged += new System.EventHandler(this.ASCIITextBox_TextChanged);
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Location = new System.Drawing.Point(12, 12);
            this.binaryTextBox.Multiline = true;
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.ReadOnly = true;
            this.binaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.binaryTextBox.Size = new System.Drawing.Size(329, 126);
            this.binaryTextBox.TabIndex = 2;
            this.binaryTextBox.TextChanged += new System.EventHandler(this.binaryTextBox_TextChanged);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Enabled = false;
            this.ConvertButton.Location = new System.Drawing.Point(32, 307);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Konwertuj";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // censorCheckBox
            // 
            this.censorCheckBox.AutoSize = true;
            this.censorCheckBox.Enabled = false;
            this.censorCheckBox.Location = new System.Drawing.Point(153, 311);
            this.censorCheckBox.Name = "censorCheckBox";
            this.censorCheckBox.Size = new System.Drawing.Size(64, 17);
            this.censorCheckBox.TabIndex = 4;
            this.censorCheckBox.Text = "cenzura";
            this.censorCheckBox.UseVisualStyleBackColor = true;
            this.censorCheckBox.CheckedChanged += new System.EventHandler(this.censorCheckBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OdbiornikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 379);
            this.Controls.Add(this.censorCheckBox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.ASCIITextBox);
            this.Name = "OdbiornikForm";
            this.Text = "Odbiornik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OdbiornikForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ASCIITextBox;
        public System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.CheckBox censorCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}