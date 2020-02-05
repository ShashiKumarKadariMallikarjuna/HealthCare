using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare
{
    //class called Factory
    class Factory
    {
        //main method
        public static void Main(String[] args)
        {
            //getting the user input and assigning it to userInput variable
            int userInput = menu();
            //initializing the variable with null
            HealthPlan plan=null;

            //while loop to run the program until the user chooses to quit the program
            while (userInput != 4) {
                //if the user chooses HMO
                if (userInput == 1)
                {
                    plan = NewHMO();
                    Console.WriteLine($"The plan you chose is {plan.GetPlan()}");
                    Console.WriteLine($"The annual charge would be { plan.getAnnualCharge()}.");
                    Console.WriteLine($"The deduction amount would be {plan.getDeductionAmount()}.");
                    userInput = menu();    //getting the user input and assigning it to userInput variable
                }
                //if the user chooses PPO
                else if (userInput == 2)
                {
                    plan = NewPPO();
                    Console.WriteLine($"The plan you chose is {plan.GetPlan()}");
                    Console.WriteLine($"The annual charge would be {plan.getAnnualCharge()}.");
                    Console.WriteLine($"The deduction amount would be {plan.getDeductionAmount()}.");
                    userInput = menu();     //getting the user input and assigning it to userInput variable
                }
                //if the user chooses ObamaCare
                else
                {
                    plan = NewObamaCare();
                    Console.WriteLine($"The plan you chose is {plan.GetPlan()}");
                    Console.WriteLine($"The annual charge would be {plan.getAnnualCharge()}.");
                    Console.WriteLine($"The deduction amount would be {plan.getDeductionAmount()}.");
                    userInput = menu();      //getting the user input and assigning it to userInput variable
                }
            }
            //prints the following statement when the user selects to quit 
            Console.WriteLine("Thank you!");
                        
        }

        //method that prints, validates and returns the userInput
        public static int menu()
        {
            Console.WriteLine("\nHealth Care Plan:");
            Console.WriteLine("Choose the Health care plan that you want to apply:");
            Console.WriteLine("1. HMO");
            Console.WriteLine("2. PPO");
            Console.WriteLine("3. Obama Care");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose your option and press enter");
            int userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput < 1 || userInput > 4)
            {
                Console.WriteLine("ERROR! \n Choose the right option and press enter");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            return userInput;
        }

        //method that returns a new HMO object
        public static HMO NewHMO()
        {
            return new HMO(1000, 99);
        }

        //method that returns a new PPO object
        public static PPO NewPPO()
        {
            return new PPO(9999, 100);
        }

        //method that returns a new ObamaCare object
        public static ObamaCare NewObamaCare()
        {
            return new ObamaCare(1999, 600);
        }
    }
}
