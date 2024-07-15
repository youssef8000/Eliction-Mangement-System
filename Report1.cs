using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class Report1 : Form
    {
        CrystalReport1 Cr;
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            Cr = new CrystalReport1();
            foreach(ParameterDiscreteValue v in Cr.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = Cr;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActorsForm M = new ActorsForm();
            M.Show();
            this.Hide();
        }
    }
}
