namespace WfFiles
{
    partial class Child
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
            this.tbChild = new System.Windows.Forms.TextBox();
            this.butClose = new System.Windows.Forms.Button();
            this.OK_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbChild
            // 
            this.tbChild.Location = new System.Drawing.Point(47, 69);
            this.tbChild.Multiline = true;
            this.tbChild.Name = "tbChild";
            this.tbChild.Size = new System.Drawing.Size(185, 54);
            this.tbChild.TabIndex = 0;
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(47, 171);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(90, 32);
            this.butClose.TabIndex = 1;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // OK_but
            // 
            this.OK_but.Location = new System.Drawing.Point(156, 171);
            this.OK_but.Name = "OK_but";
            this.OK_but.Size = new System.Drawing.Size(75, 32);
            this.OK_but.TabIndex = 2;
            this.OK_but.Text = "OK";
            this.OK_but.UseVisualStyleBackColor = true;
            this.OK_but.Click += new System.EventHandler(this.OK_but_Click);
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 279);
            this.Controls.Add(this.OK_but);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.tbChild);
            this.Name = "Child";
            this.Text = "Child";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChild;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button OK_but;
    }
}