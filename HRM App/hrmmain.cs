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
    public partial class hrmmain : Form
    {
        public hrmmain(string isAdmin)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            if (isAdmin == "True") { 
                mnCategory.Enabled = true;
            }
            else
            {
                mnCategory.Enabled = false;
            }

        }

        private void hrmmain_Load(object sender, EventArgs e)
        {

        }

        private void editDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the hrmeditdata form
            hrmeditdata _hrmeditdata = new hrmeditdata();

            // Set its MdiParent property to null to show it as a top-level form
            _hrmeditdata.MdiParent = null;

            // Show the hrmeditdata form
            _hrmeditdata.Show();

            // Hide the hrmmain form
            this.Hide();
            // Attach the FormClosed event handler
            _hrmeditdata.FormClosed += Hrmeditdata_FormClosed;
        }
        private void Hrmeditdata_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the hrmmain form when the hrmeditdata form is closed
            this.Show();
        }

        private void mnCategory_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_show_student_Click(object sender, EventArgs e)
        {
           
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\khuon\Desktop\HRM App\HRM App\Database1.mdf"";Integrated Security=True";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"
                    SELECT 
                        u.Name, u.Telephone, u.Email, u.Role,
                        s.Current_Subject1, s.Current_Subject2, s.Previous_Subject1, s.Previous_Subject2                       
                    FROM 
                        Users AS u
                    INNER JOIN 
                        Students AS s          
                    ON 
                        u.UserId = s.UserId";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
        }

        private void bt_show_teacher_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\khuon\Desktop\HRM App\HRM App\Database1.mdf"";Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        u.Name, u.Telephone, u.Email, u.Role,
                        t.Subject1, t.Subject2, t.Salary                       
                    FROM 
                        Users AS u
                    INNER JOIN 
                        Teaching_Staff AS t          
                    ON 
                        u.UserId = t.UserId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bt_show_admin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\khuon\Desktop\HRM App\HRM App\Database1.mdf"";Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    u.Name, u.Telephone, u.Email, u.Role,
                    a.Salary, a.EmploymentType, a.Working_Hours
                FROM 
                    Users AS u
                INNER JOIN 
                    Administration AS a          
                ON 
                    u.UserId = a.UserId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
