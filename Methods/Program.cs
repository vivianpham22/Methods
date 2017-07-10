﻿using System;
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


            string myBirthMonth = "September";
            string myFriendBirthMonth = "December";
            string myVehicle = Vehicle(myBirthMonth);
            string myFriendVehicle = Vehicle(myFriendBirthMonth);
        
            Console.WriteLine("My future vehicle is {0} and Jordans future vehicle is {1}", myVehicle, myFriendBirthMonth);


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

    }
}
