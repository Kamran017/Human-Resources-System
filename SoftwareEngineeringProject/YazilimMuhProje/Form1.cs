using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMuhProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        database myDt = new database();


        private void Form1_Load(object sender, EventArgs e)
        {
            //set password textbox
            passwordTextBox.PasswordChar = '*';
            userNameTextBox.MaxLength = 15;
            passwordTextBox.MaxLength = 15;
        }
        //set initial starting positon for username label
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            userNameTextBox = (sender as TextBox);
        }
        private void signUp_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        //Change color of sign in button when mouse moves
        private void signIn_MouseMove(object sender, MouseEventArgs e)
        {
            signInAsUser.ForeColor = Color.Green;
        }
        //Reset the button color when mouse leaves
        private void signIn_MouseLeave(object sender, EventArgs e)
        {
            signInAsUser.ForeColor = Color.Navy;
        }
        private void signUp_MouseMove(object sender, MouseEventArgs e)
        {
            signUp.ForeColor = Color.Green;
        }

        private void signUp_MouseLeave(object sender, EventArgs e)
        {
            signUp.ForeColor = Color.Navy;
        }

        //SIGN IN OPERATIONS
        //sign in as admin
        private void adminSignIn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
                MessageBox.Show("Please fill the mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(userNameTextBox.Text!="admin")
                MessageBox.Show("You can not sign in as admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                myDt.signInAsAdmin(userNameTextBox.Text, passwordTextBox.Text, this);
                userNameTextBox.ResetText();//reset fields
                passwordTextBox.ResetText();//reset fields
            }
        }
        //sign in as user
        private void signInAsUser_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
                MessageBox.Show("Please fill the mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //admin can not sign in as user 
            else if (userNameTextBox.Text == "admin")
            {
                MessageBox.Show("Admin can not sign in as user! Please click the Sign In As Admin button!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                myDt.signInAsUser(userNameTextBox.Text, passwordTextBox.Text, this);
                userNameTextBox.ResetText();//reset fields
                passwordTextBox.ResetText();//reset fields
            }
            
        }
        //information about the system
        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the YSOFT Human Resources system. System does not have log in informations defaultly. You can only have one admin account , and username of this account should be 'admin'. If you want to create admin account click the sign up and fill the mandatory fields after then sign up as admin. Admin can edit employees, projects and can calculate salaries and compensations. Users only can see the employees and projects. They do not have authority to edit sections.", "Information About The System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
