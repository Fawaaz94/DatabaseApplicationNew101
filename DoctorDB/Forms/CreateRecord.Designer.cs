namespace DoctorDB.Forms
{
    partial class CreateRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.RFVTb = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.DateDp = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PatientNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tDate = new System.Windows.Forms.Label();
            this.conditionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.medicationTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(135, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 884);
            this.label1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(8, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1471, 2);
            this.label5.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.medicationTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.conditionTxt);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.DescriptionTb);
            this.panel1.Controls.Add(this.RFVTb);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.CreateBtn);
            this.panel1.Controls.Add(this.DateDp);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(139, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 795);
            this.panel1.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 203);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 17);
            this.label18.TabIndex = 70;
            this.label18.Text = "Description";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Location = new System.Drawing.Point(34, 248);
            this.DescriptionTb.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(448, 204);
            this.DescriptionTb.TabIndex = 2;
            // 
            // RFVTb
            // 
            this.RFVTb.Location = new System.Drawing.Point(34, 103);
            this.RFVTb.Margin = new System.Windows.Forms.Padding(4);
            this.RFVTb.Name = "RFVTb";
            this.RFVTb.Size = new System.Drawing.Size(448, 22);
            this.RFVTb.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(326, 679);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(156, 34);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(36, 679);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(156, 34);
            this.CreateBtn.TabIndex = 4;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // DateDp
            // 
            this.DateDp.CustomFormat = "dd/MM/yyyy";
            this.DateDp.Location = new System.Drawing.Point(36, 565);
            this.DateDp.Margin = new System.Windows.Forms.Padding(4);
            this.DateDp.Name = "DateDp";
            this.DateDp.Size = new System.Drawing.Size(265, 22);
            this.DateDp.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 520);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = " Reason For Visit";
            // 
            // PatientNameLbl
            // 
            this.PatientNameLbl.AutoSize = true;
            this.PatientNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLbl.Location = new System.Drawing.Point(463, 34);
            this.PatientNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientNameLbl.Name = "PatientNameLbl";
            this.PatientNameLbl.Size = new System.Drawing.Size(316, 39);
            this.PatientNameLbl.TabIndex = 72;
            this.PatientNameLbl.Text = "Patient Name Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 39);
            this.label3.TabIndex = 71;
            this.label3.Text = "Create Record For:";
            // 
            // tDate
            // 
            this.tDate.AutoSize = true;
            this.tDate.Location = new System.Drawing.Point(14, 69);
            this.tDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(92, 17);
            this.tDate.TabIndex = 73;
            this.tDate.Text = "Today\'s Date";
            // 
            // conditionTxt
            // 
            this.conditionTxt.Location = new System.Drawing.Point(600, 103);
            this.conditionTxt.Margin = new System.Windows.Forms.Padding(4);
            this.conditionTxt.Name = "conditionTxt";
            this.conditionTxt.Size = new System.Drawing.Size(448, 22);
            this.conditionTxt.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Condition";
            // 
            // medicationTxt
            // 
            this.medicationTxt.Location = new System.Drawing.Point(600, 248);
            this.medicationTxt.Margin = new System.Windows.Forms.Padding(4);
            this.medicationTxt.Multiline = true;
            this.medicationTxt.Name = "medicationTxt";
            this.medicationTxt.Size = new System.Drawing.Size(448, 204);
            this.medicationTxt.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "Medication";
            // 
            // CreateRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1492, 906);
            this.Controls.Add(this.tDate);
            this.Controls.Add(this.PatientNameLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "CreateRecord";
            this.Text = "CreateRecord";
            this.Load += new System.EventHandler(this.CreateRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.TextBox RFVTb;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.DateTimePicker DateDp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label PatientNameLbl;
        private System.Windows.Forms.Label tDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox conditionTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox medicationTxt;
    }
}