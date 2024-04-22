using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_App
{
    public partial class hrmeditdata : Form
    {
        public hrmeditdata()
        {
            InitializeComponent();
            load_data(null, null);

        }
        public void load_data(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\khuon\Desktop\HRM App\HRM App\Database1.mdf"";Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        ac.username, ac.password,
                        u.Name, u.Telephone, u.Email, u.Role,
                        s.Current_Subject1, s.Current_Subject2, s.Previous_Subject1, s.Previous_Subject2,
                        a.Salary, a.EmploymentType, a.Working_Hours,
                        t.Subject1, t.Subject2, t.Salary
                    FROM 
                        Users AS u
                    FULL JOIN 
                        (SELECT UserId, Current_Subject1, Current_Subject2, Previous_Subject1, Previous_Subject2 FROM Students) AS s
                    ON 
                        u.UserId = s.UserId
                    FULL JOIN
                        (SELECT UserId, username, password FROM Account) AS ac
                    ON 
                        u.UserId = ac.UserId
                    FULL JOIN 
                        (SELECT UserId, Salary, EmploymentType, Working_Hours FROM Administration) AS a
                    ON 
                        u.UserId = a.UserId
                    FULL JOIN
                        (SELECT UserId, Subject1, Subject2, Salary FROM teaching_staff) AS t
                    ON
                        u.UserId = t.UserId";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewForEdit.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            dataGridViewForEdit.SelectionChanged += select_row;
        }
        public void select_row(object sender, EventArgs e)
        {
            if (dataGridViewForEdit.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewForEdit.SelectedRows[0];

                tb_name.Text = selectedRow.Cells["Name"].Value.ToString();
                tb_telephone.Text = selectedRow.Cells["Telephone"].Value.ToString();
                tb_email.Text = selectedRow.Cells["Email"].Value.ToString();
                cb_role.Text = selectedRow.Cells["Role"].Value.ToString();
                tb_username.Text = selectedRow.Cells["username"].Value.ToString();
                tb_password.Text = selectedRow.Cells["username"].Value.ToString();

                ClearDataFields();

                // Check role and show specific data fields
                string role = cb_role.Text.ToLower(); // Convert role to lowercase for easier comparison
                switch (role)
                {
                    case "student":
                        ShowStudentData(selectedRow);
                        break;
                    case "teacher":
                        ShowTeacherData(selectedRow);
                        break;
                    case "admin":
                        ShowAdminData(selectedRow);
                        break;
                    default:
                        ClearDataFields(); // Clear data fields if role is not recognized
                        break;
                }

            }
            else
            {
                ClearDataFields();
            }

        }

        private void ShowStudentData(DataGridViewRow row)
        {
            // Assuming CurrentSubject1, CurrentSubject2, PreviousSubject1, and PreviousSubject2 are columns in the DataGridView
            if (row.Cells["Current_Subject1"].Value != DBNull.Value)
            {
                tb_currentSubject1.Text = row.Cells["Current_Subject1"].Value.ToString();
            }
            else
            {
                tb_currentSubject1.Text = "";
            }

            if (row.Cells["Current_Subject2"].Value != DBNull.Value)
            {
                tb_currentSubject2.Text = row.Cells["Current_Subject2"].Value.ToString();
            }
            else
            {
                tb_currentSubject2.Text = "";
            }

            if (row.Cells["Previous_Subject1"].Value != DBNull.Value)
            {
                tb_previousSubject1.Text = row.Cells["Previous_Subject1"].Value.ToString();
            }
            else
            {
                tb_previousSubject1.Text = "";
            }

            if (row.Cells["Previous_Subject2"].Value != DBNull.Value)
            {
                tb_previousSubject2.Text = row.Cells["Previous_Subject2"].Value.ToString();
            }
            else
            {
                tb_previousSubject2.Text = "";
            }
        }

        private void ShowAdminData(DataGridViewRow row)
        {
            // Assuming Salary, EmploymentType, and WorkingHours are columns in the DataGridView
            if (row.Cells["Salary"].Value != DBNull.Value)
            {
                tb_Asalary.Text = row.Cells["Salary"].Value.ToString();
            }
            else
            {
                tb_Asalary.Text = "";
            }

            if (row.Cells["EmploymentType"].Value != DBNull.Value)
            {
                cb_employmentType.Text = row.Cells["EmploymentType"].Value.ToString();
            }
            else
            {
                cb_employmentType.Text = "";
            }

            if (row.Cells["Working_Hours"].Value != DBNull.Value)
            {
                tb_workinghours.Text = row.Cells["Working_Hours"].Value.ToString();
            }
            else
            {
                tb_workinghours.Text = "";
            }
        }

        private void ShowTeacherData(DataGridViewRow row)
        {
            // Assuming Salary and Subjects are columns in the DataGridView
            if (row.Cells["Salary"].Value != DBNull.Value)
            {
                tb_Tsalary.Text = row.Cells["Salary"].Value.ToString();
            }
            else
            {
                tb_Tsalary.Text = "";
            }

            if (row.Cells["Subject1"].Value != DBNull.Value)
            {
                tb_subject1.Text = row.Cells["Subject1"].Value.ToString();
            }
            else
            {
                tb_subject1.Text = "";
            }

            if (row.Cells["Subject2"].Value != DBNull.Value)
            {
                tb_subject2.Text = row.Cells["Subject2"].Value.ToString();
            }
            else
            {
                tb_subject2.Text = "";
            }
        }


        private void ClearDataFields()
        {
            // Clear all text boxes
            tb_currentSubject1.Text = "";
            tb_currentSubject2.Text = "";
            tb_previousSubject1.Text = "";
            tb_previousSubject2.Text = "";
            tb_Asalary.Text = "";
            tb_subject1.Text = "";
            tb_Tsalary.Text = "";
            tb_subject2.Text = "";
            cb_employmentType.SelectedIndex = 0;
            tb_workinghours.Text = "";
        }




        private void bt_modify_Click(object sender, EventArgs e)
        {
            if (dataGridViewForEdit.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewForEdit.SelectedRows[0];

                // Retrieve common data from textboxes
                string name = tb_name.Text;
                int telephone = Convert.ToInt32(tb_telephone.Text);
                string role = cb_role.Text;
                string email = tb_email.Text;

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\khuon\Desktop\HRM App\HRM App\Database1.mdf"";Integrated Security=True";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "";

                        // Retrieve UserId based on selected name
                        query = "SELECT UserId FROM Users WHERE Name = @Name";
                        SqlCommand getUserIdCommand = new SqlCommand(query, connection);
                        getUserIdCommand.Parameters.AddWithValue("@Name", name);
                        int userId = Convert.ToInt32(getUserIdCommand.ExecuteScalar());

                        // Update query based on role
                        switch (role.ToLower())
                        {
                            case "student":
                                query = "UPDATE Students SET Current_Subject1 = @Current_Subject1, Current_Subject2 = @Current_Subject2, Previous_Subject1 = @Previous_Subject1, Previous_Subject2 = @Previous_Subject2 WHERE UserId = @UserId";
                                break;
                            case "teacher":
                                query = "UPDATE Teachers SET Salary = @Salary, Subject1 = @Subject1, Subject2 = @Subject2 WHERE UserId = @UserId";
                                break;
                            case "admin":
                                query = "UPDATE Administration SET Salary = @Salary, EmploymentType = @EmploymentType, Working_Hours = @Working_Hours WHERE UserId = @UserId";
                                break;
                        }

                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters based on role
                        switch (role.ToLower())
                        {
                            case "student":
                                command.Parameters.AddWithValue("@Current_Subject1", tb_currentSubject1.Text);
                                command.Parameters.AddWithValue("@Current_Subject2", tb_currentSubject2.Text);
                                command.Parameters.AddWithValue("@Previous_Subject1", tb_previousSubject1.Text);
                                command.Parameters.AddWithValue("@Previous_Subject2", tb_previousSubject2.Text);
                                break;
                            case "teacher":
                                command.Parameters.AddWithValue("@Salary", Convert.ToDecimal(tb_Tsalary.Text));
                                command.Parameters.AddWithValue("@Subject1", tb_subject1.Text);
                                command.Parameters.AddWithValue("@Subject2", tb_subject2.Text);
                                break;
                            case "admin":
                                command.Parameters.AddWithValue("@Salary", Convert.ToDecimal(tb_Asalary.Text));
                                command.Parameters.AddWithValue("@EmploymentType", cb_employmentType.Text);
                                command.Parameters.AddWithValue("@Working_Hours", Convert.ToInt32(tb_workinghours.Text));
                                break;
                        }

                        command.Parameters.AddWithValue("@UserId", userId);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error : {ex.Message}");
                }
                load_data(null, null);
            }
        }


        private void bt_add_Click(object sender, EventArgs e)
        {
            // Retrieve user input from textboxes
            string name = tb_name.Text;
            string telephone = tb_telephone.Text;
            string email = tb_email.Text;
            string role = cb_role.Text;
            string username = tb_username.Text;
            string password = tb_password.Text;
           

            // Additional data based on role
            string currentSubject1 = tb_currentSubject1.Text;
            string currentSubject2 = tb_currentSubject2.Text;
            string previousSubject1 = tb_previousSubject1.Text;
            string previousSubject2 = tb_previousSubject2.Text;
            string salary = tb_Asalary.Text;
            string employmentType = cb_employmentType.Text;
            string workingHours = tb_workinghours.Text;
            string subject1 = tb_subject1.Text;
            string subject2 = tb_subject2.Text;

            // Insert data into the database based on role
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\khuon\Desktop\HRM App\HRM App\Database1.mdf"";Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Name, Telephone, Email, Role) VALUES (@Name, @Telephone, @Email, @Role); SELECT SCOPE_IDENTITY();";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Telephone", telephone);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Role", role);

                    // Execute the query and retrieve the newly inserted UserId
                    int userId = Convert.ToInt32(command.ExecuteScalar());

                    // Depending on the role, insert additional data into the corresponding table
                    switch (role.ToLower())
                    {
                        case "student":
                            query = "INSERT INTO Students (UserId, Current_Subject1, Current_Subject2, Previous_Subject1, Previous_Subject2) VALUES (@UserId, @Current_Subject1, @Current_Subject2, @Previous_Subject1, @Previous_Subject2)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@Current_Subject1", currentSubject1);
                            command.Parameters.AddWithValue("@Current_Subject2", currentSubject2);
                            command.Parameters.AddWithValue("@Previous_Subject1", previousSubject1);
                            command.Parameters.AddWithValue("@Previous_Subject2", previousSubject2);
                            query = "INSERT INTO Account (Username, Password, Admin) VALUES (@Username, @Password, @Admin)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Admin", false);
                            break;
                        case "teacher":
                            query = "INSERT INTO Teachers (UserId, Salary, Subject1, Subject2) VALUES (@UserId, @Salary, @Subject1, @Subject2)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@Salary", salary);
                            command.Parameters.AddWithValue("@Subject1", subject1);
                            command.Parameters.AddWithValue("@Subject2", subject2);
                            query = "INSERT INTO Account (Username, Password, Admin) VALUES (@Username, @Password, @Admin)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Admin", false);
                            break;
                        case "admin":
                            query = "INSERT INTO Administration (UserId, Salary, EmploymentType, Working_Hours) VALUES (@UserId, @Salary, @EmploymentType, @Working_Hours)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@UserId", userId);
                            command.Parameters.AddWithValue("@Salary", salary);
                            command.Parameters.AddWithValue("@EmploymentType", employmentType);
                            command.Parameters.AddWithValue("@Working_Hours", workingHours);
                            // If the role is admin, set the admin column in the Account table to true
                            query = "INSERT INTO Account (Username, Password, Admin) VALUES (@Username, @Password, @Admin)";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Password", password);
                            command.Parameters.AddWithValue("@Admin", true);
                            
                            break;
                    }

                    command.ExecuteNonQuery();
                }

                // Clear textboxes after successful insertion
                ClearDataFields();
                MessageBox.Show("User added successfully.");
                load_data(null, null); // Refresh grid after adding user
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewForEdit.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewForEdit.SelectedRows[0];

                // Retrieve the UserId of the selected user
                int userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);

                // Determine the role of the selected user
                string role = selectedRow.Cells["Role"].Value.ToString().ToLower();

                // Construct the delete query based on the role
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\khuon\Desktop\HRM App\HRM App\Database1.mdf"";Integrated Security=True";
                string query = "";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        switch (role)
                        {
                            case "student":
                                query = "DELETE FROM Students WHERE UserId = @UserId";
                                break;
                            case "teacher":
                                query = "DELETE FROM Teachers WHERE UserId = @UserId";
                                break;
                            case "admin":
                                query = "DELETE FROM Administration WHERE UserId = @UserId";
                                break;
                        }

                        // Execute the delete query
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.ExecuteNonQuery();

                        // Also delete the user from the Users table
                        query = "DELETE FROM Users WHERE UserId = @UserId";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.ExecuteNonQuery();

                        // Refresh the data grid view after deletion
                        load_data(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
