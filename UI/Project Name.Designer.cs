namespace UI
{
    partial class Project_Name
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
            this.button_edit = new System.Windows.Forms.Button();
            this.listView_todolist = new System.Windows.Forms.ListView();
            this.button_addtodolist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Collaborators:";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(334, 53);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Edit Info";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // listView_todolist
            // 
            this.listView_todolist.Location = new System.Drawing.Point(40, 201);
            this.listView_todolist.Name = "listView_todolist";
            this.listView_todolist.Size = new System.Drawing.Size(327, 127);
            this.listView_todolist.TabIndex = 4;
            this.listView_todolist.UseCompatibleStateImageBehavior = false;
            // 
            // button_addtodolist
            // 
            this.button_addtodolist.Location = new System.Drawing.Point(334, 361);
            this.button_addtodolist.Name = "button_addtodolist";
            this.button_addtodolist.Size = new System.Drawing.Size(88, 23);
            this.button_addtodolist.TabIndex = 5;
            this.button_addtodolist.Text = "Add To Do List";
            this.button_addtodolist.UseVisualStyleBackColor = true;
            // 
            // Project_Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 425);
            this.Controls.Add(this.button_addtodolist);
            this.Controls.Add(this.listView_todolist);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Project_Name";
            this.Text = "Project Name";
            this.Load += new System.EventHandler(this.Project_Name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.ListView listView_todolist;
        private System.Windows.Forms.Button button_addtodolist;
    }
}