namespace DoctorDB.Forms
{
    partial class ChronicPatients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recordsDatagrid = new System.Windows.Forms.DataGridView();
            this.RecordNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRecordBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LastNamelbl = new System.Windows.Forms.LinkLabel();
            this.FirstName = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PatientLB = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PatientSeachLbl = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.IDLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.medicalAidlbl = new System.Windows.Forms.Label();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.MALbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.lastVisitlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDatagrid)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.recordsDatagrid);
            this.panel2.Controls.Add(this.AddRecordBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1573, 898);
            this.panel2.TabIndex = 1;
            // 
            // recordsDatagrid
            // 
            this.recordsDatagrid.AllowUserToAddRows = false;
            this.recordsDatagrid.AllowUserToDeleteRows = false;
            this.recordsDatagrid.AllowUserToResizeColumns = false;
            this.recordsDatagrid.AllowUserToResizeRows = false;
            this.recordsDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordsDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recordsDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.recordsDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordsDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.recordsDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordsDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.recordsDatagrid.ColumnHeadersHeight = 35;
            this.recordsDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordNum,
            this.FName,
            this.recordReason,
            this.recordDate});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recordsDatagrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.recordsDatagrid.EnableHeadersVisualStyles = false;
            this.recordsDatagrid.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.recordsDatagrid.Location = new System.Drawing.Point(407, 218);
            this.recordsDatagrid.MultiSelect = false;
            this.recordsDatagrid.Name = "recordsDatagrid";
            this.recordsDatagrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordsDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.recordsDatagrid.RowHeadersVisible = false;
            this.recordsDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recordsDatagrid.RowTemplate.Height = 24;
            this.recordsDatagrid.RowTemplate.ReadOnly = true;
            this.recordsDatagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.recordsDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordsDatagrid.Size = new System.Drawing.Size(1150, 664);
            this.recordsDatagrid.TabIndex = 26;
            this.recordsDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordsDatagrid_CellContentClick);
            // 
            // RecordNum
            // 
            this.RecordNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RecordNum.HeaderText = "id";
            this.RecordNum.Name = "RecordNum";
            this.RecordNum.ReadOnly = true;
            this.RecordNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordNum.Width = 50;
            // 
            // FName
            // 
            this.FName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FName.FillWeight = 102.0408F;
            this.FName.HeaderText = "Reason";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FName.Width = 150;
            // 
            // recordReason
            // 
            this.recordReason.FillWeight = 98.97959F;
            this.recordReason.HeaderText = "Description";
            this.recordReason.Name = "recordReason";
            this.recordReason.ReadOnly = true;
            this.recordReason.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // recordDate
            // 
            this.recordDate.FillWeight = 98.97959F;
            this.recordDate.HeaderText = "Date";
            this.recordDate.Name = "recordDate";
            this.recordDate.ReadOnly = true;
            this.recordDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddRecordBtn
            // 
            this.AddRecordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRecordBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddRecordBtn.BackgroundImage = global::DoctorDB.Properties.Resources.addRecord_2jpg;
            this.AddRecordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecordBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AddRecordBtn.Location = new System.Drawing.Point(1508, 163);
            this.AddRecordBtn.Name = "AddRecordBtn";
            this.AddRecordBtn.Size = new System.Drawing.Size(49, 46);
            this.AddRecordBtn.TabIndex = 0;
            this.AddRecordBtn.UseVisualStyleBackColor = false;
            this.AddRecordBtn.Click += new System.EventHandler(this.AddRecordBtn_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(780, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 194);
            this.label7.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LastNamelbl);
            this.panel6.Controls.Add(this.FirstName);
            this.panel6.Location = new System.Drawing.Point(413, 13);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(359, 194);
            this.panel6.TabIndex = 21;
            // 
            // LastNamelbl
            // 
            this.LastNamelbl.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.LastNamelbl.AutoSize = true;
            this.LastNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamelbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LastNamelbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LastNamelbl.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LastNamelbl.Location = new System.Drawing.Point(91, 97);
            this.LastNamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNamelbl.Name = "LastNamelbl";
            this.LastNamelbl.Size = new System.Drawing.Size(182, 37);
            this.LastNamelbl.TabIndex = 19;
            this.LastNamelbl.TabStop = true;
            this.LastNamelbl.Text = "Last Name";
            this.LastNamelbl.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.LastNamelbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FirstNameLbl_LinkClicked);
            // 
            // FirstName
            // 
            this.FirstName.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FirstName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.FirstName.LinkColor = System.Drawing.Color.DodgerBlue;
            this.FirstName.Location = new System.Drawing.Point(92, 45);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(73, 36);
            this.FirstName.TabIndex = 18;
            this.FirstName.TabStop = true;
            this.FirstName.Text = "First";
            this.FirstName.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.FirstName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FirstNameLbl_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 898);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.PatientLB);
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 832);
            this.panel4.TabIndex = 1;
            // 
            // PatientLB
            // 
            this.PatientLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientLB.FormattingEnabled = true;
            this.PatientLB.ItemHeight = 29;
            this.PatientLB.Location = new System.Drawing.Point(0, 0);
            this.PatientLB.Margin = new System.Windows.Forms.Padding(4);
            this.PatientLB.Name = "PatientLB";
            this.PatientLB.Size = new System.Drawing.Size(399, 832);
            this.PatientLB.TabIndex = 1;
            this.PatientLB.SelectedIndexChanged += new System.EventHandler(this.PatientLB_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BackgroundImage = global::DoctorDB.Properties.Resources.back8;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.PatientSeachLbl);
            this.panel3.Controls.Add(this.txtSearchBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 66);
            this.panel3.TabIndex = 0;
            // 
            // PatientSeachLbl
            // 
            this.PatientSeachLbl.AutoSize = true;
            this.PatientSeachLbl.BackColor = System.Drawing.Color.White;
            this.PatientSeachLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientSeachLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientSeachLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.PatientSeachLbl.Location = new System.Drawing.Point(131, 21);
            this.PatientSeachLbl.Name = "PatientSeachLbl";
            this.PatientSeachLbl.Size = new System.Drawing.Size(136, 25);
            this.PatientSeachLbl.TabIndex = 23;
            this.PatientSeachLbl.Text = "Search Patient";
            this.PatientSeachLbl.Click += new System.EventHandler(this.PatientSeachLbl_VisibleChanged);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchBox.Location = new System.Drawing.Point(16, 17);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBox.Multiline = true;
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(361, 33);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            this.txtSearchBox.Enter += new System.EventHandler(this.PatientSeachLbl_VisibleChanged);
            this.txtSearchBox.Leave += new System.EventHandler(this.txtSearchBox_Leave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.IDLbl);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.medicalAidlbl);
            this.panel5.Controls.Add(this.DOBlbl);
            this.panel5.Controls.Add(this.MALbl);
            this.panel5.Controls.Add(this.genderLbl);
            this.panel5.Controls.Add(this.lastVisitlbl);
            this.panel5.Location = new System.Drawing.Point(790, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(436, 194);
            this.panel5.TabIndex = 16;
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.IDLbl.Location = new System.Drawing.Point(261, 30);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(68, 17);
            this.IDLbl.TabIndex = 20;
            this.IDLbl.Text = "ID LABEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(35, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID NUMBER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(35, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "DOB:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "GENDER:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "LAST VISIT: ";
            // 
            // medicalAidlbl
            // 
            this.medicalAidlbl.AutoSize = true;
            this.medicalAidlbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.medicalAidlbl.Location = new System.Drawing.Point(261, 92);
            this.medicalAidlbl.Margin = new System.Windows.Forms.Padding(0);
            this.medicalAidlbl.Name = "medicalAidlbl";
            this.medicalAidlbl.Size = new System.Drawing.Size(140, 17);
            this.medicalAidlbl.TabIndex = 12;
            this.medicalAidlbl.Text = "MEDICAL AID LABEL";
            // 
            // DOBlbl
            // 
            this.DOBlbl.AutoSize = true;
            this.DOBlbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DOBlbl.Location = new System.Drawing.Point(262, 157);
            this.DOBlbl.Margin = new System.Windows.Forms.Padding(0);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(85, 17);
            this.DOBlbl.TabIndex = 8;
            this.DOBlbl.Text = "DOB LABEL";
            // 
            // MALbl
            // 
            this.MALbl.AutoSize = true;
            this.MALbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MALbl.ForeColor = System.Drawing.Color.DimGray;
            this.MALbl.Location = new System.Drawing.Point(34, 92);
            this.MALbl.Margin = new System.Windows.Forms.Padding(0);
            this.MALbl.Name = "MALbl";
            this.MALbl.Size = new System.Drawing.Size(136, 20);
            this.MALbl.TabIndex = 4;
            this.MALbl.Text = "MEDICAL AID #:";
            // 
            // genderLbl
            // 
            this.genderLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genderLbl.AutoSize = true;
            this.genderLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.genderLbl.Location = new System.Drawing.Point(262, 62);
            this.genderLbl.Margin = new System.Windows.Forms.Padding(0);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(114, 17);
            this.genderLbl.TabIndex = 7;
            this.genderLbl.Text = "GENDER LABEL";
            // 
            // lastVisitlbl
            // 
            this.lastVisitlbl.AutoSize = true;
            this.lastVisitlbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lastVisitlbl.Location = new System.Drawing.Point(261, 125);
            this.lastVisitlbl.Margin = new System.Windows.Forms.Padding(0);
            this.lastVisitlbl.Name = "lastVisitlbl";
            this.lastVisitlbl.Size = new System.Drawing.Size(127, 17);
            this.lastVisitlbl.TabIndex = 13;
            this.lastVisitlbl.Text = "LAST VISIT LABEL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(407, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1150, 2);
            this.label2.TabIndex = 2;
            // 
            // ChronicPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1573, 898);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChronicPatients";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordsDatagrid)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ListBox PatientLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MALbl;
        private System.Windows.Forms.Label DOBlbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label lastVisitlbl;
        private System.Windows.Forms.Label medicalAidlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel FirstName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.LinkLabel LastNamelbl;
        private System.Windows.Forms.Button AddRecordBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PatientSeachLbl;
        private System.Windows.Forms.DataGridView recordsDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDate;
    }
}