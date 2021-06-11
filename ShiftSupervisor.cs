using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    class ShiftSupervisor : Employee
    {
        //Fields of ShiftSupervisor Class
        private int _annunalSalary;
        private int _assignedShift;
        private int _yearlyBonus;

        

        // Properties of ShiftSupervisor Class
        // I am setting all mutators to private to prevent changes from outside the class

        public int Salary
        {
            get { return _annunalSalary; }

            private set { _annunalSalary = value; }
        }

        // Enforcing that either 1, 2 or 3 are inputs
        public int Shift
        {
            get { return _assignedShift; }

            private set
            {

                if (value < 1 && value > 3)
                {
                    Console.WriteLine("You must enter a value from 1-3");
                }
                else
                {
                    _assignedShift = value;
                }
            }
        }

        public int Bonus
        {
            get { return _yearlyBonus; }

            private set { _yearlyBonus = value; }
        }

        // Constructors of ShiftSupervisor Class

        public ShiftSupervisor(string nameOfEmployee, string dateHired, int id, //Inherited from Employee Class
                               int salary, int shift, int bonus)                //Native to Class
                               :base (nameOfEmployee, dateHired, id)// the problem with child classes is using parent
                               // constructor parameters. the base keyword lets you call them and include them in
                               // you object initialization. 
        {
            Salary = salary;

            Shift = shift;

            Bonus = bonus;

        }





        //Methods of ShiftSupervisor Class
        public void DisplayStatsSup()
        {
            // Inheirited from Employee Class
            Console.WriteLine("Name\n");
            Console.WriteLine("ID\n");
            Console.WriteLine("Hire Date\n");

            // Native to Shift Supervisor Class
            Console.WriteLine("Salary\n");
            Console.WriteLine("Bonus\n");
            Console.WriteLine("Shift\n");
            


        }




    }
}
