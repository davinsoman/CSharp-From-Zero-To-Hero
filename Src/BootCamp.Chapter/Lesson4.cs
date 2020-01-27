﻿using System;
using Console = System.Console;

namespace BootCamp.Chapter
{
    public class Lesson4
    {
        public static void Demo()
        {
            Console.WriteLine("Please enter your data" + Environment.NewLine);
            do
            {
                var name = PromptString("What is your first name?");
                var surname = PromptString("What is your last name?");
                var age = PromptInt("What is your age");
                var weight = PromptFloat("What is your weight in kilograms");
                var heightCm = PromptFloat("What is your height in centimeters");
                var bmi = CalculateBmi(weight, heightCm / 100);

                Console.WriteLine();
                Console.WriteLine("Name: " + name + " " + surname);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Weight: " + weight + "kg");
                Console.WriteLine("Height: " + heightCm / 100 + "m");
                Console.WriteLine("BMI: " + bmi);


                Console.WriteLine(Environment.NewLine + "Continue with a new set of inputs? " +
                "Press Y to continue or press any other button to exit the program" + Environment.NewLine);

                string answer = Console.ReadLine().ToLowerInvariant();
                if (answer == "y")
                {
                    Console.WriteLine(Environment.NewLine + "Please enter your data" + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Thank you. Good Bye");
                    break;
                }
            }
            while (true);

        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var GrabString = Console.ReadLine();
            var StringCheck = string.IsNullOrWhiteSpace(GrabString);
            if (StringCheck == true)
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            else
            {
                return GrabString;
            }
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var GrabInt = Console.ReadLine();
            //Checks if input of age is empty or not
            var IntNumberCheck = string.IsNullOrWhiteSpace(GrabInt);
            //Checks if input is a valid number or not
            if (IntNumberCheck != true)
            {
                bool CheckValidNumber = int.TryParse(GrabInt, out int age);
                if (CheckValidNumber == true)
                {
                    return age;
                }
                else
                {
                    Console.WriteLine(GrabInt + " is not a valid number");
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var GrabFloat = Console.ReadLine();
            //Checks if input of age is empty or not
            var FloatNumberCheck = string.IsNullOrWhiteSpace(GrabFloat);
            //Checks if input is a valid number or not
            if (FloatNumberCheck != true)
            {
                bool CheckValidNumber = int.TryParse(GrabFloat, out int measurement);
                if (CheckValidNumber == true)
                {
                    return measurement;
                }
                else
                {
                    Console.WriteLine(GrabFloat + " is not a valid number");
                    return -1;
                }
            }
            else
            {
                return 0;
            }


            //return float.Parse(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason: ");
                if (weight <= 0 && height <= 0)
                {
                    Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                    Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                }
                else if (weight <= 0)
                {
                    Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                }
                else if (height <= 0)
                {
                    Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                }

            }

            return weight / (height * height);

        }


    }
}