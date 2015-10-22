using System.Collections.Generic;
using CS3230_Homework_4.DAL.Interfaces;
using CS3230_Homework_4.Model;

namespace CS3230_Homework_4.Controller
{
    /// <summary>
    /// The controller class
    /// </summary>
    public class EmployeeController
    {

        #region Instance Variable
        /// <summary>
        /// The repository variable
        /// </summary>
        private readonly IRepository<Employee> rep;
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="rep">The rep.</param>
        public EmployeeController(IRepository<Employee> rep)
        {
            this.rep = rep;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetAll()
        {
            return this.rep.GetAll();
        }

        /// <summary>
        /// Gets the by supervisor SSN.
        /// </summary>
        /// <param name="superssn">The superssn.</param>
        /// <returns></returns>
        public IList<Employee> GetBySupervisorSsn(string superssn)
        {
            return this.rep.GetAllEmployeesBySupervisor(superssn);
        }

        #endregion

    }
}