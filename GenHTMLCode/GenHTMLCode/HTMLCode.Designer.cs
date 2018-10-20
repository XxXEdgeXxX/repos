namespace GenHTMLCode
{
    partial class HTMLCode
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
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(46, 24);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(641, 378);
            this.tbCode.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnEdit.Location = new System.Drawing.Point(686, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Back to previous";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // HTMLCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbCode);
            this.Name = "HTMLCode";
            this.Text = "HTMLCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HTMLCode_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btnEdit;
    }
}