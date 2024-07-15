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
    public partial class Report2 : Form
    {
        CrystalReport2 Cr;
        public Report2()
        {
            InitializeComponent();
        }
        private void Report2_Load(object sender, EventArgs e)
        {
            Cr = new CrystalReport2();
           
        }
        private void Generate_Report_Click(object sender, EventArgs e)
        {
           
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
