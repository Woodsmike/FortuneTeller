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

            //set up a variable of quitter for later use
            string quitter = "Nobody likes a quitter...";

            //for all the user inputs, except for age and birth month, I changed the string
            //variable to one that is in all lowercase letters.  This is so the user's input
            //will not be case sensitive throughout the application.
            Console.WriteLine("To begin, What is your first name?");
            string firstName = Console.ReadLine();
            string lowerCaseFirstName = firstName.ToLower();

            //I used the following if statement at every location where the user has the 
            //opportunity to type in a value.  I also used the variable quitter.
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
            //for the age variable, I converted the string variable 'userAgeString'
            //into an int variable 'userAge'.
            //**As an extra I used the if statment, while and do while loops to have
            //the user input a viable age.
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
                        Console.WriteLine("Please enter in your true age.");
                    } while (!int.TryParse(Console.ReadLine(), out userAge));
                }

                if (userAge > 120)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Are you sure?!? Most people do not live past 120.");
                        Console.WriteLine("Please enter in your true age.");
                    } while (!int.TryParse(Console.ReadLine(), out userAge));
                }
            }

            Console.WriteLine();
            Console.WriteLine("What is your 2 digit birth month ... NOT the name.");
            string userBirthMonthString = Console.ReadLine();

            if (userBirthMonthString == "quit")
            {
                Console.WriteLine(quitter);
                Environment.Exit(0);
            }
            //for the birth month variable, I converted the string variable 
            //'userBirthMonthString' into an int variable 'userBirhtMonth'.
            //**As an extra I used the if statement, while and do while loops to 
            //have the user input a viable birth month.
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
                        Console.WriteLine("Please enter in a birth month between 1 - 12.");
                    } while (!int.TryParse(Console.ReadLine(), out userBirthMonth));
                }

                if (userBirthMonth > 12 || userBirthMonth < 1)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Come on! What IS a negative month?.");
                        Console.WriteLine("Please enter in a birth month between 1 - 12.");
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

            //In this section I wanted the user to give a correct answer for color before
            //moving on to the last question.  In order to do that, I needed to use a while
            //loop to catch any string that did not match the colors and the word "help". 
            //The correct operator is the && sign.
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

                //If the user did not enter a correct color or know what ROYGBIV means,
                //they would have the chance to type help.  I displayed the options of the
                //colors available.  If the user enters "help" again, the program takes
                //him to the next while, if, while section.
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

            //I had to add this section because the first while section let the user
            //enter "help" which would break out of the previous loop.  Thus, I had to
            //create a loop if the "help" string was entered a second time.
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
                lowerCaseUserFavColor != "violet")
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
            //the fortunes of the user in multiple areas of their life.

            //Part 3 required to print a line of code back to the console.  I used
            //Console.Write() which concatenated each area that I needed to print on 
            //one line in the correct order.  I could have used variables and referenced 
            //the variables on a Console.WriteLine(). 

            //If the users age is even they will retire in 20 years if odd then 30 years.
            //I used the remainder operator to determine whether or not the user has
            //lived an even or odd number of years.
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
            //of money the user has in the bank.  I used an if, else if condition because
            //I am determining what range the user's birth month falls.

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
            //of their vacation home.   I used an if, else if condition here. 
            //I just as well could have used a switch statement here.

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
            //After determining the user's favorite color, I needed to determine
            //what type of transportation they have.  Also to mix things up, I used
            //the switch statement here.
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
            Console.WriteLine("_______________________________");
        }
    }        
}

