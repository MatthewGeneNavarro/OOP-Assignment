using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    sealed class TeamLeader : ProductionWorker
    {
        // Fields of TeamLeader Class
        private int _monthlyBonus = 200;
        private int _requiredTrainingHours = 10;
        private int _completedTrainingHours;

        //Properties of TeamLeader Class
        // I am setting all mutators to private to prevent changes from outside the class
        public int Bonus
        {
            get { return _monthlyBonus; }

            private set { _monthlyBonus = value; }
        }

        public int RequiredTraining
        {
            get { return _requiredTrainingHours; }

            private set { _requiredTrainingHours = value; }
        }

        public int CompletedTraining
        {
            get { return _completedTrainingHours; }

            private set { _completedTrainingHours = value; }
        }


        //Constructors of TeamLeader Class
        public TeamLeader(string nameOfEmployee, string dateHired, int id, //Inherited from Employee Class
                          int shift, double pay, string team, // Inherited from ProductionWorker Class
                          int bonusAmount, int reqTrainingHrs, int comTrainingHrs) // Native to Class
                          : base (nameOfEmployee, dateHired, id, shift, pay, team)// the problem with child classes is using parent
                          // constructor parameters. the base keyword lets you call them and include them in
                          // you object initialization. 
        {
            Bonus = bonusAmount;
            RequiredTraining = reqTrainingHrs;
            CompletedTraining = comTrainingHrs;


        }

        //Methods of TeamLeaderClass
        public void DisplayStatsTeamLed()
        {   // Inheirited from Employee Class
            // I used the accessor to retrieve private field
            Console.WriteLine("Name\n");
            Console.WriteLine("ID\n");
            Console.WriteLine("Hire Date\n");

            // Inheirited from Production Worker Class
            // I used the accessor to retrieve private field
            Console.WriteLine("Shift\n");
            Console.WriteLine("Pay\n");
            Console.WriteLine("Team\n");

            //Native to Team Leader
            Console.WriteLine("Bonus\n");
            Console.WriteLine("Required Training Hours\n");
            Console.WriteLine("Completed Hours\n");
        }


    }
}
