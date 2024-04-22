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
            this.editDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bt_show_student = new System.Windows.Forms.Button();
            this.bt_show_teacher = new System.Windows.Forms.Button();
            this.bt_show_admin = new System.Windows.Forms.Button();
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCategory});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnCategory
            // 
            this.mnCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDataToolStripMenuItem,
            this.addDataToolStripMenuItem});
            this.mnCategory.Name = "mnCategory";
            this.mnCategory.Size = new System.Drawing.Size(67, 20);
            this.mnCategory.Text = "Category";
            this.mnCategory.Click += new System.EventHandler(this.mnCategory_Click);
            // 
            // editDataToolStripMenuItem
            // 
            this.editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            this.editDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editDataToolStripMenuItem.Text = "Edit Data ";
            this.editDataToolStripMenuItem.Click += new System.EventHandler(this.editDataToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(60, 201);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(861, 297);
            this.dataGridView.TabIndex = 1;
            // 
            // bt_show_student
            // 
            this.bt_show_student.Location = new System.Drawing.Point(297, 65);
            this.bt_show_student.Name = "bt_show_student";
            this.bt_show_student.Size = new System.Drawing.Size(415, 31);
            this.bt_show_student.TabIndex = 2;
            this.bt_show_student.Text = "Show Students";
            this.bt_show_student.UseVisualStyleBackColor = true;
            this.bt_show_student.Click += new System.EventHandler(this.bt_show_student_Click);
            // 
            // bt_show_teacher
            // 
            this.bt_show_teacher.Location = new System.Drawing.Point(297, 102);
            this.bt_show_teacher.Name = "bt_show_teacher";
            this.bt_show_teacher.Size = new System.Drawing.Size(415, 31);
            this.bt_show_teacher.TabIndex = 3;
            this.bt_show_teacher.Text = "Show Teachers";
            this.bt_show_teacher.UseVisualStyleBackColor = true;
            this.bt_show_teacher.Click += new System.EventHandler(this.bt_show_teacher_Click);
            // 
            // bt_show_admin
            // 
            this.bt_show_admin.Location = new System.Drawing.Point(297, 139);
            this.bt_show_admin.Name = "bt_show_admin";
            this.bt_show_admin.Size = new System.Drawing.Size(415, 31);
            this.bt_show_admin.TabIndex = 4;
            this.bt_show_admin.Text = "Show Admin";
            this.bt_show_admin.UseVisualStyleBackColor = true;
            this.bt_show_admin.Click += new System.EventHandler(this.bt_show_admin_Click);
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDataToolStripMenuItem.Text = "Add Data";
            // 
            // hrmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 528);
            this.Controls.Add(this.bt_show_admin);
            this.Controls.Add(this.bt_show_teacher);
            this.Controls.Add(this.bt_show_student);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "hrmmain";
            this.Text = "hrmmain";
            this.Load += new System.EventHandler(this.hrmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnCategory;
        private System.Windows.Forms.ToolStripMenuItem editDataToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bt_show_student;
        private System.Windows.Forms.Button bt_show_teacher;
        private System.Windows.Forms.Button bt_show_admin;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
    }
}