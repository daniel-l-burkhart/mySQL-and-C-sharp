using System;
using System.Collections.Generic;
using System.Configuration;
using CS3230_Homework_4.DAL.Interfaces;
using CS3230_Homework_4.Model;
using MySql.Data.MySqlClient;

namespace CS3230_Homework_4.DAL.Repository
{
    /// <summary>
    ///     The Employee Repository
    /// </summary>
    public class EmployeeRepository : IRepository<Employee>
    {
        #region Instance Variable

        /// <summary>
        ///     The connection string
        /// </summary>
        private readonly string connectionString;

        #endregion

        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="EmployeeRepository" /> class.
        /// </summary>
        /// <param name="connection">The connection.</param>
        public EmployeeRepository(string connection = "MySqlDbConnection")
        {
            this.connectionString = connection;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets all the employees.
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetAll()
        {
            IList<Employee> allEmployees = new List<Employee>();

            try
            {
                var connStr = ConfigurationManager.ConnectionStrings[this.connectionString].ConnectionString;

                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (var cmd = new MySqlCommand("SELECT * from EMPLOYEE", conn))
                    {
                        using (var dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                DateTime birthday; 

                                var currEmployee = new Employee
                                {
                                    Ssn = dataReader["ssn"] as string,
                                    SuperSsn = dataReader["superssn"] as string,
                                    Fname = dataReader["fname"] as string,
                                    Minit = dataReader["minit"] as string,
                                    Lname = dataReader["lname"] as string,
                                    Address = dataReader["address"] as string,
                                
                                    Salary =
                                        (Convert.IsDBNull(dataReader["salary"])
                                            ? decimal.MinValue
                                            : (decimal) dataReader["salary"]),

                                    Sex = dataReader["sex"] as string,
                                    Dno = (Convert.IsDBNull(dataReader["dno"]) ? int.MinValue : (int) dataReader["dno"])
                                };

                                if (dataReader["bdate"] != DBNull.Value)
                                {
                                    DateTime.TryParse(dataReader["bdate"].ToString(), out birthday);
                                }
                                else
                                {
                                    birthday = DateTime.MinValue;
                                }

                                currEmployee.Birthdate = birthday;

                                allEmployees.Add(currEmployee);
                            }
                            dataReader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch (MySqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return allEmployees;
        }

        /// <summary>
        ///     Gets all employees by supervisor.
        /// </summary>
        /// <param name="superSsn">The super SSN.</param>
        /// <returns></returns>
        public IList<Employee> GetAllEmployeesBySupervisor(string superSsn)
        {
            IList<Employee> allEmployees = new List<Employee>();

            try
            {
                var connStr = ConfigurationManager.ConnectionStrings[this.connectionString].ConnectionString;

                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    using (var cmd = new MySqlCommand("SELECT * from EMPLOYEE WHERE superssn=@superssn", conn))
                    {
                        cmd.Parameters.AddWithValue("@superssn", superSsn);

                        using (var dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                DateTime birthday;

                                var currEmployee = new Employee
                                {
                                    Ssn = dataReader["ssn"] as string,
                                    SuperSsn = dataReader["superssn"] as string,
                                    Fname = dataReader["fname"] as string,
                                    Minit = dataReader["minit"] as string,
                                    Lname = dataReader["lname"] as string,
                                    Address = dataReader["address"] as string,

                                    Salary =
                                        (Convert.IsDBNull(dataReader["salary"])
                                            ? decimal.MinValue
                                            : (decimal) dataReader["salary"]),

                                    Sex = dataReader["sex"] as string,
                                    Dno = (Convert.IsDBNull(dataReader["dno"]) ? int.MinValue : (int) dataReader["dno"])
                                };

                                if (dataReader["bdate"] != DBNull.Value)
                                {
                                    DateTime.TryParse(dataReader["bdate"].ToString(), out birthday);
                                }
                                else
                                {
                                    birthday = DateTime.MinValue;
                                }

                                currEmployee.Birthdate = birthday;

                                allEmployees.Add(currEmployee);
                            }
                            dataReader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch (MySqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return allEmployees;
        }

        #endregion
    }
}