using System;

namespace CS3230_Homework_4.Model
{
    public class Employee
    {
        public string Ssn { get; set; }
        public string SuperSsn { get; set; }
        public string Fname { get; set; }
        public string Minit { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public decimal Salary { get; set; }
        public string Sex { get; set; }
        public int Dno { get; set; }

        public string GetOutput()
        {
            return "SSN: " + this.Ssn + " SuperSSN: " + this.SuperSsn + "\r\n" + "First Name: " + this.Fname +
                   " Middle Initial: " + this.Minit + " Last Name: " + this.Lname + "\r\n" + "Address: " + this.Address +
                   "\r\n" +
                   "Birthdate " + this.Birthdate + " Salary: " + this.Salary + " Sex: " + this.Sex +
                   " Dno: " + this.Dno;
        }
    }
}