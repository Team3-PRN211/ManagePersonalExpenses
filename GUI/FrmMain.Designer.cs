namespace GUI
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbRecord = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pbSubCategory = new System.Windows.Forms.PictureBox();
            this.pbStatictis = new System.Windows.Forms.PictureBox();
            this.pbCategory = new System.Windows.Forms.PictureBox();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatictis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRecord,
            this.subCategoryToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.staticToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemRecord
            // 
            this.toolStripMenuItemRecord.Name = "toolStripMenuItemRecord";
            this.toolStripMenuItemRecord.Size = new System.Drawing.Size(70, 24);
            this.toolStripMenuItemRecord.Text = "Record";
            this.toolStripMenuItemRecord.Click += new System.EventHandler(this.toolStripMenuItemRecord_Click);
            // 
            // subCategoryToolStripMenuItem
            // 
            this.subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            this.subCategoryToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.subCategoryToolStripMenuItem.Text = "SubCategory";
            this.subCategoryToolStripMenuItem.Click += new System.EventHandler(this.subCategoryToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.staticToolStripMenuItem.Text = "Report";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.staticToolStripMenuItem_Click);
            // 
            // pbRecord
            // 
            this.pbRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbRecord.Image = global::GUI.Properties.Resources.expense_manager_22;
            this.pbRecord.Location = new System.Drawing.Point(169, 115);
            this.pbRecord.Name = "pbRecord";
            this.pbRecord.Size = new System.Drawing.Size(95, 91);
            this.pbRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecord.TabIndex = 1;
            this.pbRecord.TabStop = false;
            this.pbRecord.Click += new System.EventHandler(this.pbRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to personal expense management software";
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::GUI.Properties.Resources._3135715;
            this.pbProfile.Location = new System.Drawing.Point(144, 311);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(160, 93);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 3;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.pbProfile_Click);
            // 
            // pbSubCategory
            // 
            this.pbSubCategory.Image = global::GUI.Properties.Resources._285920;
            this.pbSubCategory.Location = new System.Drawing.Point(521, 115);
            this.pbSubCategory.Name = "pbSubCategory";
            this.pbSubCategory.Size = new System.Drawing.Size(142, 91);
            this.pbSubCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubCategory.TabIndex = 4;
            this.pbSubCategory.TabStop = false;
            this.pbSubCategory.Click += new System.EventHandler(this.pbSubCategory_Click);
            // 
            // pbStatictis
            // 
            this.pbStatictis.Image = global::GUI.Properties.Resources._305_3057506_redclick_icons_stats_stats_icon;
            this.pbStatictis.Location = new System.Drawing.Point(329, 210);
            this.pbStatictis.Name = "pbStatictis";
            this.pbStatictis.Size = new System.Drawing.Size(149, 86);
            this.pbStatictis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStatictis.TabIndex = 5;
            this.pbStatictis.TabStop = false;
            this.pbStatictis.Click += new System.EventHandler(this.pbStatictis_Click);
            // 
            // pbCategory
            // 
            this.pbCategory.Image = global::GUI.Properties.Resources._255_2554213_noc_category_icon_file_manager;
            this.pbCategory.Location = new System.Drawing.Point(521, 311);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(142, 93);
            this.pbCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCategory.TabIndex = 6;
            this.pbCategory.TabStop = false;
            this.pbCategory.Click += new System.EventHandler(this.pbCategory_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCategory);
            this.Controls.Add(this.pbStatictis);
            this.Controls.Add(this.pbSubCategory);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRecord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatictis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRecord;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.PictureBox pbSubCategory;
        private System.Windows.Forms.PictureBox pbStatictis;
        private System.Windows.Forms.PictureBox pbCategory;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}