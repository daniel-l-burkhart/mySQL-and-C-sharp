using System.Collections.Generic;
using CS3230ExploringTheRepositoryPattern.DAL.Interfaces;
using CS3230_Homework_4.Model;

namespace CS3230_Homework_4.Controller
{
    public class EmployeeController
    {
        private readonly IRepository<Employee> rep;

        public EmployeeController(IRepository<Employee> rep)
        {
            this.rep = rep;
        }

        public IList<Employee> GetAll()
        {
            return this.rep.GetAll();
        }

        public IList<Employee> GetBySupervisorSSN(string superssn)
        {
            return this.rep.GetAllEmployeesBySupervisor(superssn);
        }
    }
}