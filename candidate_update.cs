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
    public partial class candidate_update : Form
    {
        OracleDataAdapter Adapter;
        OracleCommandBuilder CommandBuilder;
        DataSet ds;
        public candidate_update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            string c = "Data source=orcl;user id =scott;password=tiger;";
            string cm = @"select * from candidate where email=:q and password=:p";
            Adapter = new OracleDataAdapter(cm, c);
            Adapter.SelectCommand.Parameters.Add("q", textBox1.Text);
            Adapter.SelectCommand.Parameters.Add("p", textBox2.Text);
            ds = new DataSet();
            Adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommandBuilder = new OracleCommandBuilder(Adapter);
            Adapter.Update(ds.Tables[0]);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            candidate C = new candidate();
            C.Show();
            this.Hide();
        }
    }
}
