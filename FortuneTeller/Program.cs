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
            Console.WriteLine("At any time in this program you may type \"Quit\" to end the session.");
            Console.WriteLine();
            Console.WriteLine("All that I need from you is six personal facts. These must be " +
                "true, because I can tell if you are lying!");
            Console.WriteLine();
            string quitter = "Nobody likes a quitter...";

            Console.WriteLine("To begin, What is your first name?");
            string firstName = Console.ReadLine();
            string lowerCaseFirstName = firstName.ToLower();

            if(lowerCaseFirstName == "quit")
            {
                Console.WriteLine(quitter);
                Environment.Exit(0);
            }

            Console.WriteLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            string lowerCaseLastName = lastName.ToLower();

            if (lowerCaseLastName == "quit")
            {
                Console.WriteLine(quitter);
                Environment.Exit(0);
            }

            Console.WriteLine();
            Console.WriteLine("What is your age? Ladies, your age will not be disclosed.");
            string userAgeString = Console.ReadLine();

            if (userAgeString == "quit")
            {
                Console.WriteLine(quitter);
                Environment.Exit(0);
            }
            int userAge;
            userAge = Convert.ToInt32(userAgeString);

            while (userAge <= 0 || userAge > 120)
            {
                if (userAge <= 0)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your age has to be greater than zero \"0\".");
                    } while (!int.TryParse(Console.ReadLine(), out userAge));
                }

                if (userAge > 120)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Are you sure?!? Most people do not live past 120.");
                    } while (!int.TryParse(Console.ReadLine(), out userAge));
                }
            }

            Console.WriteLine();
            Console.WriteLine("What is your birth month? Please enter the 2 digit month, not the name.");
            string userBirthMonthString = Console.ReadLine();

            if (userBirthMonthString == "quit")
            {
                Console.WriteLine(quitter);
                Environment.Exit(0);
            }
            int userBirthMonth;
            userBirthMonth = Convert.ToInt32(userBirthMonthString);

            while (userBirthMonth > 12 || userBirthMonth < 1)
            {
                if (userBirthMonth > 12)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You know there are only 12 months in a year?!?!");
                    } while (!int.TryParse(Console.ReadLine(), out userBirthMonth));
                }

                if (userBirthMonth > 12 || userBirthMonth < 1)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Come on! What IS a negative month?.");
                    } while (!int.TryParse(Console.ReadLine(), out userBirthMonth));
                }
            }

            Console.WriteLine();
            Console.WriteLine("What is your favorite \"ROYGBIV\" color?  If you are not familiar " +
            "with the term \"ROYGBIV\" please type \"Help\".");
            string userFavColor = Console.ReadLine();
            string lowerCaseUserFavColor = userFavColor.ToLower();

            if (lowerCaseUserFavColor == "quit")
            {
                Console.WriteLine(quitter);
                Environment.Exit(0);
            }

            while (lowerCaseUserFavColor != "red" && lowerCaseUserFavColor != "orange" &&
                lowerCaseUserFavColor != "yellow" && lowerCaseUserFavColor != "green" &&
                lowerCaseUserFavColor != "blue" && lowerCaseUserFavColor != "indigo" &&
                lowerCaseUserFavColor != "violet" && lowerCaseUserFavColor != "help")
            {
                Console.WriteLine("Please enter a \"ROYGBIV\" color or enter \"Help\".");
                userFavColor = Console.ReadLine();
                lowerCaseUserFavColor = userFavColor.ToLower();

                if (lowerCaseUserFavColor == "quit")
                {
                    Console.WriteLine(quitter);
                    Environment.Exit(0);
                }

                if (lowerCaseUserFavColor.ToLower() == "help")
                {
                    Console.WriteLine("The following colors are \"ROYGBIV\" colors: ");
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.WriteLine("Please enter one of these colors.");
                    userFavColor = Console.ReadLine();
                    lowerCaseUserFavColor = userFavColor.ToLower();

                    if (lowerCaseUserFavColor == "quit")
                    {
                        Console.WriteLine(quitter);
                        Environment.Exit(0);
                    }
                }
            }
            if (lowerCaseUserFavColor.ToLower() == "help")
            {
                Console.WriteLine("The following colors are \"ROYGBIV\" colors: ");
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                Console.WriteLine("Please enter one of these colors.");
                userFavColor = Console.ReadLine();
                lowerCaseUserFavColor = userFavColor.ToLower();

                while (lowerCaseUserFavColor != "red" && lowerCaseUserFavColor != "orange" &&
                lowerCaseUserFavColor != "yellow" && lowerCaseUserFavColor != "green" &&
                lowerCaseUserFavColor != "blue" && lowerCaseUserFavColor != "indigo" &&
                lowerCaseUserFavColor != "violet" && lowerCaseUserFavColor != "help")
                {
                    Console.WriteLine("Please enter the a correct color.");
                    userFavColor = Console.ReadLine();
                    lowerCaseUserFavColor = userFavColor.ToLower();

                    if (lowerCaseUserFavColor == "quit")
                    {
                        Console.WriteLine(quitter);
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("How many siblings do you have?");
            string userSiblingsString = Console.ReadLine();

            if (userSiblingsString == "quit")
            {
                Console.WriteLine(quitter);
                Environment.Exit(0);
            }
            int userSiblings;
            userSiblings = Convert.ToInt32(userSiblingsString);

            Console.WriteLine();
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
                Console.Write("a vacation home in Kauai, Hawaii ");
            }
            else if (userSiblings == 1)
            {
                Console.Write("a vacation home in fabulous Viti Levu, Fiji ");
            }
            else if (userSiblings == 2)
            {
                Console.Write("a vacation home in terrific Toronto, Canada ");
            }
            else if (userSiblings == 3)
            {
                Console.Write("a vacation home in lovely Los Cabos, Mexico ");
            }
            else
            {
                Console.Write("a vacation home in a foreign Insane Asylum ");
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
                    Console.Write("and a banana seat bike.\n");
                    break;
                case "green":
                    Console.Write("and a Honda Prius.\n");
                    break;
                case "blue":
                    Console.Write("and a Learjet 60 airplane.\n");
                    break;
                case "indigo":
                    Console.Write("and a helicopter.\n");
                    break;
                case "violet":
                    Console.Write("and a horse and buggy.\n");
                    break;
                default:
                    Console.Write("and you do not have any transportation.\n");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("________________");
        }
    }        
}

