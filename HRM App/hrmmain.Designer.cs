namespace HRM_App
{
    partial class hrmmain
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
            this.mnCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.showInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataByGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCategory});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnCategory
            // 
            this.mnCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInformationToolStripMenuItem,
            this.showDataByGroupsToolStripMenuItem});
            this.mnCategory.Name = "mnCategory";
            this.mnCategory.Size = new System.Drawing.Size(67, 20);
            this.mnCategory.Text = "Category";
            // 
            // showInformationToolStripMenuItem
            // 
            this.showInformationToolStripMenuItem.Name = "showInformationToolStripMenuItem";
            this.showInformationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.showInformationToolStripMenuItem.Text = "Show all users information";
            // 
            // showDataByGroupsToolStripMenuItem
            // 
            this.showDataByGroupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.administraToolStripMenuItem});
            this.showDataByGroupsToolStripMenuItem.Name = "showDataByGroupsToolStripMenuItem";
            this.showDataByGroupsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.showDataByGroupsToolStripMenuItem.Text = "Show data by groups";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teachersToolStripMenuItem.Text = "Teachers";
            // 
            // administraToolStripMenuItem
            // 
            this.administraToolStripMenuItem.Name = "administraToolStripMenuItem";
            this.administraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administraToolStripMenuItem.Text = "Administration";
            // 
            // hrmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "hrmmain";
            this.Text = "hrmmain";
            this.Load += new System.EventHandler(this.hrmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnCategory;
        private System.Windows.Forms.ToolStripMenuItem showInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataByGroupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraToolStripMenuItem;
    }
}