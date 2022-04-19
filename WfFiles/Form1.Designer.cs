namespace WfFiles
{
    partial class Parent
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
            this.tbParent = new System.Windows.Forms.TextBox();
            this.butShow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Add_but = new System.Windows.Forms.Button();
            this.Del_but = new System.Windows.Forms.Button();
            this.Clear_but = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbParent
            // 
            this.tbParent.Location = new System.Drawing.Point(43, 45);
            this.tbParent.Multiline = true;
            this.tbParent.Name = "tbParent";
            this.tbParent.Size = new System.Drawing.Size(174, 45);
            this.tbParent.TabIndex = 0;
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(43, 155);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(84, 33);
            this.butShow.TabIndex = 1;
            this.butShow.Text = "Show";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Clear_but);
            this.panel1.Controls.Add(this.Del_but);
            this.panel1.Controls.Add(this.Add_but);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(262, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 193);
            this.panel1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 108);
            this.listBox1.TabIndex = 0;
            // 
            // Add_but
            // 
            this.Add_but.Location = new System.Drawing.Point(27, 119);
            this.Add_but.Name = "Add_but";
            this.Add_but.Size = new System.Drawing.Size(75, 23);
            this.Add_but.TabIndex = 1;
            this.Add_but.Text = "Add";
            this.Add_but.UseVisualStyleBackColor = true;
            this.Add_but.Click += new System.EventHandler(this.Add_but_Click);
            // 
            // Del_but
            // 
            this.Del_but.Location = new System.Drawing.Point(134, 119);
            this.Del_but.Name = "Del_but";
            this.Del_but.Size = new System.Drawing.Size(75, 23);
            this.Del_but.TabIndex = 2;
            this.Del_but.Text = "Delete";
            this.Del_but.UseVisualStyleBackColor = true;
            this.Del_but.Click += new System.EventHandler(this.Del_but_Click);
            // 
            // Clear_but
            // 
            this.Clear_but.Location = new System.Drawing.Point(79, 148);
            this.Clear_but.Name = "Clear_but";
            this.Clear_but.Size = new System.Drawing.Size(75, 23);
            this.Clear_but.TabIndex = 3;
            this.Clear_but.Text = "Clear";
            this.Clear_but.UseVisualStyleBackColor = true;
            this.Clear_but.Click += new System.EventHandler(this.Clear_but_Click);
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 296);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butShow);
            this.Controls.Add(this.tbParent);
            this.Name = "Parent";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbParent;
        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clear_but;
        private System.Windows.Forms.Button Del_but;
        private System.Windows.Forms.Button Add_but;
        private System.Windows.Forms.ListBox listBox1;
    }
}

