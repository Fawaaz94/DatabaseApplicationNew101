namespace DoctorDB.Forms
{
    partial class CreateAppointment
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
            this.IDNumberTb = new System.Windows.Forms.TextBox();
            this.contactNumberTb = new System.Windows.Forms.TextBox();
            this.appointmentReasonTb = new System.Windows.Forms.TextBox();
            this.patientNameTb = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.appointmentDP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDNumberTb
            // 
            this.IDNumberTb.Location = new System.Drawing.Point(360, 86);
            this.IDNumberTb.Margin = new System.Windows.Forms.Padding(4);
            this.IDNumberTb.Name = "IDNumberTb";
            this.IDNumberTb.Size = new System.Drawing.Size(156, 22);
            this.IDNumberTb.TabIndex = 4;
            // 
            // contactNumberTb
            // 
            this.contactNumberTb.Location = new System.Drawing.Point(34, 250);
            this.contactNumberTb.Margin = new System.Windows.Forms.Padding(4);
            this.contactNumberTb.Name = "contactNumberTb";
            this.contactNumberTb.Size = new System.Drawing.Size(156, 22);
            this.contactNumberTb.TabIndex = 5;
            // 
            // appointmentReasonTb
            // 
            this.appointmentReasonTb.Location = new System.Drawing.Point(34, 388);
            this.appointmentReasonTb.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentReasonTb.Multiline = true;
            this.appointmentReasonTb.Name = "appointmentReasonTb";
            this.appointmentReasonTb.Size = new System.Drawing.Size(482, 210);
            this.appointmentReasonTb.TabIndex = 6;
            // 
            // patientNameTb
            // 
            this.patientNameTb.Location = new System.Drawing.Point(34, 86);
            this.patientNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.patientNameTb.Name = "patientNameTb";
            this.patientNameTb.Size = new System.Drawing.Size(156, 22);
            this.patientNameTb.TabIndex = 1;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(360, 691);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(156, 34);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(36, 691);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(156, 34);
            this.CreateBtn.TabIndex = 15;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Patient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Contact Number";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.appointmentDP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.IDNumberTb);
            this.panel1.Controls.Add(this.contactNumberTb);
            this.panel1.Controls.Add(this.appointmentReasonTb);
            this.panel1.Controls.Add(this.patientNameTb);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.CreateBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(142, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 795);
            this.panel1.TabIndex = 43;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(543, 54);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 54);
            this.searchButton.TabIndex = 35;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // appointmentDP
            // 
            this.appointmentDP.Location = new System.Drawing.Point(345, 250);
            this.appointmentDP.Name = "appointmentDP";
            this.appointmentDP.Size = new System.Drawing.Size(200, 22);
            this.appointmentDP.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Date of Appointment";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(138, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 884);
            this.label1.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(11, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1471, 2);
            this.label5.TabIndex = 41;
            // 
            // CreateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1492, 906);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "CreateAppointment";
            this.Text = "CreateAppointment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox IDNumberTb;
        private System.Windows.Forms.TextBox contactNumberTb;
        private System.Windows.Forms.TextBox appointmentReasonTb;
        private System.Windows.Forms.TextBox patientNameTb;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker appointmentDP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button searchButton;
    }
}