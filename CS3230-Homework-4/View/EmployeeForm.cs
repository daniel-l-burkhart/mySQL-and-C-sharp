using System;
using System.Linq;
using System.Windows.Forms;
using CS3230_Homework_4.Controller;
using CS3230_Homework_4.DAL.Repository;
using CS3230_Homework_4.Properties;

namespace CS3230_Homework_4.View
{
    /// <summary>
    /// The GUI for the program.
    /// </summary>
    public partial class Cs3230Homework4 : Form
    {
        #region Instance Variable
        /// <summary>
        /// The controller
        /// </summary>
        private readonly EmployeeController controller;
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Cs3230Homework4"/> class.
        /// </summary>
        public Cs3230Homework4()
        {
            var employeeRepository = new EmployeeRepository();
            this.controller = new EmployeeController(employeeRepository);
            this.InitializeComponent();
        }

        #endregion

        #region Method

        /// <summary>
        /// Handles the Click event of the submitButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            var supervisedEmployees = this.controller.GetBySupervisorSsn(this.superSSNTextBox.Text);
            this.employeeDataGridView.DataSource = supervisedEmployees;
            if (!supervisedEmployees.Any())
            {
                MessageBox.Show(
                    Resources.DoesNotSuperviseEmployees);
            }
        }

        #endregion
    }
}