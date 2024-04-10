namespace HRM_App
{
    partial class hrmlogin
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(303, 164);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(181, 20);
            this.tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(303, 212);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(181, 20);
            this.tb_password.TabIndex = 1;
            // 
            // username_text
            // 
            this.username_text.AutoSize = true;
            this.username_text.Location = new System.Drawing.Point(229, 167);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(55, 13);
            this.username_text.TabIndex = 2;
            this.username_text.Text = "Username";
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Location = new System.Drawing.Point(229, 215);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(53, 13);
            this.password_text.TabIndex = 3;
            this.password_text.Text = "Password";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(303, 269);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(103, 35);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Log in";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // hrmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Name = "hrmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in to the system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label username_text;
        private System.Windows.Forms.Label password_text;
        private System.Windows.Forms.Button bt_login;
    }
}

