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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label_colab1 = new System.Windows.Forms.Label();
            this.label_colab2 = new System.Windows.Forms.Label();
            this.label_colab3 = new System.Windows.Forms.Label();
            this.linkLabel_remove1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_remove2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_remove3 = new System.Windows.Forms.LinkLabel();
            this.button_search = new System.Windows.Forms.Button();
            this.listView_search = new System.Windows.Forms.ListView();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_addpeople = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.panel_addpeople.SuspendLayout();
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
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(161, 54);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(207, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(161, 87);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(207, 78);
            this.richTextBox_description.TabIndex = 4;
            this.richTextBox_description.Text = "";
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
            // linkLabel_remove1
            // 
            this.linkLabel_remove1.AutoSize = true;
            this.linkLabel_remove1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_remove1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel_remove1.Location = new System.Drawing.Point(199, 187);
            this.linkLabel_remove1.Name = "linkLabel_remove1";
            this.linkLabel_remove1.Size = new System.Drawing.Size(47, 13);
            this.linkLabel_remove1.TabIndex = 8;
            this.linkLabel_remove1.TabStop = true;
            this.linkLabel_remove1.Text = "Remove";
            this.linkLabel_remove1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_remove1_LinkClicked);
            // 
            // linkLabel_remove2
            // 
            this.linkLabel_remove2.AutoSize = true;
            this.linkLabel_remove2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_remove2.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel_remove2.Location = new System.Drawing.Point(199, 223);
            this.linkLabel_remove2.Name = "linkLabel_remove2";
            this.linkLabel_remove2.Size = new System.Drawing.Size(47, 13);
            this.linkLabel_remove2.TabIndex = 9;
            this.linkLabel_remove2.TabStop = true;
            this.linkLabel_remove2.Text = "Remove";
            this.linkLabel_remove2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_remove2_LinkClicked);
            // 
            // linkLabel_remove3
            // 
            this.linkLabel_remove3.AutoSize = true;
            this.linkLabel_remove3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_remove3.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel_remove3.Location = new System.Drawing.Point(199, 265);
            this.linkLabel_remove3.Name = "linkLabel_remove3";
            this.linkLabel_remove3.Size = new System.Drawing.Size(47, 13);
            this.linkLabel_remove3.TabIndex = 10;
            this.linkLabel_remove3.TabStop = true;
            this.linkLabel_remove3.Text = "Remove";
            this.linkLabel_remove3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_remove3_LinkClicked);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(274, 9);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 15;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // listView_search
            // 
            this.listView_search.Location = new System.Drawing.Point(35, 49);
            this.listView_search.Name = "listView_search";
            this.listView_search.Size = new System.Drawing.Size(294, 206);
            this.listView_search.TabIndex = 14;
            this.listView_search.UseCompatibleStateImageBehavior = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(130, 9);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(128, 20);
            this.textBox_search.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Assign People";
            // 
            // panel_addpeople
            // 
            this.panel_addpeople.Controls.Add(this.button_search);
            this.panel_addpeople.Controls.Add(this.listView_search);
            this.panel_addpeople.Controls.Add(this.label4);
            this.panel_addpeople.Controls.Add(this.textBox_search);
            this.panel_addpeople.Location = new System.Drawing.Point(-1, 342);
            this.panel_addpeople.Name = "panel_addpeople";
            this.panel_addpeople.Size = new System.Drawing.Size(470, 263);
            this.panel_addpeople.TabIndex = 16;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(40, 301);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 17;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // Edit_Project_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 611);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.panel_addpeople);
            this.Controls.Add(this.linkLabel_remove3);
            this.Controls.Add(this.linkLabel_remove2);
            this.Controls.Add(this.linkLabel_remove1);
            this.Controls.Add(this.label_colab3);
            this.Controls.Add(this.label_colab2);
            this.Controls.Add(this.label_colab1);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Edit_Project_Info";
            this.Text = "Edit Project Info";
            this.Load += new System.EventHandler(this.Edit_Project_Info_Load);
            this.panel_addpeople.ResumeLayout(false);
            this.panel_addpeople.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label label_colab1;
        private System.Windows.Forms.Label label_colab2;
        private System.Windows.Forms.Label label_colab3;
        private System.Windows.Forms.LinkLabel linkLabel_remove1;
        private System.Windows.Forms.LinkLabel linkLabel_remove2;
        private System.Windows.Forms.LinkLabel linkLabel_remove3;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_addpeople;
        private System.Windows.Forms.Button button_edit;
    }
}