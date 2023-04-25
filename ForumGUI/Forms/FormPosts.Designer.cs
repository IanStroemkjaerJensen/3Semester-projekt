﻿namespace ForumGUI.Forms
{
    partial class FormPosts
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.btnTopics = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHomeMenuBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.btnShowTopics = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHomeMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnProfiles);
            this.panelMenu.Controls.Add(this.btnPosts);
            this.panelMenu.Controls.Add(this.btnTopics);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(0, 260);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnProfiles
            // 
            this.btnProfiles.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProfiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfiles.FlatAppearance.BorderSize = 0;
            this.btnProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiles.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfiles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfiles.Location = new System.Drawing.Point(0, 200);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Size = new System.Drawing.Size(220, 60);
            this.btnProfiles.TabIndex = 3;
            this.btnProfiles.Text = "Profiles";
            this.btnProfiles.UseVisualStyleBackColor = false;
            // 
            // btnPosts
            // 
            this.btnPosts.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPosts.FlatAppearance.BorderSize = 0;
            this.btnPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosts.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPosts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPosts.Location = new System.Drawing.Point(0, 140);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(220, 60);
            this.btnPosts.TabIndex = 2;
            this.btnPosts.Text = "Posts";
            this.btnPosts.UseVisualStyleBackColor = false;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // btnTopics
            // 
            this.btnTopics.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTopics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTopics.FlatAppearance.BorderSize = 0;
            this.btnTopics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopics.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTopics.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTopics.Location = new System.Drawing.Point(0, 80);
            this.btnTopics.Name = "btnTopics";
            this.btnTopics.Size = new System.Drawing.Size(220, 60);
            this.btnTopics.TabIndex = 1;
            this.btnTopics.Text = "Topics";
            this.btnTopics.UseVisualStyleBackColor = false;
            this.btnTopics.Click += new System.EventHandler(this.btnTopics_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Navy;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forum";
            // 
            // panelHomeMenuBar
            // 
            this.panelHomeMenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHomeMenuBar.Controls.Add(this.label2);
            this.panelHomeMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeMenuBar.Location = new System.Drawing.Point(220, 0);
            this.panelHomeMenuBar.Name = "panelHomeMenuBar";
            this.panelHomeMenuBar.Size = new System.Drawing.Size(764, 80);
            this.panelHomeMenuBar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(308, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "POSTS";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 15;
            this.listBoxPosts.Location = new System.Drawing.Point(220, 80);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(764, 481);
            this.listBoxPosts.TabIndex = 4;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.getListBoxPosts);
            // 
            // btnShowTopics
            // 
            this.btnShowTopics.Location = new System.Drawing.Point(491, 512);
            this.btnShowTopics.Name = "btnShowTopics";
            this.btnShowTopics.Size = new System.Drawing.Size(170, 37);
            this.btnShowTopics.TabIndex = 5;
            this.btnShowTopics.Text = "Show all";
            this.btnShowTopics.UseVisualStyleBackColor = true;
            this.btnShowTopics.Click += new System.EventHandler(this.btnShowTopics_Click);
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnShowTopics);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.panelHomeMenuBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPosts";
            this.Text = "FormPosts";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHomeMenuBar.ResumeLayout(false);
            this.panelHomeMenuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnHome;
        private Button btnProfiles;
        private Button btnPosts;
        private Button btnTopics;
        private Panel panelHomeMenuBar;
        private Label label2;
        private ListBox listBoxPosts;
        private Button btnShowTopics;
        private Button button2;
        private Button button3;
        private Panel panelLogo;
        private Label label1;
    }
}