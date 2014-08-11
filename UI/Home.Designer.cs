namespace UI
{
    partial class Home
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
            this.menuStrip_home = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_home = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_profile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_viewprofile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_editprofile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_changepassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_project = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_addproject = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_editproject = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_showproject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_home.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_home
            // 
            this.menuStrip_home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_home,
            this.ToolStripMenuItem_profile,
            this.ToolStripMenuItem_project});
            this.menuStrip_home.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_home.Name = "menuStrip_home";
            this.menuStrip_home.Size = new System.Drawing.Size(542, 24);
            this.menuStrip_home.TabIndex = 0;
            this.menuStrip_home.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_home
            // 
            this.ToolStripMenuItem_home.Name = "ToolStripMenuItem_home";
            this.ToolStripMenuItem_home.Size = new System.Drawing.Size(52, 20);
            this.ToolStripMenuItem_home.Text = "Home";
            // 
            // ToolStripMenuItem_profile
            // 
            this.ToolStripMenuItem_profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_viewprofile,
            this.ToolStripMenuItem_editprofile,
            this.ToolStripMenuItem_changepassword});
            this.ToolStripMenuItem_profile.Name = "ToolStripMenuItem_profile";
            this.ToolStripMenuItem_profile.Size = new System.Drawing.Size(53, 20);
            this.ToolStripMenuItem_profile.Text = "Profile";
            // 
            // ToolStripMenuItem_viewprofile
            // 
            this.ToolStripMenuItem_viewprofile.Name = "ToolStripMenuItem_viewprofile";
            this.ToolStripMenuItem_viewprofile.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItem_viewprofile.Text = "View Profile";
            this.ToolStripMenuItem_viewprofile.Click += new System.EventHandler(this.ToolStripMenuItem_viewprofile_Click);
            // 
            // ToolStripMenuItem_editprofile
            // 
            this.ToolStripMenuItem_editprofile.Name = "ToolStripMenuItem_editprofile";
            this.ToolStripMenuItem_editprofile.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItem_editprofile.Text = "Edit Profile";
            this.ToolStripMenuItem_editprofile.Click += new System.EventHandler(this.ToolStripMenuItem_editprofile_Click);
            // 
            // ToolStripMenuItem_changepassword
            // 
            this.ToolStripMenuItem_changepassword.Name = "ToolStripMenuItem_changepassword";
            this.ToolStripMenuItem_changepassword.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItem_changepassword.Text = "Change Password";
            this.ToolStripMenuItem_changepassword.Click += new System.EventHandler(this.ToolStripMenuItem_changepassword_Click);
            // 
            // ToolStripMenuItem_project
            // 
            this.ToolStripMenuItem_project.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_addproject,
            this.ToolStripMenuItem_editproject,
            this.ToolStripMenuItem_showproject});
            this.ToolStripMenuItem_project.Name = "ToolStripMenuItem_project";
            this.ToolStripMenuItem_project.Size = new System.Drawing.Size(56, 20);
            this.ToolStripMenuItem_project.Text = "Project";
            // 
            // ToolStripMenuItem_addproject
            // 
            this.ToolStripMenuItem_addproject.Name = "ToolStripMenuItem_addproject";
            this.ToolStripMenuItem_addproject.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_addproject.Text = "Add Project";
            // 
            // ToolStripMenuItem_editproject
            // 
            this.ToolStripMenuItem_editproject.Name = "ToolStripMenuItem_editproject";
            this.ToolStripMenuItem_editproject.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_editproject.Text = "Edit Project";
            // 
            // ToolStripMenuItem_showproject
            // 
            this.ToolStripMenuItem_showproject.Name = "ToolStripMenuItem_showproject";
            this.ToolStripMenuItem_showproject.Size = new System.Drawing.Size(184, 22);
            this.ToolStripMenuItem_showproject.Text = "Show Project History";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 383);
            this.Controls.Add(this.menuStrip_home);
            this.MainMenuStrip = this.menuStrip_home;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip_home.ResumeLayout(false);
            this.menuStrip_home.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_home;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_home;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_profile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_viewprofile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_editprofile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_changepassword;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_project;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_addproject;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_editproject;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_showproject;
    }
}