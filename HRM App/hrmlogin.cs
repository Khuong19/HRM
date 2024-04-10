using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_App
{
    public partial class hrmlogin : Form
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
        public string isAdmin = "-1";
        public hrmlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check for tb_username and tb_password are empty or not
            if (tb_username != null && tb_username.Text.Trim() != "") { }
            else
            {
                MessageBox.Show("Please enter username!");
                tb_username.Focus(); //Enter the text without clicking mouse on it
                return;
            }
            if (tb_password != null && tb_password.Text.Trim() != "") { }
            else
            {
                MessageBox.Show("Please enter password!");
                tb_password.Focus(); //Enter the text without clicking mouse on it
                return;
            }
            //Compare user login information to the data in login table
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string Username = username_text.Text.Trim();
            string Password = password_text.Text.Trim();
            string query = "SELECT * FROM Account WHERE username = '" + Username + "' AND password = '" + Password + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                isAdmin = ds.Tables[0].Rows[0]["admin"].ToString();
                hrmmain _hrmmain = new hrmmain(isAdmin);
                _hrmmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check the username or password again");
            }


        }
    }
}