namespace ODP1_Connected_Start
{
    partial class admin_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.electionID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(389, 51);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(215, 33);
            this.load.TabIndex = 1;
            this.load.Text = "Load election information";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(275, 405);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(215, 33);
            this.save.TabIndex = 2;
            this.save.Text = "save change in election";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Location = new System.Drawing.Point(726, 51);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(44, 16);
            this.logout.TabIndex = 3;
            this.logout.TabStop = true;
            this.logout.Text = "logout";
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // electionID
            // 
            this.electionID.AutoSize = true;
            this.electionID.Location = new System.Drawing.Point(164, 59);
            this.electionID.Name = "electionID";
            this.electionID.Size = new System.Drawing.Size(67, 16);
            this.electionID.TabIndex = 5;
            this.electionID.Text = "electionID";
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.electionID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.save);
            this.Controls.Add(this.load);
            this.Controls.Add(this.dataGridView1);
            this.Name = "admin_page";
            this.Text = "admin_page";
            this.Load += new System.EventHandler(this.admin_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.LinkLabel logout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label electionID;
    }
}