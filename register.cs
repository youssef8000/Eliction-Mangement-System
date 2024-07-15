using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODP1_Connected_Start
{
    public partial class register : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public register()
        {
            InitializeComponent();
        }

        private void Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lf = new login();
            lf.Show();
            this.Hide();
        }

        private void Register1_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length>0 && VoterEmail.Text.Length>0 && VoterPass.Text.Length > 0 && VoterName.Text.Length > 0
                && VoterPhone.Text.Length > 0 && VoterAddress.Text.Length > 0 && VoterGender.Text.Length > 0)
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = ("insert into voter values (:id,:name,:email,:password,:phone,:address,:gender)");
                cmd.Parameters.Add("id", textBoxID.Text);
                cmd.Parameters.Add("name", VoterName.Text);
                cmd.Parameters.Add("email", VoterEmail.Text);
                cmd.Parameters.Add("password", VoterPass.Text);
                cmd.Parameters.Add("phone", VoterPhone.Text);
                cmd.Parameters.Add("address", VoterAddress.Text);
                cmd.Parameters.Add("gender", VoterGender.Text);
                cmd.ExecuteNonQuery();
                
                    MessageBox.Show("success Registration, you will redirected to login page");
                    ActorsForm lf = new ActorsForm();
                    lf.Show();
                    this.Hide();
                
                 
            }
            else
            {
                MessageBox.Show("Please Write your Data");
            }
        }
    }
}
