namespace DeathStar
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
            this.starButton = new System.Windows.Forms.Button();
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.yInput = new System.Windows.Forms.TextBox();
            this.xInput = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // starButton
            // 
            this.starButton.ForeColor = System.Drawing.Color.Black;
            this.starButton.Location = new System.Drawing.Point(347, 387);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(75, 23);
            this.starButton.TabIndex = 0;
            this.starButton.Text = "Death Star";
            this.starButton.UseVisualStyleBackColor = true;
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(663, 113);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(100, 20);
            this.sizeInput.TabIndex = 13;
            this.sizeInput.Text = "1";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(615, 113);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 12;
            this.sizeLabel.Text = "Size";
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(663, 67);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(100, 20);
            this.yInput.TabIndex = 11;
            this.yInput.Text = "0";
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(663, 28);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(100, 20);
            this.xInput.TabIndex = 10;
            this.xInput.Text = "0";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(612, 67);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(44, 13);
            this.yLabel.TabIndex = 9;
            this.yLabel.Text = "Y Value";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(612, 28);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(44, 13);
            this.xLabel.TabIndex = 8;
            this.xLabel.Text = "X Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.starButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button starButton;
        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
    }
}

