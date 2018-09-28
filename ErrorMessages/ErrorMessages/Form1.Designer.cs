namespace ErrorMessages
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
            this.lbErrors = new System.Windows.Forms.ListBox();
            this.lblErrorAmount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbErrors
            // 
            this.lbErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.Location = new System.Drawing.Point(12, 12);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(566, 381);
            this.lbErrors.TabIndex = 0;
            // 
            // lblErrorAmount
            // 
            this.lblErrorAmount.AutoSize = true;
            this.lblErrorAmount.Location = new System.Drawing.Point(722, 29);
            this.lblErrorAmount.Name = "lblErrorAmount";
            this.lblErrorAmount.Size = new System.Drawing.Size(35, 13);
            this.lblErrorAmount.TabIndex = 1;
            this.lblErrorAmount.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(631, 386);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblErrorAmount);
            this.Controls.Add(this.lbErrors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbErrors;
        private System.Windows.Forms.Label lblErrorAmount;
        private System.Windows.Forms.Button btnStart;
    }
}

