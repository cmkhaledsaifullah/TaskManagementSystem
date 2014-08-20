namespace UI
{
    partial class Add_Project
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
            this.textBox_projectname = new System.Windows.Forms.TextBox();
            this.richTextBox_projectdescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.listView_search = new System.Windows.Forms.ListView();
            this.listView_assaignedpeople = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.button_addproject = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Description";
            // 
            // textBox_projectname
            // 
            this.textBox_projectname.Location = new System.Drawing.Point(149, 50);
            this.textBox_projectname.Name = "textBox_projectname";
            this.textBox_projectname.Size = new System.Drawing.Size(293, 20);
            this.textBox_projectname.TabIndex = 3;
            // 
            // richTextBox_projectdescription
            // 
            this.richTextBox_projectdescription.Location = new System.Drawing.Point(149, 102);
            this.richTextBox_projectdescription.Name = "richTextBox_projectdescription";
            this.richTextBox_projectdescription.Size = new System.Drawing.Size(282, 88);
            this.richTextBox_projectdescription.TabIndex = 4;
            this.richTextBox_projectdescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assign People";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(132, 226);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(128, 20);
            this.textBox_search.TabIndex = 6;
            // 
            // listView_search
            // 
            this.listView_search.Location = new System.Drawing.Point(37, 266);
            this.listView_search.Name = "listView_search";
            this.listView_search.Size = new System.Drawing.Size(294, 273);
            this.listView_search.TabIndex = 7;
            this.listView_search.UseCompatibleStateImageBehavior = false;
            // 
            // listView_assaignedpeople
            // 
            this.listView_assaignedpeople.Location = new System.Drawing.Point(363, 266);
            this.listView_assaignedpeople.Name = "listView_assaignedpeople";
            this.listView_assaignedpeople.Size = new System.Drawing.Size(133, 273);
            this.listView_assaignedpeople.TabIndex = 8;
            this.listView_assaignedpeople.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Assigned People";
            // 
            // button_addproject
            // 
            this.button_addproject.Location = new System.Drawing.Point(363, 582);
            this.button_addproject.Name = "button_addproject";
            this.button_addproject.Size = new System.Drawing.Size(95, 23);
            this.button_addproject.TabIndex = 10;
            this.button_addproject.Text = "Add Project";
            this.button_addproject.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(276, 226);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Add_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 617);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_addproject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView_assaignedpeople);
            this.Controls.Add(this.listView_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_projectdescription);
            this.Controls.Add(this.textBox_projectname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Project";
            this.Text = "Add Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_projectname;
        private System.Windows.Forms.RichTextBox richTextBox_projectdescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.ListView listView_assaignedpeople;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_addproject;
        private System.Windows.Forms.Button button_search;
    }
}