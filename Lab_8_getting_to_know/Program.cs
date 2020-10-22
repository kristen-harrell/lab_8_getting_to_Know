using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Lab_8_getting_to_know
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[10];
            students[0] = "Kristen";
            students[1] = "Kevin";
            students[2] = "Keira";
            students[3] = "Lois";
            students[4] = "Harry";
            students[5] = "Jenny";
            students[6] = "Diego";
            students[7] = "Annie";
            students[8] = "Brian";
            students[9] = "Reily";

            string[] snacks = new string[10];
            snacks[0] = "macaroni and cheese";
            snacks[1] = "boneless wings";
            snacks[2] = "shawarma";
            snacks[3] = "spaghetti noodles";
            snacks[4] = "tuna";
            snacks[5] = "carrots";
            snacks[6] = "chicken";
            snacks[7] = "ice cream";
            snacks[8] = "chicken wings";
            snacks[9] = "bananas";

            string[] hometowns = new string[10];
            hometowns[0] = "Jacksonville, FL";
            hometowns[1] = "Mount Clemens, MI";
            hometowns[2] = "Clinton Township, MI";
            hometowns[3] = "Clinton Township, MI";
            hometowns[4] = "Clinton Township, MI";
            hometowns[5] = "San Juan, PR";
            hometowns[6] = "San Juan, PR";
            hometowns[7] = "Warren, MI";
            hometowns[8] = "Warren, MI";
            hometowns[9] = "Warren, MI";

            int index = -1;
            //Console.Clear();
            bool userContinue = true;
            while(userContinue)
            //while (BeginAgain());
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Which of our 10 students would you like to learn about?  Enter a number between 1 - 10");

                        index = int.Parse(Console.ReadLine()) - 1;

                        Console.WriteLine($"{ students[index] }");

                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex) // CATCH ALL Exceptions
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                //bool isValidInput = true;
                //while (isValidInput)
                //{
                Console.WriteLine($"Ok, what would you like to know about {students[index]}?");
                Console.Write($"Enter hometown, or favorite food: ");
                string selection = Console.ReadLine();
                while (VerifySelectionType(selection))
                {
                    //if (selection != "hometown" && selection != "favorite food")
                    //{
                    //    Console.WriteLine("I did not understand your entry.  Please try again");
                    //    isValidInput = false;
                    //}
                    if (selection == "hometown")
                    {
                        Console.WriteLine($"{students[index]} is originally from {hometowns[index]}");
                        break;
                        //isValidInput = true;
                    }
                    if (selection == "favorite food")
                    {
                        Console.WriteLine($"{students[index]}'s favorite food is {snacks[index]}");
                         break;
                        //isValidInput = true;
                    }
                }
                //}


                Console.Write("Do you want to learn about another student? Enter y/n: ");
                string continueInput = Console.ReadLine();
                if (continueInput == "y")
                {
                    userContinue = true;
                }
                else
                {
                    Console.WriteLine("Ok, goodbye!");
                    userContinue =  false;
                }

                //BeginAgain(continueInput);
                //if (continueInput == "n")
                //{
                //    userContinue = false;
                //    Console.WriteLine("ok, bye!");
                //}

            }
        }



        public static bool VerifyNumberInRange(int maxIndex, int userNumber)
        {
            //is this number in the range?
            if (userNumber < maxIndex || userNumber >= 0)
            {
                //yes, true, its in bounds
                return true;
            }
            else
            {
                //no, false, its too big or too small
                return false;
            }
        }

        public static bool VerifySelectionType(string userInput)
        {
            //is this an acceptable response?
            if (userInput == "hometown" || userInput == "favorite food")
            {
                //yes, true, its a real choice that I have data for
                return true;
            }
            else
            {
                //no, idk what this is
                Console.WriteLine("I do not understand your entry.  Please try again");
                return false;
            }
        }


        //public static bool BeginAgain(string input)
        //{
        //    if (input.ToLower() == "y" )
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ok, goodbye!");
        //        return false;
        //    }

        //}

        //public static string GetInfoTypeSelection(string choice)
        //{
        //    string selection = choice;
        //    if (selection == "hometown")
        //    {
        //        Console.WriteLine($"{students[index]} is originally from {hometowns[index]}");
        //    }
        //    if (selection == "favorite food")
        //    {
        //        Console.WriteLine($"{students[index]}'s favorite food is {snacks[index]}");
        //    }
        //    if (selection != "hometown"  && selection != "favorite food")
        //    {
        //        Console.WriteLine("I do not understand your selection.  Please try again");
        //    }
        //}

    }
}
