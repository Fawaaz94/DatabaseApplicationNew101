namespace DoctorDB.Forms
{
    partial class Appointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.searchAppointmentsTb = new System.Windows.Forms.TextBox();
            this.AppointmentsDatagrid = new System.Windows.Forms.DataGridView();
            this.RecordNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchAppointmentsTb
            // 
            this.searchAppointmentsTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchAppointmentsTb.Location = new System.Drawing.Point(36, 81);
            this.searchAppointmentsTb.Name = "searchAppointmentsTb";
            this.searchAppointmentsTb.Size = new System.Drawing.Size(184, 22);
            this.searchAppointmentsTb.TabIndex = 4;
            this.searchAppointmentsTb.TextChanged += new System.EventHandler(this.searchAppointmentsTb_TextChanged);
            // 
            // AppointmentsDatagrid
            // 
            this.AppointmentsDatagrid.AllowUserToAddRows = false;
            this.AppointmentsDatagrid.AllowUserToDeleteRows = false;
            this.AppointmentsDatagrid.AllowUserToResizeColumns = false;
            this.AppointmentsDatagrid.AllowUserToResizeRows = false;
            this.AppointmentsDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppointmentsDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.AppointmentsDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppointmentsDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AppointmentsDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AppointmentsDatagrid.ColumnHeadersHeight = 35;
            this.AppointmentsDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordNum,
            this.patientName,
            this.contactNumber,
            this.aReason,
            this.idNumber,
            this.recordDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentsDatagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AppointmentsDatagrid.EnableHeadersVisualStyles = false;
            this.AppointmentsDatagrid.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.AppointmentsDatagrid.Location = new System.Drawing.Point(36, 109);
            this.AppointmentsDatagrid.MultiSelect = false;
            this.AppointmentsDatagrid.Name = "AppointmentsDatagrid";
            this.AppointmentsDatagrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AppointmentsDatagrid.RowHeadersVisible = false;
            this.AppointmentsDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AppointmentsDatagrid.RowTemplate.Height = 24;
            this.AppointmentsDatagrid.RowTemplate.ReadOnly = true;
            this.AppointmentsDatagrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentsDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDatagrid.Size = new System.Drawing.Size(1248, 664);
            this.AppointmentsDatagrid.TabIndex = 27;
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
            // patientName
            // 
            this.patientName.HeaderText = "Patient Name";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            // 
            // contactNumber
            // 
            this.contactNumber.FillWeight = 98.97959F;
            this.contactNumber.HeaderText = "Contact Number";
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.ReadOnly = true;
            this.contactNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // aReason
            // 
            this.aReason.HeaderText = "Reason";
            this.aReason.Name = "aReason";
            this.aReason.ReadOnly = true;
            // 
            // idNumber
            // 
            this.idNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idNumber.FillWeight = 102.0408F;
            this.idNumber.HeaderText = "ID Number";
            this.idNumber.Name = "idNumber";
            this.idNumber.ReadOnly = true;
            this.idNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idNumber.Width = 150;
            // 
            // recordDate
            // 
            this.recordDate.FillWeight = 98.97959F;
            this.recordDate.HeaderText = "Date";
            this.recordDate.Name = "recordDate";
            this.recordDate.ReadOnly = true;
            this.recordDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 826);
            this.Controls.Add(this.AppointmentsDatagrid);
            this.Controls.Add(this.searchAppointmentsTb);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Appointments";
            this.Text = "7";
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchAppointmentsTb;
        private System.Windows.Forms.DataGridView AppointmentsDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn aReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordDate;
    }
}