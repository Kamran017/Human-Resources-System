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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //create database object
            database dt = new database();
            //set maximum length for text boxes
            projectNameTextBox.MaxLength = 15;
            employeeNameTextBox.MaxLength = 15;
            employeeSurnameTextBox.MaxLength = 15;

            //show project datas in data grid view
            dt.showProjectDatas(projectInformationGrid);
            //Set the datagridview's EnableHeadersVisualStyles to false to get the header cell to accept the color change
            projectInformationGrid.EnableHeadersVisualStyles = false;

            //show employee datas in data grid view
            dt.showEmployees(employeeInformationGrid);
            //Set the datagridview's EnableHeadersVisualStyles to false to get the header cell to accept the color change
            employeeInformationGrid.EnableHeadersVisualStyles = false;

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the program?", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //PROJECT SECTION STARTS

        //add project to the database
        private void addProjectButton_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;//get the current time for comparision
            //get start date of project
            DateTime startDate = Convert.ToDateTime(startDateTextBox.Text);
            //get end date of project
            DateTime endDate = Convert.ToDateTime(endDateTextBox.Text);
            database dt = new database();
            //if the user has not filled the mandatory fields error message will appear
            if (projectNameTextBox.Text == "" || startDateTextBox.Text == "" || endDateTextBox.Text == "")
                MessageBox.Show("Please fill the mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else project will be added to the databese
            else
            {
                //try adding project to the database
                try
                {
                    if(startDate < thisDay)
                    {
                        MessageBox.Show("Please enter a valid Start Date!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        startDateTextBox.ResetText();
                    }
                    else if (endDate < thisDay)
                    {
                        MessageBox.Show("Please enter a valid End Date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        endDateTextBox.ResetText();
                    }
                    else
                    {
                        //add project to the database with proper values token from text boxes
                        dt.addProject(projectNameTextBox.Text, startDateTextBox.Text, endDateTextBox.Text);
                        //reset all fields after insertion operation
                        projectNameTextBox.ResetText();
                        startDateTextBox.ResetText();
                        endDateTextBox.ResetText();
                        //update data grid view 
                        dt.showProjectDatas(projectInformationGrid);
                    }

                }
                //if there is a problem in insertion process program will return error message
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //focus operations start
        private void projectNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startDateTextBox.Focus();
            }
        }
        private void startDateTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                endDateTextBox.Focus();
            }
        }

        private void endDateTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addProjectButton.PerformClick();
            }
        }
        //focus operations end

        //show project contents when clicked to the panel, image and label;
        private void projectPanel_Click(object sender, EventArgs e)
        {
            salaryContent.Hide();
            compensationContent.Hide();    
            employeeContent.Hide();        
            employeeInformationGrid.Hide();
            compensationContent.Hide();
            projectInformationGrid.Show();
            projectPanel.BackColor = Color.FromArgb(0, 64, 64);//change background color
            employeePanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
            compensationPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
            salaryPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color

        }
        
        //PROJECT SECTION ENDS

        //EMPLOYEE SECTION STARTS

        //Show employee window when clicked to the panel, image and label
        private void employeePanel_Click(object sender, EventArgs e)
        {
            salaryContent.Hide();
            compensationContent.Hide();
            employeeContent.Show();
            employeeInformationGrid.Show();
            employeePanel.BackColor = Color.FromArgb(0,64,64);//change background color
            projectPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
            compensationPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
            salaryPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
            salaryPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
        }

        //Add employee to the database
        private void addEmployeeButon_Click(object sender, EventArgs e)
        {
            database dt = new database();
            //if the user has not filled the mandatory fields error message will appear
            if (employeeNameTextBox.Text == "" || employeeSurnameTextBox.Text == "" || employeeJobTitleBox.Text == "" || salaryTypeBox.Text == "")
                MessageBox.Show("Please fill the mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //try adding employee to the database with proper values token from text boxes
                try
                {
                    dt.addEmployee(employeeNameTextBox.Text, employeeSurnameTextBox.Text, employeeJobTitleBox.Text);
                    MessageBox.Show("The employee has been successfully added!", "Succesfull");
                    //reset all fields after insertion operation
                    employeeNameTextBox.ResetText();
                    employeeSurnameTextBox.ResetText();
                    employeeJobTitleBox.SelectedIndex = -1;
                    salaryTypeBox.SelectedIndex = -1;
                    dt.showEmployees(employeeInformationGrid);
                }
                //if there is a problem in insertion process program will return error message
                catch (Exception v)
                {
                    MessageBox.Show(v.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //EMPLOYEE SECTION ENDS

        //COMPENSATION SECTION STARTS
        private void compensationPanel_Click(object sender, EventArgs e)
        {
            salaryContent.Hide();
            compensationContent.Show();
            compensationPanel.BackColor = Color.FromArgb(0, 64, 64);//change background color
            projectPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
            employeePanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
            salaryPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
        }

        private void firstSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.national-accident-helpline.co.uk/claims-calculator");
        }

        private void secondSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.quittance.co.uk/personal-injury-compensation-claims-calculator");
        }
        //END OF COMPENSATION

        //SALARY SECTION STARTS
        private void salaryPanel_Click(object sender, EventArgs e)
        {
            salaryContent.Show();
            salaryPanel.BackColor = Color.FromArgb(0, 64, 64);//change background color
            projectPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
            employeePanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
            compensationPanel.BackColor = Color.FromArgb(0, 0, 64);//reset background color
        }
        private void firstSalary_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.salaryexpert.com/");
        }

        private void secondSalary_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.salary.com/");
        }

        
    }
}
