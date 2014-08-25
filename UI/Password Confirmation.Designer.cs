namespace UI
{
    partial class Password_Confirmation
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
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_authenticate = new System.Windows.Forms.Button();
            this.label_errmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(199, 115);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(141, 26);
            this.textBox_pass.TabIndex = 1;
            this.textBox_pass.UseSystemPasswordChar = true;
            // 
            // button_authenticate
            // 
            this.button_authenticate.Location = new System.Drawing.Point(199, 183);
            this.button_authenticate.Name = "button_authenticate";
            this.button_authenticate.Size = new System.Drawing.Size(75, 23);
            this.button_authenticate.TabIndex = 2;
            this.button_authenticate.Text = "Authenticate";
            this.button_authenticate.UseVisualStyleBackColor = true;
            this.button_authenticate.Click += new System.EventHandler(this.button_authenticate_Click);
            // 
            // label_errmsg
            // 
            this.label_errmsg.AutoSize = true;
            this.label_errmsg.Location = new System.Drawing.Point(206, 156);
            this.label_errmsg.Name = "label_errmsg";
            this.label_errmsg.Size = new System.Drawing.Size(0, 13);
            this.label_errmsg.TabIndex = 3;
            // 
            // Password_Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 315);
            this.Controls.Add(this.label_errmsg);
            this.Controls.Add(this.button_authenticate);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label1);
            this.Name = "Password_Confirmation";
            this.Text = "Password Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_authenticate;
        private System.Windows.Forms.Label label_errmsg;
    }
}