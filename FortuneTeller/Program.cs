using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this first section I am asking the user for their information
            Console.WriteLine("Welcome, I am Freddy THE Fabulous Fantastic Fortune Teller! \n" +
                "\nI will tell you when you will retire.  \nI will tell you what mode of " +
                "transportation that you currently use. \nI will tell you where your " +
                "vacation house will be located. \nI will forsee the fortune that you " +
                "will acquire.");
            Console.WriteLine();
            Console.WriteLine("All that I need from you is six personal facts. These must be" +
                "true, because I can tell if you are lying!");
            Console.WriteLine();
            Console.WriteLine("To begin, What is your first name?");
            string firstName = Console.ReadLine();
            string lowerCaseFirstName = firstName.ToLower();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            string lowerCaseLastName = lastName.ToLower();

            Console.WriteLine("What is your age? Ladies, your age will not be disclosed.");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge <= 0)
            {
                Console.WriteLine("You are not born yet.");
            }

            Console.WriteLine("What is your birth month? Please enter the 2 digit month, not the name.");
            int userBirthMonth = int.Parse(Console.ReadLine());

            if(userBirthMonth > 12 || userBirthMonth < 1)
            {
                Console.WriteLine("You know there are only 12 months in a year.");
            }

            Console.WriteLine("What is your favorite \"ROYGBIV\" color?  If you are not familiar " +
                "with the term \"ROYGBIV\" please type \"Help\".");
            string userFavColor = Console.ReadLine();
            string lowerCaseUserFavColor = userFavColor.ToLower();
            
            //This if statement is for if the user types in the word "help".
            if (lowerCaseUserFavColor.ToLower() == "help")
            {
                Console.WriteLine("The following colors are \"ROYGBIV\" colors: ");
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                Console.WriteLine("Please enter one of these colors.");
                userFavColor = Console.ReadLine();
            }

            Console.WriteLine("How many siblings do you have?");
            int userSiblings = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for making the right choice in utilizing my " +
                "exquisite talents to determine your future!\n\n" +
                "I will tell your fortune momentarily. \n\n\n");

            //The second section is where I take the users information and determine
            //the fortunes of the user is multiple areas of their life

            //If the users age is even they will retire in 20 years if odd then 30 years

            Console.Write(firstName + " " + lastName + " will retire in ");
            if (userAge % 2 == 0)
            {
                Console.Write("20 years "); 
            }
            else
            {
                Console.Write("30 years ");
            }

            //This part is to use the user's birth month to determine the amount
            //of money the user has in the bank

            if (userBirthMonth > 1 && userBirthMonth <= 4)
            {
                Console.Write("with $1.00 in the bank, ");
            }
            else if (userBirthMonth > 4 && userBirthMonth <= 8)
            {
                Console.Write("with $1,293,485.67 in the bank,");
            }
            else if (userBirthMonth > 8 && userBirthMonth <= 12)
            {
                Console.Write("with $.32 in the bank, ");
            }
            else
            {
                Console.WriteLine("with $0 in the bank, ");
            }
            //The number of the user's siblings will determine the location
            //of their vacation home

            if (userSiblings == 0)
            {
                Console.Write("a vacation home in Heavenly Hawaii ");
            }
            else if(userSiblings == 1)
            {
                Console.Write("a vacation home in Fabulous Fiji ");
            }
            else if(userSiblings == 2)
            {
                Console.Write("a vacation home in Terrific Toronto ");
            }
            else if(userSiblings == 3)
            {
                Console.Write("a vacation home in Lovely Los Cabos ");
            }
            else
            {
                Console.Write("a vacation home in an Insane Asylum ");
            }

            //The color selected will determine the user's transportation

            switch (lowerCaseUserFavColor)
            {
                case "red":
                    Console.Write("and a sports car.");
                    break;
                case "orange":
                    Console.Write("and a skateboard.\n");
                    break;
                case "yellow":
                    Console.Write("is a banana seat bike.\n");
                    break;
                case "green":
                    Console.Write("is a Honda Prius.\n");
                    break;
                case "blue":
                    Console.Write("is an airplane.\n");
                    break;
                case "Indigo":
                    Console.Write("is a helicopter.\n");
                    break;
                case "Violet":
                    Console.Write("is horse and buggy.\n");
                    break;
                default:
                    Console.Write("and you do not have any transportation.\n");
                    break;                
            }
            Console.WriteLine();
        }
    }
}
