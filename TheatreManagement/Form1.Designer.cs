namespace TheatreManagement
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvExperiences = new System.Windows.Forms.DataGridView();
            this.dgvExperienceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvYearsWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBoxArtist = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbArtistCatagory = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtistCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReport = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dgvArtistList = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.artistDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperiences)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1622, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1614, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artist Details";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Location = new System.Drawing.Point(861, 452);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 97);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Moccasin;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(391, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 49);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(213, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 48);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(29, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 48);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.textBox1.Location = new System.Drawing.Point(561, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 44);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Theatre Management";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dgvExperiences);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(861, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 386);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Experiences";
            // 
            // dgvExperiences
            // 
            this.dgvExperiences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExperiences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvExperienceId,
            this.dgvGroupName,
            this.dgvYearsWorked});
            this.dgvExperiences.Location = new System.Drawing.Point(7, 34);
            this.dgvExperiences.Name = "dgvExperiences";
            this.dgvExperiences.RowHeadersWidth = 62;
            this.dgvExperiences.RowTemplate.Height = 28;
            this.dgvExperiences.Size = new System.Drawing.Size(523, 346);
            this.dgvExperiences.TabIndex = 0;
            this.dgvExperiences.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvExperiences_UserDeletingRow);
            // 
            // dgvExperienceId
            // 
            this.dgvExperienceId.DataPropertyName = "ExperienceId";
            this.dgvExperienceId.HeaderText = "Experience Id";
            this.dgvExperienceId.MinimumWidth = 8;
            this.dgvExperienceId.Name = "dgvExperienceId";
            this.dgvExperienceId.Visible = false;
            this.dgvExperienceId.Width = 150;
            // 
            // dgvGroupName
            // 
            this.dgvGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvGroupName.DataPropertyName = "GroupName";
            this.dgvGroupName.HeaderText = "Theatre Group";
            this.dgvGroupName.MinimumWidth = 8;
            this.dgvGroupName.Name = "dgvGroupName";
            // 
            // dgvYearsWorked
            // 
            this.dgvYearsWorked.DataPropertyName = "YearsWorked";
            this.dgvYearsWorked.HeaderText = "Work/Yr";
            this.dgvYearsWorked.MinimumWidth = 8;
            this.dgvYearsWorked.Name = "dgvYearsWorked";
            this.dgvYearsWorked.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.pictureBoxArtist);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(568, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 498);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile Photo";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(178, 424);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 43);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Violet;
            this.btnBrowse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBrowse.Location = new System.Drawing.Point(7, 425);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 42);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBoxArtist
            // 
            this.pictureBoxArtist.Location = new System.Drawing.Point(7, 34);
            this.pictureBoxArtist.Name = "pictureBoxArtist";
            this.pictureBoxArtist.Size = new System.Drawing.Size(274, 331);
            this.pictureBoxArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArtist.TabIndex = 0;
            this.pictureBoxArtist.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.rbtnFemale);
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbArtistCatagory);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtArtistName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArtistCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(7, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artist Information";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(262, 375);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(151, 30);
            this.chkStatus.TabIndex = 8;
            this.chkStatus.Text = "Permanent";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(375, 436);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(112, 30);
            this.rbtnFemale.TabIndex = 7;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(262, 439);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(90, 30);
            this.rbtnMale.TabIndex = 6;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(37, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender : ";
            // 
            // cmbArtistCatagory
            // 
            this.cmbArtistCatagory.FormattingEnabled = true;
            this.cmbArtistCatagory.Location = new System.Drawing.Point(262, 294);
            this.cmbArtistCatagory.Name = "cmbArtistCatagory";
            this.cmbArtistCatagory.Size = new System.Drawing.Size(246, 34);
            this.cmbArtistCatagory.TabIndex = 3;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(262, 207);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(246, 35);
            this.dtpDOB.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(37, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(37, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Artist Catagory : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(37, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of Birth : ";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(262, 135);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(246, 35);
            this.txtArtistName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(37, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artist Name : ";
            // 
            // txtArtistCode
            // 
            this.txtArtistCode.Location = new System.Drawing.Point(262, 56);
            this.txtArtistCode.Name = "txtArtistCode";
            this.txtArtistCode.Size = new System.Drawing.Size(246, 35);
            this.txtArtistCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist Code : ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabPage2.Controls.Add(this.btnReport);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.dgvArtistList);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1614, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Artist List";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(1245, 492);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(238, 45);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(6, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(401, 30);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "For Update and Delete, Double Click on any Cell";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(533, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(516, 35);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Artist List";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvArtistList
            // 
            this.dgvArtistList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArtistList.ColumnHeadersHeight = 24;
            this.dgvArtistList.Location = new System.Drawing.Point(6, 53);
            this.dgvArtistList.Name = "dgvArtistList";
            this.dgvArtistList.RowHeadersWidth = 60;
            this.dgvArtistList.RowTemplate.Height = 28;
            this.dgvArtistList.Size = new System.Drawing.Size(1477, 437);
            this.dgvArtistList.StandardTab = true;
            this.dgvArtistList.TabIndex = 0;
            this.dgvArtistList.DoubleClick += new System.EventHandler(this.dgvArtistList_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 663);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperiences)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtistList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBoxArtist;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArtistCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbArtistCatagory;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.DataGridView dgvExperiences;
        private System.Windows.Forms.DataGridView dgvArtistList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvExperienceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvYearsWorked;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.BindingSource artistDBDataSetBindingSource;
        private System.Windows.Forms.TextBox textBox2;
    }
}

