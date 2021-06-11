using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    public class Employee
    {
        // Fields of Employee Class
        private string _employeeName;
        private string _hiringDate;
        private int _employeeID;

        //Properties of Employee Class
        public string Name
        {
            get { return _employeeName; }

           private set { _employeeName = value; }
        }

        public string DateOfHire
        {
            get { return _hiringDate; }
            
            private set { _hiringDate = value; }
        }

        public int ID
        {
            get { return _employeeID; }

            private set { _employeeID = value; }
        }

        //Constructors of Employee Class
        // I have to make the Constructors public because when child classes Inherit Employee they won't be able to use the Constructor.
        public Employee() { }
        public Employee(string nameOfEmployee, string dateHired, int id)
        {
            Name = nameOfEmployee;
            DateOfHire = dateHired;
            ID = id;
        }





        //Methods of Employee Class
        public void DisplayStatsEmployee()
        {
            
                Console.WriteLine("\nName");
                Console.WriteLine("ID");
                Console.WriteLine("Hire Date\n");
            


        }

    }
}
