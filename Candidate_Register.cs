using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class Candidate_Register : Form
    {
        OracleConnection connection;
        public Candidate_Register()
        {
            InitializeComponent();
        }

        private void Candidate_Register_Load(object sender, EventArgs e)
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

        private void insert_cand_Click(object sender, EventArgs e)
        {
            // Get the input values from text boxes
            int id = Convert.ToInt32(txt_cand_id.Text);
            string name = txt_name.Text;
            string email = txt_email.Text;
            string password = txt_password.Text;
            string phone = txt_phone.Text;
            string address = txt_address.Text;
            string gender = txt_gender.Text;
            string information = txt_information.Text;

            // Prepare the SQL query with bind variables for parameterized query
            string sql = "INSERT INTO candidate (id, name, email, password, phone, address, gender, information) " +
                         "VALUES (:id, :name, :email, :password, :phone, :address, :gender, :information)";

            // Create an OracleCommand object with the query and connection
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = sql;

            // Add the bind variables with parameter names and values
            command.Parameters.Add(":id", OracleDbType.Int32).Value = id;
            command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
            command.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
            command.Parameters.Add(":password", OracleDbType.Varchar2).Value = password;
            command.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone;
            command.Parameters.Add(":address", OracleDbType.Varchar2).Value = address;
            command.Parameters.Add(":gender", OracleDbType.Varchar2).Value = gender;
            command.Parameters.Add(":information", OracleDbType.Varchar2).Value = information;

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            candidate C = new candidate();
            C.Show();
            this.Hide();
        }
    }
}
