namespace UI
{
    partial class Log_In
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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_authenticate = new System.Windows.Forms.Button();
            this.label_errmsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(245, 154);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(142, 20);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(245, 208);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(142, 20);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_authenticate
            // 
            this.button_authenticate.Location = new System.Drawing.Point(245, 272);
            this.button_authenticate.Name = "button_authenticate";
            this.button_authenticate.Size = new System.Drawing.Size(87, 27);
            this.button_authenticate.TabIndex = 4;
            this.button_authenticate.Text = "Authenticate";
            this.button_authenticate.UseVisualStyleBackColor = true;
            this.button_authenticate.Click += new System.EventHandler(this.button_authenticate_Click);
            // 
            // label_errmsg
            // 
            this.label_errmsg.AutoSize = true;
            this.label_errmsg.Location = new System.Drawing.Point(253, 246);
            this.label_errmsg.Name = "label_errmsg";
            this.label_errmsg.Size = new System.Drawing.Size(0, 13);
            this.label_errmsg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dont have a Account";
            // 
            // linkLabel_register
            // 
            this.linkLabel_register.AutoSize = true;
            this.linkLabel_register.Location = new System.Drawing.Point(357, 330);
            this.linkLabel_register.Name = "linkLabel_register";
            this.linkLabel_register.Size = new System.Drawing.Size(46, 13);
            this.linkLabel_register.TabIndex = 7;
            this.linkLabel_register.TabStop = true;
            this.linkLabel_register.Text = "Register";
            this.linkLabel_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_register_LinkClicked);
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 415);
            this.Controls.Add(this.linkLabel_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_errmsg);
            this.Controls.Add(this.button_authenticate);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Log_In";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_authenticate;
        private System.Windows.Forms.Label label_errmsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel_register;
    }
}