using System;
using System.Windows.Forms;
using CS3230_Homework_4.Controller;
using CS3230_Homework_4.DAL.Repository;

namespace CS3230_Homework_4
{
    public partial class CS3230Homework4 : Form
    {
        private readonly EmployeeController controller;
        private readonly EmployeeRepository employeeRepository;

        public CS3230Homework4()
        {
            this.employeeRepository = new EmployeeRepository();
            this.controller = new EmployeeController(this.employeeRepository);
            this.InitializeComponent();
        }

        private void CS3230Homework4_Load(object sender, EventArgs e)
        {
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //this.controller.GetBySupervisorSSN(this.superSSNTextBox.Text);
            this.employeeDataGridView.DataSource = this.controller.GetBySupervisorSSN(this.superSSNTextBox.Text);
        }
    }
}