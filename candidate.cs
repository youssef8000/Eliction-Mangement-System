using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ODP1_Connected_Start
{
    public partial class candidate : Form
    {
        OracleConnection connection;
        public candidate()
        {
            InitializeComponent();
        }
        private void candidate_Load(object sender, EventArgs e)
        {
            string connectionString = "Data source=orcl;User Id=scott; Password=tiger;";
            connection = new OracleConnection(connectionString);
            connection.Open();

            // Check the connection status
            if (connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection is open.");
            }
            else
            {
                MessageBox.Show("Connection is not open.");
            }
        }
        private void show_cand_Click_1(object sender, EventArgs e)
        {
            // Get the ID to search from the user input
            int id;
            if (int.TryParse(txt_Election_id.Text, out id))
            {
                // Prepare the SQL query with a bind variable
                string sql = "SELECT * FROM election WHERE id = :id";

                // Create an OracleCommand object with the query and connection
                OracleCommand command = new OracleCommand();
                command.Connection = connection;
                command.CommandText = sql;

                // Add the bind variable with the parameter name and value
                command.Parameters.Add(":id", OracleDbType.Int32).Value = id;

                // Execute the query and retrieve the results
                OracleDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Description");
                dt.Columns.Add("Start Date");
                dt.Columns.Add("End Date");
                while (reader.Read())
                {
                    // Retrieve the column values
                    int resultId = Convert.ToInt32(reader["id"]);
                    string resultName = Convert.ToString(reader["name"]);
                    string resultDescription = Convert.ToString(reader["description"]);
                    string resultStartDate = Convert.ToString(reader["start_date"]);
                    string resultEndDate = Convert.ToString(reader["end_date"]);

                    // Add the retrieved data as a row in the DataTable
                    dt.Rows.Add(resultId, resultName, resultDescription, resultStartDate, resultEndDate);
                }
                reader.Close();

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid ID input. Please enter a valid integer.");
            }

        }

        private void Get_Candidate_Click_1(object sender, EventArgs e)
        {
            // Get the email and password from the user
            string email = txt_email.Text;
            string password = txt_password.Text;

            // Create a command object for the stored procedure 
            using (OracleCommand command = new OracleCommand("get_candidate_email_pass", connection))
            {
                // Set the command type as stored procedure
                command.CommandType = CommandType.StoredProcedure;

                // Add input parameters for email and password
                command.Parameters.Add("p_email", OracleDbType.Varchar2, 50).Value = email;
                command.Parameters.Add("p_password", OracleDbType.Varchar2, 50).Value = password;

                // Add output parameters for the other columns
                command.Parameters.Add("p_id", OracleDbType.Int32).Direction = ParameterDirection.Output;
                command.Parameters.Add("p_name", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;
                command.Parameters.Add("p_phone", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;
                command.Parameters.Add("p_address", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;
                command.Parameters.Add("p_gender", OracleDbType.Varchar2, 2).Direction = ParameterDirection.Output;
                command.Parameters.Add("p_information", OracleDbType.Varchar2, 200).Direction = ParameterDirection.Output;

                // Execute the stored procedure
                command.ExecuteNonQuery();

                // Retrieve the output parameter values and handle null or empty values


                int resultId = int.Parse(command.Parameters["p_id"].Value.ToString());
                string resultName = command.Parameters["p_name"].Value?.ToString();
                string resultPhone = command.Parameters["p_phone"].Value?.ToString();
                string resultAddress = command.Parameters["p_address"].Value?.ToString();
                string resultGender = command.Parameters["p_gender"].Value?.ToString();
                string resultInformation = command.Parameters["p_information"].Value?.ToString();

                // Create a DataTable to hold the retrieved data
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Phone");
                dt.Columns.Add("Address");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Information");
                txt_cand_id.Text = command.Parameters["p_id"].Value.ToString();

                // Add the retrieved data as a row in the DataTable
                dt.Rows.Add(resultId, resultName, resultPhone, resultAddress, resultGender, resultInformation);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
            }
        }

        private void Get_Multi_Candidates_Click_1(object sender, EventArgs e)
        {
            // Get the gender from the user
            string gender = txt_gender.Text.Trim();

            if (!string.IsNullOrEmpty(gender))
            {
                try
                {


                    // Create an OracleCommand for the stored procedure
                    using (OracleCommand command = new OracleCommand("get_multi_candidates", connection))
                    {
                        // Set the command type as stored procedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Add input parameter for the gender
                        command.Parameters.Add("p_gender", OracleDbType.Varchar2).Value = gender;

                        // Add output parameter for the cursor
                        command.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                        // Execute the stored procedure
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            // Create a DataTable to hold the retrieved data
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dt;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            candidate_update CU = new candidate_update();
            CU.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActorsForm M = new ActorsForm();
            M.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Candidate_Register CR = new Candidate_Register();
            CR.Show();
            this.Hide();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            // Get the input values from text boxes
            int Eid = Convert.ToInt32(txt_Election_id.Text);
            int Cid = Convert.ToInt32(txt_cand_id.Text);
            
            // Prepare the SQL query with bind variables for parameterized query
            string sql = "INSERT INTO PARTICIPATION_IN_ELECTION (ELECTION_ID, CANDIDATE_ID) " +
                         "VALUES (:Eid, :Cid)";

            // Create an OracleCommand object with the query and connection
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = sql;

            // Add the bind variables with parameter names and values
            command.Parameters.Add(":Eid", OracleDbType.Int32).Value = Eid;
            command.Parameters.Add(":Cid", OracleDbType.Int32).Value = Cid;
            
            // Execute the query to insert the new candidate
            int rowsAffected = command.ExecuteNonQuery();

            // Check if the insertion was successful
            if (rowsAffected > 0)
            {
                MessageBox.Show("Candidate inserted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to insert candidate.");
            }
        }
    }
}
