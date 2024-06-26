using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace FINALSS
{
    public partial class admin : Form
    {
        private MySqlConnection connection;
        public admin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=finalsdb;username=root;password=;");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtNumber.Text = row.Cells["number"].Value.ToString();
                txtColor.Text = row.Cells["color"].Value.ToString();
                cbRole.Text = row.Cells["role"].Value.ToString();
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            try
            {
                connection.Open();
                string showallrecordsquery = "SELECT ID, name, role, color, number FROM finalss ORDER BY ID ASC";
                MySqlCommand command = new MySqlCommand(showallrecordsquery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Sanitized data to remove white-space
            string number = txtNumber.Text.Trim();
            string color = txtColor.Text;
            string name = txtName.Text;
            string role = cbRole.Text;
            //Check if name, number and color are not empty
            if (string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(color) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter role, name, number, and color");
                return;
            }

            try
            {
                connection.Open();
                string registerquery = "INSERT INTO finalss (name, number, color, role) VALUES (@name, @number, @color, @role)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@color", color);
                command.Parameters.AddWithValue("@role", role);



                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Registered Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to Register Account!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            txtName.Clear();
            txtNumber.Clear();
            txtColor.Clear();
            loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update Record
            //Sanitized data to remove white-space
            string name = txtName.Text.Trim();
            string number = txtNumber.Text;
            string color = txtColor.Text;
            string role = cbRole.Text;
            string ID = txtID.Text;
            //Check if name, username and password are not empty
            if (string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(color) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter role, name, number, and color");
                return;
            }
            try
            {
                connection.Open();
                string registerquery = "INSERT INTO finalss (name, number, color, role) VALUES (@Name, @Number, @Color, @Role)";
                MySqlCommand command = new MySqlCommand(registerquery, connection);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@color", color);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("ID", ID);



                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to Register Account!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            txtName.Clear();
            txtNumber.Clear();
            txtColor.Clear();
            loaddata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                connection.Open();
                string showallrecordsquery = "SELECT ID, number, name, role, color FROM finalss WHERE name LIKE CONCAT('%', @search, '%') OR ID LIKE CONCAT('%', @search, '%') OR color LIKE CONCAT('%', @search, '%') OR number LIKE CONCAT('%', @search, '%') OR role LIKE CONCAT('%', @search, '%')";
                MySqlCommand command = new MySqlCommand(showallrecordsquery, connection);
                command.Parameters.AddWithValue("@search", search);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wanna delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string ID = txtID.Text;
                if (string.IsNullOrEmpty(ID))
                {
                    MessageBox.Show("No Record Found!");
                }
            }

            try
            {
                string ID = txtID.Text;
                connection.Open();
                string deletequery = "DELETE FROM finalss WHERE ID = @ID";
                MySqlCommand command = new MySqlCommand(deletequery, connection);
                command.Parameters.AddWithValue("ID", ID);



                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to Register Account!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            txtName.Clear();
            txtNumber.Clear();
            txtColor.Clear();
            loaddata();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
