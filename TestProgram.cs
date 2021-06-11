using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    class TestProgram
    {




        public static void Main(string[] args)
        {
            int workerClass; // steers the user

            //For employee attributes
             string name;
             string date;
             int id;

            // For Production Worker
            int shiftNumber;
            double hourlyPay;
            string assignedTeam;

            //For TeamLeader
            int monthlyBonus;
            int requiredTrainingHours;
            int completedTrainingHours;

            //For Shift supervisor
            int annunalSalary;
            int assignedShift;
            int yearlyBonus;




        Console.WriteLine("Hello and welcome to the Employee Asset Program.\n");
            Console.WriteLine("Select the number of the class you want to create\n1. Create a new Employee\n2. Create a new Production Worker\n3. Create a new Team Leader \n4. Create a new Shift Supervisor\n");
            workerClass = Convert.ToInt32(Console.ReadLine());
            
            

            // created this objects just to test if the classes work
            Employee testEmployee = new Employee("Matt", "6/10/2021", 1001);

            ProductionWorker testProductionWorker = new ProductionWorker("Jack", "6/10/2021", 1002, 1, 10.00, "Red Team");
            TeamLeader teamLeader = new TeamLeader("Cooper", "6/10/2021", 1003, 2, 13.00, "Blue Team", 200, 10, 5);

            ShiftSupervisor shiftSupervisor = new ShiftSupervisor("Kaitlin", "6/10/2021", 1004, 55000, 3, 5000);




           

            switch (workerClass)
            {

                case 1:
                    Console.WriteLine("The Employee needs the following attributes:");
                    testEmployee.DisplayStatsEmployee(); // object of the Employee Class calling the DisplayStatsEmployee method
                    break;
                case 2:
                    Console.WriteLine("The Production Worker needs the following attributes:");
                    testProductionWorker.DisplayStatsProdWorker(); // object of the Production Worker class calling the DisplayStatProdWorker method
                    break;
                case 3:
                    Console.WriteLine("The Team Leader needs the following attributes:");
                    teamLeader.DisplayStatsTeamLed(); // object of the LeaderClass calling the DisplayStatsTeamLed method
                    break;
                case 4:
                    Console.WriteLine("The Shift Supervisor needs the following attributes:");
                    shiftSupervisor.DisplayStatsEmployee(); // object of the Supervisor Class calling the DisplayStatsEmployee method
                    break;
            }

            //if(workerClass == 1)
            //{
            //    string nameOf;
            //    Console.WriteLine("What will be the name of the employee?");
            //    nameOf = Console.ReadLine();
            //    Employee nameOf = new Employee();

            //}






            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            /////////////                                                        //////////////////
            ///////////// These Console Writes test that the testProgram class   //////////////////
            ///////////// can access the other classes and that the constructors //////////////////
            /////////////       are properly inherited                           //////////////////
            /////////////                                                        //////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////


            //Console.WriteLine("Test Employee:\n\n1. Name: {0}\n2. Date Hired: {1}\n3. Employee ID: {2}\n", testEmployee.Name, testEmployee.DateOfHire, testEmployee.ID);

            //Console.WriteLine("\nTest Production Worker:\n\n1. Name: {0}\n2. Date Hired: {1}\n3. Employee ID: {2}\n4. Shift: {3}\n5. Pay: {4}\n6. Team: {5}\n", testProductionWorker.Name, testProductionWorker.DateOfHire, testProductionWorker.ID, testProductionWorker.Pay, testProductionWorker.Shift, testProductionWorker.Team);

            //Console.WriteLine("\nTest Team Leader:\n\n1. Name: {0}\n2. Date Hired: {1}\n3. Employee ID: {2}\n4. Shift: {3}\n5. Pay: {4}\n6. Team: {5}\n7.Bonus: {6}\n8. Required Training: {7}\n9. Completed Training: {8}\n", teamLeader.Name,teamLeader.DateOfHire,teamLeader.ID, teamLeader.Pay, teamLeader.Shift, teamLeader.Team, teamLeader.Bonus, teamLeader.RequiredTraining, teamLeader.CompletedTraining);

            //Console.WriteLine("\nTest Shift Supervisor:\n\n1.Name: {0}\n2. Date Hired: {1}\n.3 Employee ID: {2}\n4. Salary: {3}\n5. Shift: {4}\n6. Bonus: {5}", shiftSupervisor.Name, shiftSupervisor.DateOfHire, shiftSupervisor.ID, shiftSupervisor.Salary, shiftSupervisor.Shift, shiftSupervisor.Bonus);

            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////                                                                     ///////////
            ////////////  These are calls to each classes uniquely named Display Stat Method ///////////
            ////////////                                                                     //////////
            ////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////

            //testEmployee.DisplayStatsEmployee();
            //testProductionWorker.DisplayStatsProdWorker();
            //teamLeader.DisplayStatsTeamLed();
            //shiftSupervisor.DisplayStatsSup();




            Console.ReadKey();

        }
    }
}
