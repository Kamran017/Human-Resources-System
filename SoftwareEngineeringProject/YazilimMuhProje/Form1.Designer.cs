namespace YazilimMuhProje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.signInAsUser = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.adminSignIn = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Black;
            this.userName.Location = new System.Drawing.Point(185, 342);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(169, 37);
            this.userName.TabIndex = 0;
            this.userName.Text = "User Name: ";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(185, 397);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(144, 37);
            this.password.TabIndex = 1;
            this.password.Text = "Password:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(405, 344);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(442, 28);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(405, 398);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(442, 28);
            this.passwordTextBox.TabIndex = 3;
           
            // 
            // signInAsUser
            // 
            this.signInAsUser.BackColor = System.Drawing.Color.White;
            this.signInAsUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInAsUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.signInAsUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signInAsUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signInAsUser.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInAsUser.ForeColor = System.Drawing.Color.Navy;
            this.signInAsUser.Location = new System.Drawing.Point(405, 475);
            this.signInAsUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signInAsUser.Name = "signInAsUser";
            this.signInAsUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.signInAsUser.Size = new System.Drawing.Size(184, 38);
            this.signInAsUser.TabIndex = 4;
            this.signInAsUser.Text = "Sign In As User";
            this.signInAsUser.UseVisualStyleBackColor = false;
            this.signInAsUser.Click += new System.EventHandler(this.signInAsUser_Click);
            this.signInAsUser.MouseLeave += new System.EventHandler(this.signIn_MouseLeave);
            this.signInAsUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.signIn_MouseMove);
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.White;
            this.signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.signUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUp.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signUp.ForeColor = System.Drawing.Color.Navy;
            this.signUp.Location = new System.Drawing.Point(549, 535);
            this.signUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(140, 38);
            this.signUp.TabIndex = 5;
            this.signUp.Text = "Sign Up";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            this.signUp.MouseLeave += new System.EventHandler(this.signUp_MouseLeave);
            this.signUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.signUp_MouseMove);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.header.ForeColor = System.Drawing.Color.Black;
            this.header.Location = new System.Drawing.Point(400, 204);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(277, 104);
            this.header.TabIndex = 6;
            this.header.Text = "Welcome to the \r\nYSOFT Software House \r\nHuman Resources System!\r\n\r\n";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon.BackgroundImage")));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icon.Location = new System.Drawing.Point(684, 169);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(163, 139);
            this.icon.TabIndex = 7;
            this.icon.TabStop = false;
            // 
            // adminSignIn
            // 
            this.adminSignIn.BackColor = System.Drawing.Color.White;
            this.adminSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.adminSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.adminSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminSignIn.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSignIn.ForeColor = System.Drawing.Color.Navy;
            this.adminSignIn.Location = new System.Drawing.Point(663, 475);
            this.adminSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminSignIn.Name = "adminSignIn";
            this.adminSignIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminSignIn.Size = new System.Drawing.Size(184, 38);
            this.adminSignIn.TabIndex = 4;
            this.adminSignIn.Text = "Sign In As Admin";
            this.adminSignIn.UseVisualStyleBackColor = false;
            this.adminSignIn.Click += new System.EventHandler(this.adminSignIn_Click);
            this.adminSignIn.MouseLeave += new System.EventHandler(this.signIn_MouseLeave);
            this.adminSignIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.signIn_MouseMove);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info.BackgroundImage")));
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.info.Location = new System.Drawing.Point(12, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(76, 54);
            this.info.TabIndex = 8;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 753);
            this.Controls.Add(this.info);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.header);
            this.Controls.Add(this.adminSignIn);
            this.Controls.Add(this.signInAsUser);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1164, 904);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1164, 747);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YSOFT Software House Human Resources System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button signInAsUser;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button adminSignIn;
        private System.Windows.Forms.PictureBox info;
    }
}

