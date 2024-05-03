namespace SymulatorRS232
{
    partial class NadajnikForm
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
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ASCIITextBox
            // 
            this.ASCIITextBox.Location = new System.Drawing.Point(12, 33);
            this.ASCIITextBox.Multiline = true;
            this.ASCIITextBox.Name = "ASCIITextBox";
            this.ASCIITextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ASCIITextBox.Size = new System.Drawing.Size(330, 117);
            this.ASCIITextBox.TabIndex = 0;
            this.ASCIITextBox.TextChanged += new System.EventHandler(this.ASCIITextBox_TextChanged);
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Location = new System.Drawing.Point(13, 172);
            this.binaryTextBox.Multiline = true;
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.ReadOnly = true;
            this.binaryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.binaryTextBox.Size = new System.Drawing.Size(329, 126);
            this.binaryTextBox.TabIndex = 1;
            this.binaryTextBox.TextChanged += new System.EventHandler(this.binaryTextBox_TextChanged);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Enabled = false;
            this.ConvertButton.Location = new System.Drawing.Point(47, 331);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Konwertuj";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(229, 331);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Wyślij";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // NadajnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 409);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.ASCIITextBox);
            this.Name = "NadajnikForm";
            this.Text = "Nadajnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ASCIITextBox;
        private System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button SendButton;
    }
}

