namespace UI
{
    partial class Change_Password
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
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_conpass = new System.Windows.Forms.TextBox();
            this.button_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(214, 113);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(152, 26);
            this.textBox_pass.TabIndex = 2;
            this.textBox_pass.UseSystemPasswordChar = true;
            // 
            // textBox_conpass
            // 
            this.textBox_conpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_conpass.Location = new System.Drawing.Point(214, 168);
            this.textBox_conpass.Name = "textBox_conpass";
            this.textBox_conpass.Size = new System.Drawing.Size(152, 26);
            this.textBox_conpass.TabIndex = 3;
            this.textBox_conpass.UseSystemPasswordChar = true;
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(214, 233);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(107, 31);
            this.button_change.TabIndex = 4;
            this.button_change.Text = "Change Password";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 394);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.textBox_conpass);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Change_Password";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_conpass;
        private System.Windows.Forms.Button button_change;
    }
}