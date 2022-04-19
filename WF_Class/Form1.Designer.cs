namespace WF_Class
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
            this.list = new System.Windows.Forms.ListBox();
            this.Add_but = new System.Windows.Forms.Button();
            this.Red_but = new System.Windows.Forms.Button();
            this.Del_but = new System.Windows.Forms.Button();
            this.Clear_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(0, -2);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(427, 407);
            this.list.TabIndex = 0;
            // 
            // Add_but
            // 
            this.Add_but.Location = new System.Drawing.Point(0, 411);
            this.Add_but.Name = "Add_but";
            this.Add_but.Size = new System.Drawing.Size(427, 36);
            this.Add_but.TabIndex = 1;
            this.Add_but.Text = "Добарить товар";
            this.Add_but.UseVisualStyleBackColor = true;
            this.Add_but.Click += new System.EventHandler(this.Add_but_Click);
            // 
            // Red_but
            // 
            this.Red_but.Location = new System.Drawing.Point(0, 453);
            this.Red_but.Name = "Red_but";
            this.Red_but.Size = new System.Drawing.Size(427, 36);
            this.Red_but.TabIndex = 2;
            this.Red_but.Text = "Редактировать товар";
            this.Red_but.UseVisualStyleBackColor = true;
            this.Red_but.Click += new System.EventHandler(this.Red_but_Click);
            // 
            // Del_but
            // 
            this.Del_but.Location = new System.Drawing.Point(0, 495);
            this.Del_but.Name = "Del_but";
            this.Del_but.Size = new System.Drawing.Size(427, 36);
            this.Del_but.TabIndex = 3;
            this.Del_but.Text = "Удалить товар";
            this.Del_but.UseVisualStyleBackColor = true;
            this.Del_but.Click += new System.EventHandler(this.Del_but_Click);
            // 
            // Clear_but
            // 
            this.Clear_but.Location = new System.Drawing.Point(0, 537);
            this.Clear_but.Name = "Clear_but";
            this.Clear_but.Size = new System.Drawing.Size(427, 36);
            this.Clear_but.TabIndex = 4;
            this.Clear_but.Text = "Очистить список товаров";
            this.Clear_but.UseVisualStyleBackColor = true;
            this.Clear_but.Click += new System.EventHandler(this.Clear_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 578);
            this.Controls.Add(this.Clear_but);
            this.Controls.Add(this.Del_but);
            this.Controls.Add(this.Red_but);
            this.Controls.Add(this.Add_but);
            this.Controls.Add(this.list);
            this.Name = "Form1";
            this.Text = "Каталог товаров";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Button Add_but;
        private System.Windows.Forms.Button Red_but;
        private System.Windows.Forms.Button Del_but;
        private System.Windows.Forms.Button Clear_but;
    }
}

