namespace MillerAssignment6
{
    partial class Form1
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
            this.WholesalePriceText = new System.Windows.Forms.TextBox();
            this.RetailResultLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WholesalePriceText
            // 
            this.WholesalePriceText.Location = new System.Drawing.Point(12, 56);
            this.WholesalePriceText.Name = "WholesalePriceText";
            this.WholesalePriceText.Size = new System.Drawing.Size(100, 20);
            this.WholesalePriceText.TabIndex = 0;
            // 
            // RetailResultLabel
            // 
            this.RetailResultLabel.AutoSize = true;
            this.RetailResultLabel.Location = new System.Drawing.Point(141, 59);
            this.RetailResultLabel.Name = "RetailResultLabel";
            this.RetailResultLabel.Size = new System.Drawing.Size(0, 13);
            this.RetailResultLabel.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(21, 111);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(83, 29);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 252);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.RetailResultLabel);
            this.Controls.Add(this.WholesalePriceText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WholesalePriceText;
        private System.Windows.Forms.Label RetailResultLabel;
        private System.Windows.Forms.Button CalculateButton;
    }
}

