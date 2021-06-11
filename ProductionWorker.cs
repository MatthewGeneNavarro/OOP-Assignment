using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    public class ProductionWorker : Employee
    {

        //Fields of ProductionWorker Class
        private int _shiftNumber;
        private double _hourlyPay;
        private string _assignedTeam;

        //Properties of ProductionWorker Class
        // I am setting all mutators to private to prevent changes from outside the class
        // Enforcing that either 1, 2 or 3 are inputs
        public int Shift
        {
            get { return _shiftNumber; }

            private set
            { 
                if(value < 1 && value > 3)
                {
                    Console.WriteLine("You must enter a value from 1-3");
                }
                else
                {
                    _shiftNumber = value;
                }
                 
            }
        }

        public double Pay
        {
            get { return _hourlyPay; }

            private set { _hourlyPay = value; }
        }

        public string Team
        {
            get { return _assignedTeam; }

            private set { _assignedTeam = value; }
        }

        //Constructors of ProductionWorker Class
        public ProductionWorker(string nameOfEmployee, string dateHired, int id, //Inherited from Employee Class
                                int shift, double pay, string team)
                                :base(nameOfEmployee, dateHired, id) // the problem with child classes is using parent
                                // constructor parameters. the base keyword lets you call them and include them in
                                // you object initialization. 
        {
            // I am making use of the properties to define the state of an object
            Shift = shift;
            Pay = pay;
            Team = team;
        }




        // Methods of ProductionWorker Class
        public void DisplayStatsProdWorker()
        {
            Console.WriteLine("Name\n");
            Console.WriteLine("ID\n");
            Console.WriteLine("Hire Date\n");
            Console.WriteLine("Shift\n");
            Console.WriteLine("Pay\n");
            Console.WriteLine("Team\n");
        }

    }
}
