namespace YazilimMuhProje
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.header = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordConf = new System.Windows.Forms.Label();
            this.confirmation = new System.Windows.Forms.TextBox();
            this.adminSignUp = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.header.Location = new System.Drawing.Point(321, 45);
            this.header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(419, 61);
            this.header.TabIndex = 1;
            this.header.Text = "Create an account";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.usernameLabel.Location = new System.Drawing.Point(169, 172);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(130, 26);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "User name: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordLabel.Location = new System.Drawing.Point(169, 244);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(114, 26);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userName.Location = new System.Drawing.Point(332, 174);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(408, 24);
            this.userName.TabIndex = 9;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            this.userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userName_KeyDown);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(332, 244);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(408, 24);
            this.password.TabIndex = 9;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // passwordConf
            // 
            this.passwordConf.AutoSize = true;
            this.passwordConf.BackColor = System.Drawing.Color.Transparent;
            this.passwordConf.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordConf.Location = new System.Drawing.Point(153, 300);
            this.passwordConf.Name = "passwordConf";
            this.passwordConf.Size = new System.Drawing.Size(146, 52);
            this.passwordConf.TabIndex = 8;
            this.passwordConf.Text = "Password\r\nConfirmation:\r\n";
            this.passwordConf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // confirmation
            // 
            this.confirmation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmation.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirmation.ForeColor = System.Drawing.Color.Black;
            this.confirmation.Location = new System.Drawing.Point(332, 310);
            this.confirmation.Name = "confirmation";
            this.confirmation.PasswordChar = '*';
            this.confirmation.Size = new System.Drawing.Size(408, 24);
            this.confirmation.TabIndex = 9;
            // 
            // adminSignUp
            // 
            this.adminSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.adminSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adminSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.adminSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminSignUp.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminSignUp.ForeColor = System.Drawing.Color.White;
            this.adminSignUp.Location = new System.Drawing.Point(556, 370);
            this.adminSignUp.Name = "adminSignUp";
            this.adminSignUp.Size = new System.Drawing.Size(184, 38);
            this.adminSignUp.TabIndex = 10;
            this.adminSignUp.Text = "Sign Up As Admin";
            this.adminSignUp.UseVisualStyleBackColor = false;
            this.adminSignUp.Click += new System.EventHandler(this.adminSignUp_Click);
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUp.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signUp.ForeColor = System.Drawing.Color.White;
            this.signUp.Location = new System.Drawing.Point(332, 370);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(184, 38);
            this.signUp.TabIndex = 10;
            this.signUp.Text = "Sign Up As User";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1003, 593);
            this.Controls.Add(this.adminSignUp);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordConf);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1019, 632);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordConf;
        private System.Windows.Forms.TextBox confirmation;
        private System.Windows.Forms.Button adminSignUp;
        private System.Windows.Forms.Button signUp;
    }
}