using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Globalization;

namespace YazilimMuhProje
{
    class database
    {
        //create connection with database
        SqlConnection myConnection = new SqlConnection(@"Data Source=DESKTOP-LTQB6JQ\SQLEXPRESS;Initial Catalog=YSOFT;Integrated Security=True");
        SqlCommand myCommand, secondCommand;
        SqlDataReader myReader;
        //sign in as admin operations
        public void signInAsAdmin(string username, string pswrd, Form frm)
        {
            //declare command for opening the connection
            myCommand = new SqlCommand("Select *From LogIn where userName='" + username + "' AND password='" + pswrd + "'", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                frm.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Please enter the valid User Name or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
            myCommand.Dispose();

        }
        //sign in as admin
        public void signInAsUser(string username, string pswrd, Form frm)
        {
            //declare command for opening the connection
            myCommand = new SqlCommand("Select *From LogIn where userName='" + username + "' AND password='" + pswrd + "'", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                frm.Hide();
                UserLogIn f7 = new UserLogIn();
                f7.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Please enter the valid User Name or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
            myCommand.Dispose();
        }
        //sig up as user operations
        public void signUpAsUser(string username, string pswrd, Form frm)
        {
            //add user informations to the data base
            myCommand = new SqlCommand("INSERT INTO LogIn(userName,password) VALUES ('" + username + "','" + pswrd + "')",myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            MessageBox.Show("Account has been created succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm.Hide();
        }
        //sign up as admin
        public void signUpAsAdmin(string username, string pswrd, Form frm)
        {
            string staticUserName = "admin";//declare static admin name if this log in information is available in data base it will return the error message
            myCommand = new SqlCommand("Select *From LogIn where userName='" + staticUserName + "'", myConnection);
            myConnection.Open();
            myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                MessageBox.Show("The system can have only one admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                myConnection.Close();//close the connection which opened before the if block
                //insert admin informations to the data base
                myCommand = new SqlCommand("INSERT INTO LogIn(userName,password) VALUES ('" + username + "','" + pswrd + "')", myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Account has been created succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.Hide();
            }
            myConnection.Close();
            myCommand.Dispose();
        }

        //Add new project to the data base
        public void addProject(string projectName, string startDate, string endDate)
        {
            myCommand = new SqlCommand("INSERT INTO ProjectsDatas(ProjectName,StartDate, EndDate) VALUES ('" + projectName + "','" + startDate + "','" + endDate + "')", myConnection);
            myConnection.Open();
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("The project has been successfully added!", "Succesfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("This project is already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            myConnection.Close();
        }
        //show project data base in the grid view
        public void showProjectDatas(DataGridView dtv)
        {
            myConnection.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter("Select * from ProjectsDatas", myConnection);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            dtv.DataSource = table;
            myConnection.Close();
        }
        //add employee to the data base
        public void addEmployee(string name, string surname, string jobTitle)
        {
            myCommand = new SqlCommand("INSERT INTO employees(Name,Surname, Title) VALUES ('" + name + "','" + surname + "','" + jobTitle + "')", myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        //show employee data base in the grid view
        public void showEmployees(DataGridView dtv)
        {
            myConnection.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter("Select *from employees", myConnection);
            DataTable table = new DataTable();
            myAdapter.Fill(table);
            dtv.DataSource = table;
            myConnection.Close();

        }

    }
}
