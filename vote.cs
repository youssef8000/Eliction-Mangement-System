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
    public partial class vote : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public vote()
        {
            InitializeComponent();
        }

        private void vote_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select DISTINCT  election_id from participation_in_election";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }                   
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name from election where id=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textName.Text = dr["name"].ToString();
            }
            dr.Close();
           
           
        }
        private void button_show_Click(object sender, EventArgs e)

        {
            comboBox2.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETCANDIDATEID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("title", textName.Text);
            cmd.Parameters.Add("id",OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader d = cmd.ExecuteReader();
            while(d.Read())
            {               
                comboBox2.Items.Add(d[0]);
            }
            d.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login rf = new login();
            rf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "CANDIDATEID_FROM_NAME";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("nameCandidate", comboBox2.SelectedItem.ToString());
            OracleParameter outputparam = new OracleParameter("UID", OracleDbType.Int32);
            outputparam.Direction = ParameterDirection.Output;
            c.Parameters.Add(outputparam);
            c.ExecuteNonQuery();
            textBox1.Text = outputparam.Value.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select information from candidate where name=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", comboBox2.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["information"].ToString();
            }
            dr.Close();
        }

        private void voote_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into vote values (:voter_id,:candidate_id,:election_id)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("voter_id", textBox3.Text);
            cmd.Parameters.Add("candidate_id", textBox1.Text);
            cmd.Parameters.Add("election_id", comboBox1.Text);
            int insertV = cmd.ExecuteNonQuery();
            if(insertV != -1)
            {
                MessageBox.Show("You Vote Successfully");
            }
        }
    }
}
