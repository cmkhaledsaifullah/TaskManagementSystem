namespace UI
{
    partial class Edit_Project_Info
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_colab1 = new System.Windows.Forms.Label();
            this.label_colab2 = new System.Windows.Forms.Label();
            this.label_colab3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Collaborators";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(161, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(207, 78);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label_colab1
            // 
            this.label_colab1.AutoSize = true;
            this.label_colab1.Location = new System.Drawing.Point(158, 187);
            this.label_colab1.Name = "label_colab1";
            this.label_colab1.Size = new System.Drawing.Size(35, 13);
            this.label_colab1.TabIndex = 5;
            this.label_colab1.Text = "label4";
            // 
            // label_colab2
            // 
            this.label_colab2.AutoSize = true;
            this.label_colab2.Location = new System.Drawing.Point(158, 223);
            this.label_colab2.Name = "label_colab2";
            this.label_colab2.Size = new System.Drawing.Size(35, 13);
            this.label_colab2.TabIndex = 6;
            this.label_colab2.Text = "label4";
            // 
            // label_colab3
            // 
            this.label_colab3.AutoSize = true;
            this.label_colab3.Location = new System.Drawing.Point(158, 265);
            this.label_colab3.Name = "label_colab3";
            this.label_colab3.Size = new System.Drawing.Size(35, 13);
            this.label_colab3.TabIndex = 7;
            this.label_colab3.Text = "label4";
            // 
            // Edit_Project_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 403);
            this.Controls.Add(this.label_colab3);
            this.Controls.Add(this.label_colab2);
            this.Controls.Add(this.label_colab1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Project_Info";
            this.Text = "Edit Project Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_colab1;
        private System.Windows.Forms.Label label_colab2;
        private System.Windows.Forms.Label label_colab3;
    }
}