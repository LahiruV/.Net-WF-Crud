using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkillsInternationalProject
{
    public partial class RegistrationForm : Form
    {
        // Connection string (update "YourServerName" with your actual server name)
        SqlConnection connection = new SqlConnection(@"Data Source=NITRO\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");

        public RegistrationForm()
        {
            InitializeComponent();
            LoadRegistrationNumbers();
        }

        private void LoadRegistrationNumbers()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT regNo FROM Registration", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxRegNo.Items.Add(reader["regNo"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Registration (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                               "VALUES (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@regNo", int.Parse(txtRegNo.Text));
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePickerDOB.Value);
                cmd.Parameters.AddWithValue("@gender", rbMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobilePhone", int.Parse(txtMobilePhone.Text));
                cmd.Parameters.AddWithValue("@homePhone", int.Parse(txtHomePhone.Text));
                cmd.Parameters.AddWithValue("@parentName", txtParentName.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@contactNo", int.Parse(txtContactNo.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRegistrationNumbers(); // Refresh registration numbers
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Registration SET firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth, " +
                               "gender = @gender, address = @address, email = @email, mobilePhone = @mobilePhone, homePhone = @homePhone, " +
                               "parentName = @parentName, nic = @nic, contactNo = @contactNo WHERE regNo = @regNo";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@regNo", int.Parse(txtRegNo.Text));
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePickerDOB.Value);
                cmd.Parameters.AddWithValue("@gender", rbMale.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobilePhone", int.Parse(txtMobilePhone.Text));
                cmd.Parameters.AddWithValue("@homePhone", int.Parse(txtHomePhone.Text));
                cmd.Parameters.AddWithValue("@parentName", txtParentName.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@contactNo", int.Parse(txtContactNo.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Registration WHERE regNo = @regNo";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@regNo", int.Parse(txtRegNo.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRegistrationNumbers(); // Refresh registration numbers
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtRegNo.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();

            // Reset date picker and gender radio buttons
            dateTimePickerDOB.Value = DateTime.Today;
            rbMale.Checked = false;
            rbFemale.Checked = false;

            // Optionally clear the selected item in the comboBox
            comboBoxRegNo.SelectedIndex = -1;
        }

        private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected before proceeding
            if (comboBoxRegNo.SelectedItem == null)
            {
                return; // Exit the method if no item is selected
            }

            try
            {
                connection.Open();
                string query = "SELECT * FROM Registration WHERE regNo = @regNo";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@regNo", comboBoxRegNo.SelectedItem.ToString());
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtRegNo.Text = reader["regNo"].ToString();
                    txtFirstName.Text = reader["firstName"].ToString();
                    txtLastName.Text = reader["lastName"].ToString();
                    dateTimePickerDOB.Value = DateTime.Parse(reader["dateOfBirth"].ToString());

                    // Check and set gender radio buttons
                    if (reader["gender"].ToString() == "Male")
                        rbMale.Checked = true;
                    else
                        rbFemale.Checked = true;

                    txtAddress.Text = reader["address"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtMobilePhone.Text = reader["mobilePhone"].ToString();
                    txtHomePhone.Text = reader["homePhone"].ToString();
                    txtParentName.Text = reader["parentName"].ToString();
                    txtNIC.Text = reader["nic"].ToString();
                    txtContactNo.Text = reader["contactNo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
