namespace ODP1_Connected_Start
{
    partial class vote
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.election = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.candidate = new System.Windows.Forms.Label();
            this.voote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.Election_Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_show = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // election
            // 
            this.election.AutoSize = true;
            this.election.Location = new System.Drawing.Point(158, 57);
            this.election.Name = "election";
            this.election.Size = new System.Drawing.Size(57, 17);
            this.election.TabIndex = 1;
            this.election.Text = "election";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(270, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // candidate
            // 
            this.candidate.AutoSize = true;
            this.candidate.Location = new System.Drawing.Point(145, 147);
            this.candidate.Name = "candidate";
            this.candidate.Size = new System.Drawing.Size(70, 17);
            this.candidate.TabIndex = 3;
            this.candidate.Text = "candidate";
            // 
            // voote
            // 
            this.voote.Location = new System.Drawing.Point(347, 431);
            this.voote.Name = "voote";
            this.voote.Size = new System.Drawing.Size(117, 29);
            this.voote.TabIndex = 4;
            this.voote.Text = "vote";
            this.voote.UseVisualStyleBackColor = true;
            this.voote.Click += new System.EventHandler(this.voote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Voting";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(270, 93);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(183, 22);
            this.textName.TabIndex = 7;
            // 
            // Election_Name
            // 
            this.Election_Name.AutoSize = true;
            this.Election_Name.Location = new System.Drawing.Point(130, 96);
            this.Election_Name.Name = "Election_Name";
            this.Election_Name.Size = new System.Drawing.Size(99, 17);
            this.Election_Name.TabIndex = 8;
            this.Election_Name.Text = "Election Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 181);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 29);
            this.textBox1.TabIndex = 9;
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(506, 141);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(167, 29);
            this.button_show.TabIndex = 10;
            this.button_show.Text = "show candidate Name";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(237, 431);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 24);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "show candidate ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "CandidateID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Candidate_Informatiom";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 228);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 69);
            this.textBox2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Voter_ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(269, 336);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 29);
            this.textBox3.TabIndex = 17;
            // 
            // vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 489);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Election_Name);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.voote);
            this.Controls.Add(this.candidate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.election);
            this.Controls.Add(this.comboBox1);
            this.Name = "vote";
            this.Text = "vote";
            this.Load += new System.EventHandler(this.vote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label election;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label candidate;
        private System.Windows.Forms.Button voote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label Election_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}