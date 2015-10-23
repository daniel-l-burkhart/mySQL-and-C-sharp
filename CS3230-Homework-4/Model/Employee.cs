using System;

namespace CS3230_Homework_4.Model
{
    /// <summary>
    ///     The employee class.
    /// </summary>
    public class Employee
    {
        #region Methods

        /// <summary>
        ///     Gets the output.
        /// </summary>
        /// <returns></returns>
        public string GetOutput()
        {
            return "SSN: " + this.Ssn + " SuperSSN: " + this.SuperSsn + "\r\n" + "First Name: " + this.Fname +
                   " Middle Initial: " + this.Minit + " Last Name: " + this.Lname + "\r\n" + "Address: " + this.Address +
                   "\r\n" +
                   "Birthdate " + this.Birthdate + " Salary: " + this.Salary + " Sex: " + this.Sex +
                   " Dno: " + this.Dno;
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the SSN.
        /// </summary>
        /// <value>
        ///     The SSN.
        /// </value>
        public string Ssn { get; set; }

        /// <summary>
        ///     Gets or sets the super SSN.
        /// </summary>
        /// <value>
        ///     The super SSN.
        /// </value>
        public string SuperSsn { get; set; }

        /// <summary>
        ///     Gets or sets the fname.
        /// </summary>
        /// <value>
        ///     The fname.
        /// </value>
        public string Fname { get; set; }

        /// <summary>
        ///     Gets or sets the minit.
        /// </summary>
        /// <value>
        ///     The minit.
        /// </value>
        public string Minit { get; set; }

        /// <summary>
        ///     Gets or sets the lname.
        /// </summary>
        /// <value>
        ///     The lname.
        /// </value>
        public string Lname { get; set; }

        /// <summary>
        ///     Gets or sets the address.
        /// </summary>
        /// <value>
        ///     The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        ///     Gets or sets the birthdate.
        /// </summary>
        /// <value>
        ///     The birthdate.
        /// </value>
        public DateTime Birthdate { get; set; }

        /// <summary>
        ///     Gets or sets the salary.
        /// </summary>
        /// <value>
        ///     The salary.
        /// </value>
        public decimal Salary { get; set; }

        /// <summary>
        ///     Gets or sets the sex.
        /// </summary>
        /// <value>
        ///     The sex.
        /// </value>
        public string Sex { get; set; }

        /// <summary>
        ///     Gets or sets the dno.
        /// </summary>
        /// <value>
        ///     The dno.
        /// </value>
        public int Dno { get; set; }

        #endregion
    }
}