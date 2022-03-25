namespace WindowsFormsApp1
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
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.btnNumbers = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(49, 105);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(238, 105);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 23);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(24, 46);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(140, 20);
            this.txtFirst.TabIndex = 2;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(210, 46);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(140, 20);
            this.txtSecond.TabIndex = 3;
            // 
            // btnNumbers
            // 
            this.btnNumbers.Location = new System.Drawing.Point(392, 219);
            this.btnNumbers.Name = "btnNumbers";
            this.btnNumbers.Size = new System.Drawing.Size(124, 23);
            this.btnNumbers.TabIndex = 4;
            this.btnNumbers.Text = "Generate Numbers";
            this.btnNumbers.UseVisualStyleBackColor = true;
            this.btnNumbers.Click += new System.EventHandler(this.btnNumbers_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(372, 12);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(165, 186);
            this.lstNumbers.TabIndex = 5;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(118, 202);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(146, 23);
            this.btnChangeColor.TabIndex = 6;
            this.btnChangeColor.Text = "Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 277);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnNumbers);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Button btnNumbers;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Button btnChangeColor;
    }
}

