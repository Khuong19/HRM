namespace HRM_App
{
    partial class hrmeditdata
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
            this.dataGridViewForEdit = new System.Windows.Forms.DataGridView();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_telephone = new System.Windows.Forms.Label();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_role = new System.Windows.Forms.Label();
            this.bt_modify = new System.Windows.Forms.Button();
            this.studentsTableAdapter1 = new HRM_App.Database1DataSetTableAdapters.StudentsTableAdapter();
            this.lb_student = new System.Windows.Forms.Label();
            this.lb_preSubject2 = new System.Windows.Forms.Label();
            this.tb_previousSubject2 = new System.Windows.Forms.TextBox();
            this.lb_preSubject1 = new System.Windows.Forms.Label();
            this.tb_previousSubject1 = new System.Windows.Forms.TextBox();
            this.lb_currentSubject2 = new System.Windows.Forms.Label();
            this.tb_currentSubject2 = new System.Windows.Forms.TextBox();
            this.lb_currentSubject1 = new System.Windows.Forms.Label();
            this.tb_currentSubject1 = new System.Windows.Forms.TextBox();
            this.lb_subject2 = new System.Windows.Forms.Label();
            this.tb_subject2 = new System.Windows.Forms.TextBox();
            this.lb_subject1 = new System.Windows.Forms.Label();
            this.tb_subject1 = new System.Windows.Forms.TextBox();
            this.lb_Tsalary = new System.Windows.Forms.Label();
            this.tb_Tsalary = new System.Windows.Forms.TextBox();
            this.lb_teacher = new System.Windows.Forms.Label();
            this.lb_workinghours = new System.Windows.Forms.Label();
            this.tb_workinghours = new System.Windows.Forms.TextBox();
            this.lb_Asalary = new System.Windows.Forms.Label();
            this.tb_Asalary = new System.Windows.Forms.TextBox();
            this.lb_admin = new System.Windows.Forms.Label();
            this.cb_employmentType = new System.Windows.Forms.ComboBox();
            this.lb_employmentType = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewForEdit
            // 
            this.dataGridViewForEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForEdit.Location = new System.Drawing.Point(366, 12);
            this.dataGridViewForEdit.Name = "dataGridViewForEdit";
            this.dataGridViewForEdit.Size = new System.Drawing.Size(422, 204);
            this.dataGridViewForEdit.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(112, 34);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(180, 20);
            this.tb_name.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(27, 38);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Name";
            // 
            // lb_telephone
            // 
            this.lb_telephone.AutoSize = true;
            this.lb_telephone.Location = new System.Drawing.Point(27, 73);
            this.lb_telephone.Name = "lb_telephone";
            this.lb_telephone.Size = new System.Drawing.Size(58, 13);
            this.lb_telephone.TabIndex = 4;
            this.lb_telephone.Text = "Telephone";
            // 
            // tb_telephone
            // 
            this.tb_telephone.Location = new System.Drawing.Point(112, 66);
            this.tb_telephone.Name = "tb_telephone";
            this.tb_telephone.Size = new System.Drawing.Size(180, 20);
            this.tb_telephone.TabIndex = 3;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(27, 103);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(32, 13);
            this.lb_email.TabIndex = 6;
            this.lb_email.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(112, 100);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(180, 20);
            this.tb_email.TabIndex = 5;
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Location = new System.Drawing.Point(27, 135);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(29, 13);
            this.lb_role.TabIndex = 8;
            this.lb_role.Text = "Role";
            // 
            // bt_modify
            // 
            this.bt_modify.Location = new System.Drawing.Point(422, 433);
            this.bt_modify.Name = "bt_modify";
            this.bt_modify.Size = new System.Drawing.Size(75, 23);
            this.bt_modify.TabIndex = 9;
            this.bt_modify.Text = "Modify";
            this.bt_modify.UseVisualStyleBackColor = true;
            this.bt_modify.Click += new System.EventHandler(this.bt_modify_Click);
            // 
            // studentsTableAdapter1
            // 
            this.studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // lb_student
            // 
            this.lb_student.AutoSize = true;
            this.lb_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_student.Location = new System.Drawing.Point(108, 258);
            this.lb_student.Name = "lb_student";
            this.lb_student.Size = new System.Drawing.Size(52, 16);
            this.lb_student.TabIndex = 10;
            this.lb_student.Text = "Student";
            // 
            // lb_preSubject2
            // 
            this.lb_preSubject2.AutoSize = true;
            this.lb_preSubject2.Location = new System.Drawing.Point(26, 438);
            this.lb_preSubject2.Name = "lb_preSubject2";
            this.lb_preSubject2.Size = new System.Drawing.Size(96, 13);
            this.lb_preSubject2.TabIndex = 18;
            this.lb_preSubject2.Text = "Previous Subject 2";
            // 
            // tb_previousSubject2
            // 
            this.tb_previousSubject2.Location = new System.Drawing.Point(121, 431);
            this.tb_previousSubject2.Name = "tb_previousSubject2";
            this.tb_previousSubject2.Size = new System.Drawing.Size(135, 20);
            this.tb_previousSubject2.TabIndex = 17;
            // 
            // lb_preSubject1
            // 
            this.lb_preSubject1.AutoSize = true;
            this.lb_preSubject1.Location = new System.Drawing.Point(26, 394);
            this.lb_preSubject1.Name = "lb_preSubject1";
            this.lb_preSubject1.Size = new System.Drawing.Size(96, 13);
            this.lb_preSubject1.TabIndex = 16;
            this.lb_preSubject1.Text = "Previous Subject 1";
            // 
            // tb_previousSubject1
            // 
            this.tb_previousSubject1.Location = new System.Drawing.Point(121, 387);
            this.tb_previousSubject1.Name = "tb_previousSubject1";
            this.tb_previousSubject1.Size = new System.Drawing.Size(135, 20);
            this.tb_previousSubject1.TabIndex = 15;
            // 
            // lb_currentSubject2
            // 
            this.lb_currentSubject2.AutoSize = true;
            this.lb_currentSubject2.Location = new System.Drawing.Point(26, 347);
            this.lb_currentSubject2.Name = "lb_currentSubject2";
            this.lb_currentSubject2.Size = new System.Drawing.Size(89, 13);
            this.lb_currentSubject2.TabIndex = 14;
            this.lb_currentSubject2.Text = "Current Subject 2";
            // 
            // tb_currentSubject2
            // 
            this.tb_currentSubject2.Location = new System.Drawing.Point(121, 340);
            this.tb_currentSubject2.Name = "tb_currentSubject2";
            this.tb_currentSubject2.Size = new System.Drawing.Size(135, 20);
            this.tb_currentSubject2.TabIndex = 13;
            // 
            // lb_currentSubject1
            // 
            this.lb_currentSubject1.AutoSize = true;
            this.lb_currentSubject1.Location = new System.Drawing.Point(26, 305);
            this.lb_currentSubject1.Name = "lb_currentSubject1";
            this.lb_currentSubject1.Size = new System.Drawing.Size(89, 13);
            this.lb_currentSubject1.TabIndex = 12;
            this.lb_currentSubject1.Text = "Current Subject 1";
            // 
            // tb_currentSubject1
            // 
            this.tb_currentSubject1.Location = new System.Drawing.Point(121, 298);
            this.tb_currentSubject1.Name = "tb_currentSubject1";
            this.tb_currentSubject1.Size = new System.Drawing.Size(135, 20);
            this.tb_currentSubject1.TabIndex = 11;
            // 
            // lb_subject2
            // 
            this.lb_subject2.AutoSize = true;
            this.lb_subject2.Location = new System.Drawing.Point(302, 397);
            this.lb_subject2.Name = "lb_subject2";
            this.lb_subject2.Size = new System.Drawing.Size(52, 13);
            this.lb_subject2.TabIndex = 25;
            this.lb_subject2.Text = "Subject 2";
            // 
            // tb_subject2
            // 
            this.tb_subject2.Location = new System.Drawing.Point(362, 391);
            this.tb_subject2.Name = "tb_subject2";
            this.tb_subject2.Size = new System.Drawing.Size(135, 20);
            this.tb_subject2.TabIndex = 24;
            // 
            // lb_subject1
            // 
            this.lb_subject1.AutoSize = true;
            this.lb_subject1.Location = new System.Drawing.Point(302, 350);
            this.lb_subject1.Name = "lb_subject1";
            this.lb_subject1.Size = new System.Drawing.Size(52, 13);
            this.lb_subject1.TabIndex = 23;
            this.lb_subject1.Text = "Subject 1";
            // 
            // tb_subject1
            // 
            this.tb_subject1.Location = new System.Drawing.Point(362, 344);
            this.tb_subject1.Name = "tb_subject1";
            this.tb_subject1.Size = new System.Drawing.Size(135, 20);
            this.tb_subject1.TabIndex = 22;
            // 
            // lb_Tsalary
            // 
            this.lb_Tsalary.AutoSize = true;
            this.lb_Tsalary.Location = new System.Drawing.Point(302, 308);
            this.lb_Tsalary.Name = "lb_Tsalary";
            this.lb_Tsalary.Size = new System.Drawing.Size(36, 13);
            this.lb_Tsalary.TabIndex = 21;
            this.lb_Tsalary.Text = "Salary";
            // 
            // tb_Tsalary
            // 
            this.tb_Tsalary.Location = new System.Drawing.Point(362, 302);
            this.tb_Tsalary.Name = "tb_Tsalary";
            this.tb_Tsalary.Size = new System.Drawing.Size(135, 20);
            this.tb_Tsalary.TabIndex = 20;
            // 
            // lb_teacher
            // 
            this.lb_teacher.AutoSize = true;
            this.lb_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_teacher.Location = new System.Drawing.Point(384, 261);
            this.lb_teacher.Name = "lb_teacher";
            this.lb_teacher.Size = new System.Drawing.Size(58, 16);
            this.lb_teacher.TabIndex = 19;
            this.lb_teacher.Text = "Teacher";
            // 
            // lb_workinghours
            // 
            this.lb_workinghours.AutoSize = true;
            this.lb_workinghours.Location = new System.Drawing.Point(542, 400);
            this.lb_workinghours.Name = "lb_workinghours";
            this.lb_workinghours.Size = new System.Drawing.Size(76, 13);
            this.lb_workinghours.TabIndex = 32;
            this.lb_workinghours.Text = "Working hours";
            // 
            // tb_workinghours
            // 
            this.tb_workinghours.Location = new System.Drawing.Point(635, 394);
            this.tb_workinghours.Name = "tb_workinghours";
            this.tb_workinghours.Size = new System.Drawing.Size(135, 20);
            this.tb_workinghours.TabIndex = 31;
            // 
            // lb_Asalary
            // 
            this.lb_Asalary.AutoSize = true;
            this.lb_Asalary.Location = new System.Drawing.Point(542, 310);
            this.lb_Asalary.Name = "lb_Asalary";
            this.lb_Asalary.Size = new System.Drawing.Size(36, 13);
            this.lb_Asalary.TabIndex = 28;
            this.lb_Asalary.Text = "Salary";
            // 
            // tb_Asalary
            // 
            this.tb_Asalary.Location = new System.Drawing.Point(635, 304);
            this.tb_Asalary.Name = "tb_Asalary";
            this.tb_Asalary.Size = new System.Drawing.Size(135, 20);
            this.tb_Asalary.TabIndex = 27;
            // 
            // lb_admin
            // 
            this.lb_admin.AutoSize = true;
            this.lb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_admin.Location = new System.Drawing.Point(621, 263);
            this.lb_admin.Name = "lb_admin";
            this.lb_admin.Size = new System.Drawing.Size(91, 16);
            this.lb_admin.TabIndex = 26;
            this.lb_admin.Text = "Administration";
            // 
            // cb_employmentType
            // 
            this.cb_employmentType.FormattingEnabled = true;
            this.cb_employmentType.Items.AddRange(new object[] {
            "Fulltime",
            "Parttime"});
            this.cb_employmentType.Location = new System.Drawing.Point(635, 346);
            this.cb_employmentType.Name = "cb_employmentType";
            this.cb_employmentType.Size = new System.Drawing.Size(121, 21);
            this.cb_employmentType.TabIndex = 33;
            // 
            // lb_employmentType
            // 
            this.lb_employmentType.AutoSize = true;
            this.lb_employmentType.Location = new System.Drawing.Point(542, 352);
            this.lb_employmentType.Name = "lb_employmentType";
            this.lb_employmentType.Size = new System.Drawing.Size(91, 13);
            this.lb_employmentType.TabIndex = 34;
            this.lb_employmentType.Text = "Employment Type";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(514, 433);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 35;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(609, 433);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 36;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "Teacher",
            "Student"});
            this.cb_role.Location = new System.Drawing.Point(112, 132);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(121, 21);
            this.cb_role.TabIndex = 37;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(27, 162);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(55, 13);
            this.lb_username.TabIndex = 39;
            this.lb_username.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(112, 159);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(180, 20);
            this.tb_username.TabIndex = 38;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(26, 188);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 13);
            this.lb_password.TabIndex = 41;
            this.lb_password.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(111, 185);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(180, 20);
            this.tb_password.TabIndex = 40;
            // 
            // hrmeditdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.lb_employmentType);
            this.Controls.Add(this.cb_employmentType);
            this.Controls.Add(this.lb_workinghours);
            this.Controls.Add(this.tb_workinghours);
            this.Controls.Add(this.lb_Asalary);
            this.Controls.Add(this.tb_Asalary);
            this.Controls.Add(this.lb_admin);
            this.Controls.Add(this.lb_subject2);
            this.Controls.Add(this.tb_subject2);
            this.Controls.Add(this.lb_subject1);
            this.Controls.Add(this.tb_subject1);
            this.Controls.Add(this.lb_Tsalary);
            this.Controls.Add(this.tb_Tsalary);
            this.Controls.Add(this.lb_teacher);
            this.Controls.Add(this.lb_preSubject2);
            this.Controls.Add(this.tb_previousSubject2);
            this.Controls.Add(this.lb_preSubject1);
            this.Controls.Add(this.tb_previousSubject1);
            this.Controls.Add(this.lb_currentSubject2);
            this.Controls.Add(this.tb_currentSubject2);
            this.Controls.Add(this.lb_currentSubject1);
            this.Controls.Add(this.tb_currentSubject1);
            this.Controls.Add(this.lb_student);
            this.Controls.Add(this.bt_modify);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_telephone);
            this.Controls.Add(this.tb_telephone);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.dataGridViewForEdit);
            this.Name = "hrmeditdata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit users information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewForEdit;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_telephone;
        private System.Windows.Forms.TextBox tb_telephone;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Button bt_modify;
        private Database1DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter1;
        private System.Windows.Forms.Label lb_student;
        private System.Windows.Forms.Label lb_preSubject2;
        private System.Windows.Forms.TextBox tb_previousSubject2;
        private System.Windows.Forms.Label lb_preSubject1;
        private System.Windows.Forms.TextBox tb_previousSubject1;
        private System.Windows.Forms.Label lb_currentSubject2;
        private System.Windows.Forms.TextBox tb_currentSubject2;
        private System.Windows.Forms.Label lb_currentSubject1;
        private System.Windows.Forms.TextBox tb_currentSubject1;
        private System.Windows.Forms.Label lb_subject2;
        private System.Windows.Forms.TextBox tb_subject2;
        private System.Windows.Forms.Label lb_subject1;
        private System.Windows.Forms.TextBox tb_subject1;
        private System.Windows.Forms.Label lb_Tsalary;
        private System.Windows.Forms.TextBox tb_Tsalary;
        private System.Windows.Forms.Label lb_teacher;
        private System.Windows.Forms.Label lb_workinghours;
        private System.Windows.Forms.TextBox tb_workinghours;
        private System.Windows.Forms.Label lb_Asalary;
        private System.Windows.Forms.TextBox tb_Asalary;
        private System.Windows.Forms.Label lb_admin;
        private System.Windows.Forms.ComboBox cb_employmentType;
        private System.Windows.Forms.Label lb_employmentType;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_password;
    }
}