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
    public partial class Form2 : Form
    {
        database dt = new database();
        private void Form2_Load(object sender, EventArgs e)
        {
            //set password textbox
            password.PasswordChar = '*';
            userName.MaxLength = 15;
            password.MaxLength = 15;
            confirmation.MaxLength = 15;
        }
        public Form2()
        {
            InitializeComponent();
        }
        //set initial starting positon for username label
        private void userName_TextChanged(object sender, EventArgs e)
        {
            userName = (sender as TextBox);
        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
            }
        }
        

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmation.Focus();
            }
        }
        private void signUp_Click(object sender, EventArgs e)
        {
            if(userName.Text=="admin")
                MessageBox.Show("Admin username is reserved please enter valid username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(userName.Text=="" || password.Text == "")
                MessageBox.Show("Please fill the mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (password.Text != confirmation.Text) 
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt.signUpAsUser(userName.Text, password.Text,this);
            }

        }

        private void adminSignUp_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || password.Text == "")
                MessageBox.Show("Please fill the mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (password.Text != confirmation.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt.signUpAsAdmin(userName.Text, password.Text, this);
            }
        }
    }
}
