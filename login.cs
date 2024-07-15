using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODP1_Connected_Start
{   
    public partial class login : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length > 0 && textBoxPassword.Text.Length > 0)
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                string uid = textBoxEmail.Text;
                string pass = textBoxPassword.Text;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from voter where email='" + uid + "' and Password='" + pass + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader drC = cmd.ExecuteReader();
                if (drC.Read())
                {
                    MessageBox.Show("success login");
                    vote vote = new vote();
                    vote.Show();
                    this.Hide();
                }
                else
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from admin where email='" + uid + "' and Password='" + pass + "'";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader drA = cmd.ExecuteReader();
                    if (drA.Read())
                    {
                        MessageBox.Show("success login as admin");
                        admin_page vote = new admin_page();
                        vote.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("failed login");
                    }
                }


            }
            else
            {
                MessageBox.Show("Please Write your Data");
            }
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register rf = new register();
            rf.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActorsForm M = new ActorsForm();
            M.Show();
            this.Hide();
        }
    }
}
