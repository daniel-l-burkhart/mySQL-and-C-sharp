using System;
using System.Collections.Generic;
using System.Configuration;
using CS3230ExploringTheRepositoryPattern.DAL.Interfaces;
using CS3230_Homework_4.Model;
using MySql.Data.MySqlClient;

namespace CS3230_Homework_4.DAL.Repository
{
    /// <summary>
    ///     The Employee Repository
    /// </summary>
    public class EmployeeRepository : IRepository<Employee>
    {
        /// <summary>
        ///     The connection string
        /// </summary>
        private readonly string connectionString;

        /// <summary>
        ///     Initializes a new instance of the <see cref="EmployeeRepository" /> class.
        /// </summary>
        /// <param name="connection">The connection.</param>
        public EmployeeRepository(string connection = "MySqlDbConnection")
        {
            this.connectionString = connection;
        }

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
        ///     Gets all.
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
                        //or 
                        //cmd = new MySqlCommand();
                        // cmd.CommandType = CommandType.Text;
                        // cmd.CommandText = "select fname, bdate from EMPLOYEE";
                        // cmd.Connection = conn;

                        using (var dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var currEmployee = new Employee
                                {
                                    Ssn = dataReader["ssn"] as string,
                                    SuperSsn = dataReader["superssn"] as string,
                                    Fname = dataReader["fname"] as string,
                                    Minit = dataReader["minit"] as string,
                                    Lname = dataReader["lname"] as string,
                                    Address = dataReader["address"] as string,
                                    Birthdate =
                                        (Convert.IsDBNull(dataReader["bdate"])
                                            ? DateTime.MinValue
                                            : (DateTime) dataReader["bdate"]),
                                    Salary =
                                        (Convert.IsDBNull(dataReader["salary"])
                                            ? decimal.MinValue
                                            : (decimal) dataReader["salary"]),
                                    Sex = dataReader["sex"] as string,
                                    Dno = (Convert.IsDBNull(dataReader["dno"]) ? int.MinValue : (int) dataReader["dno"])
                                };
                                allEmployees.Add(currEmployee);
                            }
                            dataReader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch
            {
                Console.WriteLine("DB connect failed.");
            }
            return allEmployees;
        }

        public IList<Employee> GetAllEmployeesBySupervisor(string superSsn)
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
                        cmd.Parameters.AddWithValue("@superSsn", superSsn);


                        using (var dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                var currEmployee = new Employee
                                {
                                    Ssn = dataReader["ssn"] as string,
                                    SuperSsn = dataReader["superssn"] as string,
                                    Fname = dataReader["fname"] as string,
                                    Minit = dataReader["minit"] as string,
                                    Lname = dataReader["lname"] as string,
                                    Address = dataReader["address"] as string,
                                    Birthdate =
                                        (Convert.IsDBNull(dataReader["bdate"])
                                            ? DateTime.MinValue
                                            : (DateTime) dataReader["bdate"]),
                                    Salary =
                                        (Convert.IsDBNull(dataReader["salary"])
                                            ? decimal.MinValue
                                            : (decimal) dataReader["salary"]),
                                    Sex = dataReader["sex"] as string,
                                    Dno = (Convert.IsDBNull(dataReader["dno"]) ? int.MinValue : (int) dataReader["dno"])
                                };
                                allEmployees.Add(currEmployee);
                            }
                            dataReader.Close();
                        }
                    }
                    conn.Close();
                }
            }
            catch
            {
                Console.WriteLine("DB connect failed.");
            }
            return allEmployees;
        }
    }
}