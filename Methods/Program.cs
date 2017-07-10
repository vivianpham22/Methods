using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Methods are a tool for us to create reusable pieces of code. 

            ////Methods are a way of us collectihng a srires of intruction and then call them
            ////when we need them.

            ////Methods are ALWAYS part of a class. 
            ////Methods are ALWAYS childrens.
            //// - meaning a method will NEVER be inside another method or member of the class.
            //// - However, methods are frequently CALLED inside of another class or method.

            //Console.WriteLine("Hello. Please enter the first number to be added.");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number to be added.");
            //int numberTwo = int.Parse(Console.ReadLine());




            //int answer = Add(numberOne, numberTwo);

            //Console.WriteLine("The sum of your two numbers is " + answer);

            //// ANOTHER EXAMPLE
            //// int answer = Add(5, 7);
            ////Console.WriteLine(answer);


            //// Robot example
            //RobotWarning("Will Robinson");
            //Useless();

            //// Birthday and Vehicle example
            //string myBirthMonth = "September";
            //string myFriendBirthMonth = "December";
            //string myVehicle = Vehicle(myBirthMonth);
            //string myFriendVehicle = Vehicle(myFriendBirthMonth);

            //Console.WriteLine("My future vehicle is {0} and Jordans future vehicle is {1}", myVehicle, myFriendBirthMonth);


            //favoriteFood("Fries", "Vivian");

            //RetirementCalculator(23);



            //double hoursWorked = 42.3d;
            //double hourlyWage = 12.50d;

            //Console.WriteLine("Your monthly wage is {0}.", WageCalculator(hoursWorked, hourlyWage));

            petName("Jax");



        }

        //Access Modifier - Return Type - Method Name (in Pascal Case) - Pernthesis (sometimes with paramaters) *******
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method body 
            //A complete method - header and body - is called a metho declaration 

            int sum = firstNumber + secondNumber;

            return sum;
            // The "return" keyword takes whatever value is determined by using this method 
            // and send that value back to where I called method. 

        }
        // If you have a method that does not have a return value, you would use the keyword 
        // "void". When we have a "void" return type we DON'T need to use the keyword "return"

        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!");

        }

        public static void Useless()
        {
            Console.WriteLine("Blah blah blah.");
        }

        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";
            }
            else
            {
                vehicleFortune = " SUV";
            }

            return vehicleFortune;
        }

        // Create a string called FavoriteFood
        // It should take two string parameters. 
        // - One representing a name, and the other respresenting a favorite food.
        // The return should be a void
        // The method should concatenmate

        public static void favoriteFood(string food, string name)
        {
            Console.WriteLine(name + "'s favorite food is " + food);
        }


        // Create a method called RetirementCalculator 
        // It should take an int as a paramater representing the users gae
        // The method should calculate how many more years until the user retires using 65 as the age of retirement.
        // The return type should be void, should be an INT
        // Once it calculates the users retirement age it should print 
        // - " The users will retires in X years" where X represents the value that was calculated.

        public static void RetirementCalculator(int age)
        {
            int retireAge = 65 - age;
            Console.WriteLine("You will retire in {0} years", retireAge);
        }

        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        {
            //This method should calculate the MONTHLY wage
            double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;
            return monthlyWage;
        }
        

        // Create 2 methods of your chosing. 
        // One should have a non-void return type. 
        // Both of the methods should take at least one parameter.
        // Remember when naming your methof that it should represent what your method does.
        // Your method should only to accomplish one thing. 
        // Be creative

        public static void petName(string pet)
        {
            Console.WriteLine("My pets names is " + pet);
        }
         
        
     

    }
}
