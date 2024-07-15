using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class admin_page : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        OracleDataAdapter Adapter;
        OracleCommandBuilder CommandBuilder;
        DataSet ds;
        public admin_page()
        {
            InitializeComponent();
        }
        private void load_Click(object sender, EventArgs e)
        {
            string connect = "Data Source=orcl;User Id=scott;Password=tiger;";

            string selectedValue = comboBox1.SelectedItem.ToString();
            if (selectedValue != null) 
            { 
            string sql = "select * from election where id="+selectedValue +"";
            Adapter=new OracleDataAdapter(sql,connect);
            ds=new DataSet();
            Adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                string sql = "select * from election ";
                Adapter = new OracleDataAdapter(sql, connect);
                ds = new DataSet();
                Adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login rf = new login();
            rf.Show();
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            CommandBuilder=new OracleCommandBuilder(Adapter);
            Adapter.Update(ds.Tables[0]);
        }

        private void admin_page_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from election";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
