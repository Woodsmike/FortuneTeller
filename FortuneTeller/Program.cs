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

            
            //for all the user inputs, except for age and birth month, I changed the string
            //variable to one that is in all lowercase letters.  This is so the user's input
            //will not be case sensitive throughout the application.
            Console.WriteLine("To begin, What is your first name?");
            string firstName = Console.ReadLine();
            string lowerCaseFirstName = firstName.ToLower();

            //I used the following if statement at every location where the user has the 
            //opportunity to type in a value.  I also created a new method named "Quitter"
            //The new method prints the message "Nobody likes a quitter..."  And then 
            //exits the program.
            if(lowerCaseFirstName == "quit")
            {
                Quitter();
            }

            Console.WriteLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            string lowerCaseLastName = lastName.ToLower();

            if (lowerCaseLastName == "quit")
            {
                Quitter();
            }

            Console.WriteLine();
            Console.WriteLine("What is your age? Ladies, your age will not be disclosed.");
            string userAgeString = Console.ReadLine();
            string lowerCaseUserAge = userAgeString.ToLower();

            if (lowerCaseUserAge == "quit")
            {
                Quitter();
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
            string lowerCaseUserBirthMonth = userBirthMonthString.ToLower();

            if (lowerCaseUserBirthMonth == "quit")
            {
                Quitter();
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

                if (userBirthMonth < 0)
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
                Quitter();
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
                    Quitter();
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
                        Quitter();
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
                        Quitter();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("How many siblings do you have?");
            string userSiblingsString = Console.ReadLine();

            if (userSiblingsString == "quit")
            {
                Quitter();
            }
            
            int userSiblings;
            userSiblings = Convert.ToInt32(userSiblingsString);

            Console.WriteLine();
            Console.WriteLine("Thank you for making the right choice in utilizing my " +
                "exquisite talents to determine your future!\n\n" +
                "I will tell your fortune momentarily. \n\n\n");

            //The second section is where I take the users information and determine
            //the fortunes of the user in multiple areas of their life.

            
            //If the users age is even they will retire in 20 years if odd then 30 years.
            //I used the remainder operator to determine whether or not the user has
            //lived an even or odd number of years.
            
            if (userAge % 2 == 0)
            {
                userAgeString = "20 years";
            }
            else
            {
                userAgeString = "30 years";
            }

            //This part is to use the user's birth month to determine the amount
            //of money the user has in the bank.  I used an if, else if condition because
            //I am determining what range the user's birth month falls.
            string amountOfMoney;
            if (userBirthMonth >= 1 && userBirthMonth <= 4)
            {
                amountOfMoney = "$1,875,043.10";
            }
            else if (userBirthMonth > 4 && userBirthMonth <= 8)
            {
                amountOfMoney = "$1,293,485.67";
            }
            else if (userBirthMonth > 8 && userBirthMonth <= 12)
            {
                amountOfMoney = "$.32";
            }
            else
            {
                amountOfMoney = "$0";
            }
            //The number of the user's siblings will determine the location
            //of their vacation home.   I used an if, else if condition here. 
            //I just as well could have used a switch statement here.
            string vacationLocation;     
            if (userSiblings == 0)
            {
                vacationLocation = "Kauai, Hawaii ";
            }
            else if (userSiblings == 1)
            {
                vacationLocation = "fabulous Viti Levu, Fiji";
            }
            else if (userSiblings == 2)
            {
                vacationLocation = "terrific Toronto, Canada ";
            }
            else if (userSiblings == 3)
            {
                vacationLocation = "lovely Los Cabos, Mexico ";
            }
            else if(userSiblings > 3)
            {
                vacationLocation = "a foreign Insane Asylum ";
            }
            else
            {
                vacationLocation = "a 74' Princess 72 yacht ";
            }

            //The color selected will determine the user's transportation
            //After determining the user's favorite color, I needed to determine
            //what type of transportation they have.  Also to mix things up, I used
            //the switch statement here.
            string transportation;
            switch (lowerCaseUserFavColor)
            {
                case "red":
                    transportation = "sports car.";
                    break;
                case "orange":
                    transportation = "skateboard.";
                    break;
                case "yellow":
                    transportation = "banana seat bike.";
                    break;
                case "green":
                    transportation = "Honda Prius.";
                    break;
                case "blue":
                    transportation = "Learjet 60 airplane.";
                    break;
                case "indigo":
                    transportation = "helicopter.";
                    break;
                case "violet":
                    transportation = "Mini Cooper.";
                    break;
                default:
                    transportation = "and you do not have any transportation.";
                    break;
            }
            Console.WriteLine();
           
            //for part 3, I printed the below line by using the variables defined above.
            Console.WriteLine(firstName + " " + lastName + " will retire in " + userAgeString +
            " with " + amountOfMoney + " in the bank, a vacation home in " + vacationLocation +
            "and a " + transportation );
            Console.WriteLine("_______________________________");

            //for an extra, I created a new method to put inside the if statements for 
            //printing 'nobody likes a quitter..." and exiting the program
        }
        public static void Quitter()
        {
            Console.WriteLine("Nobody likes a quitter...");
            Environment.Exit(0);
            return;
        }
    }
}

