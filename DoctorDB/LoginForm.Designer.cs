namespace DoctorDB
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pbLoginImage = new System.Windows.Forms.PictureBox();
            this.forgotLabel = new System.Windows.Forms.Label();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rememberMeCb = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLoginImage
            // 
            this.pbLoginImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoginImage.BackColor = System.Drawing.Color.Transparent;
            this.pbLoginImage.BackgroundImage = global::DoctorDB.Properties.Resources.doctorLoginIconeMale;
            this.pbLoginImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLoginImage.Location = new System.Drawing.Point(1, 52);
            this.pbLoginImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbLoginImage.Name = "pbLoginImage";
            this.pbLoginImage.Size = new System.Drawing.Size(516, 278);
            this.pbLoginImage.TabIndex = 0;
            this.pbLoginImage.TabStop = false;
            // 
            // forgotLabel
            // 
            this.forgotLabel.AutoSize = true;
            this.forgotLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotLabel.ForeColor = System.Drawing.Color.White;
            this.forgotLabel.Location = new System.Drawing.Point(243, 142);
            this.forgotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotLabel.Name = "forgotLabel";
            this.forgotLabel.Size = new System.Drawing.Size(126, 17);
            this.forgotLabel.TabIndex = 5;
            this.forgotLabel.Text = "Forgot Password? ";
            this.forgotLabel.Click += new System.EventHandler(this.forgotLabel_Click);
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.btnViewPassword.BackgroundImage = global::DoctorDB.Properties.Resources.eye2;
            this.btnViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewPassword.FlatAppearance.BorderSize = 0;
            this.btnViewPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnViewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPassword.Location = new System.Drawing.Point(288, 11);
            this.btnViewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(44, 32);
            this.btnViewPassword.TabIndex = 4;
            this.btnViewPassword.UseVisualStyleBackColor = false;
            this.btnViewPassword.MouseLeave += new System.EventHandler(this.ViewPassword2);
            this.btnViewPassword.MouseHover += new System.EventHandler(this.ViewPassword);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::DoctorDB.Properties.Resources.blueWP3;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(110, 184);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(161, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.Login);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeFocus);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.White;
            this.passwordLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordLbl.Location = new System.Drawing.Point(36, 16);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(80, 23);
            this.passwordLbl.TabIndex = 25;
            this.passwordLbl.Text = "Password";
            this.passwordLbl.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Remember Me";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::DoctorDB.Properties.Resources._lock;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(8, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 29);
            this.button2.TabIndex = 27;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // rememberMeCb
            // 
            this.rememberMeCb.AutoSize = true;
            this.rememberMeCb.BackColor = System.Drawing.Color.Transparent;
            this.rememberMeCb.FlatAppearance.BorderSize = 0;
            this.rememberMeCb.ForeColor = System.Drawing.Color.Transparent;
            this.rememberMeCb.Location = new System.Drawing.Point(125, 143);
            this.rememberMeCb.Name = "rememberMeCb";
            this.rememberMeCb.Size = new System.Drawing.Size(18, 17);
            this.rememberMeCb.TabIndex = 29;
            this.rememberMeCb.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.usernameLbl);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Location = new System.Drawing.Point(27, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 51);
            this.panel2.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::DoctorDB.Properties.Resources.man_user1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 29);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.White;
            this.usernameLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameLbl.Location = new System.Drawing.Point(36, 15);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(87, 23);
            this.usernameLbl.TabIndex = 24;
            this.usernameLbl.Text = "Username";
            this.usernameLbl.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(39, 11);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(288, 31);
            this.txtUsername.TabIndex = 55;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Leave += new System.EventHandler(this.usernameTb_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnViewPassword);
            this.panel3.Controls.Add(this.passwordLbl);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Location = new System.Drawing.Point(27, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 51);
            this.panel3.TabIndex = 57;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(40, 12);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(245, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.passwordTb_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImage = global::DoctorDB.Properties.Resources.blueWP3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rememberMeCb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.forgotLabel);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(57, 377);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 235);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoctorDB.Properties.Resources.blueWP3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 655);
            this.Controls.Add(this.pbLoginImage);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLoginImage;
        private System.Windows.Forms.Label forgotLabel;
        private System.Windows.Forms.Button btnViewPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox rememberMeCb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
    }
}