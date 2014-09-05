namespace UI
{
    partial class Add_To_Do_List
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_assaignedto = new System.Windows.Forms.TextBox();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label_colab1 = new System.Windows.Forms.Label();
            this.label_colab2 = new System.Windows.Forms.Label();
            this.label_colab3 = new System.Windows.Forms.Label();
            this.linkLabel_add_colab1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_add_colab2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_add_colab3 = new System.Windows.Forms.LinkLabel();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assaigned To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Due Date";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(113, 57);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(195, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_assaignedto
            // 
            this.textBox_assaignedto.Location = new System.Drawing.Point(113, 96);
            this.textBox_assaignedto.Name = "textBox_assaignedto";
            this.textBox_assaignedto.Size = new System.Drawing.Size(195, 20);
            this.textBox_assaignedto.TabIndex = 4;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(113, 209);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_date.TabIndex = 5;
            // 
            // label_colab1
            // 
            this.label_colab1.AutoSize = true;
            this.label_colab1.Location = new System.Drawing.Point(110, 132);
            this.label_colab1.Name = "label_colab1";
            this.label_colab1.Size = new System.Drawing.Size(0, 13);
            this.label_colab1.TabIndex = 6;
            // 
            // label_colab2
            // 
            this.label_colab2.AutoSize = true;
            this.label_colab2.Location = new System.Drawing.Point(110, 159);
            this.label_colab2.Name = "label_colab2";
            this.label_colab2.Size = new System.Drawing.Size(0, 13);
            this.label_colab2.TabIndex = 7;
            // 
            // label_colab3
            // 
            this.label_colab3.AutoSize = true;
            this.label_colab3.Location = new System.Drawing.Point(110, 183);
            this.label_colab3.Name = "label_colab3";
            this.label_colab3.Size = new System.Drawing.Size(0, 13);
            this.label_colab3.TabIndex = 8;
            // 
            // linkLabel_add_colab1
            // 
            this.linkLabel_add_colab1.AutoSize = true;
            this.linkLabel_add_colab1.Location = new System.Drawing.Point(151, 132);
            this.linkLabel_add_colab1.Name = "linkLabel_add_colab1";
            this.linkLabel_add_colab1.Size = new System.Drawing.Size(26, 13);
            this.linkLabel_add_colab1.TabIndex = 9;
            this.linkLabel_add_colab1.TabStop = true;
            this.linkLabel_add_colab1.Text = "Add";
            this.linkLabel_add_colab1.Visible = false;
            this.linkLabel_add_colab1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_add_colab1_LinkClicked);
            // 
            // linkLabel_add_colab2
            // 
            this.linkLabel_add_colab2.AutoSize = true;
            this.linkLabel_add_colab2.Location = new System.Drawing.Point(151, 159);
            this.linkLabel_add_colab2.Name = "linkLabel_add_colab2";
            this.linkLabel_add_colab2.Size = new System.Drawing.Size(26, 13);
            this.linkLabel_add_colab2.TabIndex = 10;
            this.linkLabel_add_colab2.TabStop = true;
            this.linkLabel_add_colab2.Text = "Add";
            this.linkLabel_add_colab2.Visible = false;
            this.linkLabel_add_colab2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_add_colab2_LinkClicked);
            // 
            // linkLabel_add_colab3
            // 
            this.linkLabel_add_colab3.AutoSize = true;
            this.linkLabel_add_colab3.Location = new System.Drawing.Point(151, 183);
            this.linkLabel_add_colab3.Name = "linkLabel_add_colab3";
            this.linkLabel_add_colab3.Size = new System.Drawing.Size(26, 13);
            this.linkLabel_add_colab3.TabIndex = 11;
            this.linkLabel_add_colab3.TabStop = true;
            this.linkLabel_add_colab3.Text = "Add";
            this.linkLabel_add_colab3.Visible = false;
            this.linkLabel_add_colab3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_add_colab3_LinkClicked);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(204, 289);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(104, 28);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Add_To_Do_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 343);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.linkLabel_add_colab3);
            this.Controls.Add(this.linkLabel_add_colab2);
            this.Controls.Add(this.linkLabel_add_colab1);
            this.Controls.Add(this.label_colab3);
            this.Controls.Add(this.label_colab2);
            this.Controls.Add(this.label_colab1);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.textBox_assaignedto);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_To_Do_List";
            this.Text = "Add_To_Do_List";
            this.Load += new System.EventHandler(this.Add_To_Do_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_assaignedto;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label_colab1;
        private System.Windows.Forms.Label label_colab2;
        private System.Windows.Forms.Label label_colab3;
        private System.Windows.Forms.LinkLabel linkLabel_add_colab1;
        private System.Windows.Forms.LinkLabel linkLabel_add_colab2;
        private System.Windows.Forms.LinkLabel linkLabel_add_colab3;
        private System.Windows.Forms.Button button_add;
    }
}