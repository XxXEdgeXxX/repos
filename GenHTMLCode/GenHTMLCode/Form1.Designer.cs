namespace GenHTMLCode
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbCSS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.AcceptsTab = true;
            this.tbTitle.Location = new System.Drawing.Point(12, 12);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(248, 20);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Text = "Title?";
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            this.tbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbTitle_MouseDown);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(185, 139);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbCSS
            // 
            this.tbCSS.AcceptsTab = true;
            this.tbCSS.Location = new System.Drawing.Point(12, 38);
            this.tbCSS.Name = "tbCSS";
            this.tbCSS.Size = new System.Drawing.Size(248, 20);
            this.tbCSS.TabIndex = 1;
            this.tbCSS.Text = "CSS name?";
            this.tbCSS.Leave += new System.EventHandler(this.tbCSS_Leave);
            this.tbCSS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbCSS_MouseDown);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 174);
            this.Controls.Add(this.tbCSS);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbCSS;
    }
}

