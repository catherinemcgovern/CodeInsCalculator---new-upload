using System;


namespace InsuranceCalculator
{
    class Program
    {

        static void Main()
        {
            byte choice;
            bool validChoice;

            //first we have the user select if they want to get and insurance quote or quit

            do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {
                Console.Write("-----------------------------------------");
                validChoice = true;
                Console.Write("\nPlease make a selection: ");
                Console.Write("\n Type 1 get a quote for insurance ");
                Console.WriteLine("\n Type 2 to quit");

                try
                {
                    choice = Convert.ToByte(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: // User opts to create a nickname and the method is started to begin that process
                            GetInsurance();
                            break;
                        case 2: // User decides they want to quit
                            QuitQuote();
                            break;
                        default:
                            validChoice = false;
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    // This try...catch block catches the FormatException that Convert.ToInt32 will throw 
                    // if the user inputs text or something that cannot be converted to an integer.
                    validChoice = false;
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (validChoice == false); // Inner loop ends when validChoice is true
        }


        static void QuitQuote()
        {
            //This method ends the game
            Console.WriteLine("Quitting...");
        }


        static void GetInsurance()
        {


            byte gender = 0;
            int cScore = 0;
            int age;


            int InsurancePremium = 500; //this is the base rate 

            Console.WriteLine("Please enter your gender?");
            Console.WriteLine("Please enter 1 for male?");
            Console.WriteLine("Please enter 2 for female?");


            // Let's validate the input for gender using a boolean try/catch with a switch case


            bool genderValidChoice;

            do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {
                genderValidChoice = true;


                try
                {
                    gender = Convert.ToByte(Console.ReadLine());
                    switch (gender)
                    {
                        case 1: // user is male and this input is valid
                            break;
                        case 2: //  user is female and this input is valid
                            break;
                        default:
                            genderValidChoice = false;
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    // This try...catch block catches the FormatException that Convert.ToInt32 will throw 
                    // if the user inputs text or something that cannot be converted to an integer.
                    genderValidChoice = false;
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (genderValidChoice == false);


            if (gender == 1)
            {
                InsurancePremium += 50;
                // Trace Comment - Console.WriteLine($"The user is mail and his Premium is now {InsurancePremium}"); //trace comment
            }


            Console.Write("What is your age? ");

            // Let's validate the input for Age using boolean try/catch with if then statements

            bool ageValidChoice;
            int validAge = 0;


            do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {
                ageValidChoice = true;
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    {
                        if (age > 135 || age < 0)
                        {
                            ageValidChoice = false;
                            Console.WriteLine("Invalid choice. Please try again.");
                        }
                        else
                        {
                            validAge = age;
                        }

                    }
                }
                catch (FormatException)
                {
                    // This try...catch block catches the FormatException that Convert.ToInt32 will throw 
                    // if the user inputs text or something that cannot be converted to an integer.
                    ageValidChoice = false;
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (ageValidChoice == false);


            //Console.WriteLine("Yay you entered a valid age amount which is {0}", validAge); - Trace comment


            if (validAge <= 24 && gender == 1)
            {
                InsurancePremium += 250;
                //Console.WriteLine($"The user is mail and under 24 and her Premium is now {InsurancePremium} becuase the person is younger than 24"); //trace comment
            }

            else if (validAge <= 24)
            {
                InsurancePremium += 100;
                //Console.WriteLine($"The user is female and under 24 his Premium is now {InsurancePremium} becuase the person is younger than 24"); //trace comment
            }

            else if (validAge > 24 && validAge <= 30)
            {
                InsurancePremium += 50;
               // Console.WriteLine($"The user is mail and his Premium is now {InsurancePremium}"); //trace comment
            }

            else if (validAge > 65 && validAge < 85)
            {
                InsurancePremium += 100;
                //Console.WriteLine($"The user over the age of 65 Premium is now {InsurancePremium}"); //trace comment
            }

            else if (validAge >= 85 && validAge <= 135)
            {
                InsurancePremium += 250;
                //Console.WriteLine($"The user over the age of 85 Premium is now {InsurancePremium}"); //trace comment
            }

            //Now we do credit score



            Console.Write("What is your Credit Score? ");

            // Let's validate the input for Age using boolean try/catch with if then statements

            bool cScoreValidChoice;
            int validcScore = 0;

            // Let's validate the input for Credit Score
            do // inner do...while loop is to keep looping until the user picks a valid menu selection
            {
                cScoreValidChoice = true;
                try
                {
                    cScore = Convert.ToInt32(Console.ReadLine());
                    {
                        if (cScore >= 850 || cScore < 300)
                        {
                            cScoreValidChoice = false;
                            Console.WriteLine("Invalid choice. Please try again.");
                        }
                        else
                        {
                            validcScore = cScore;
                        }

                    }
                }
                catch (FormatException)
                {
                    // This try...catch block catches the FormatException that Convert.ToInt32 will throw 
                    // if the user inputs text or something that cannot be converted to an integer.
                    cScoreValidChoice = false;
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (cScoreValidChoice == false);

            // Trace Comment - Console.WriteLine("Yay you entered a valid creditScore number which is {0}", validcScore);




            //now we will perform calculations on the insurance premium based on the credit score
            //  if credit score is <500, increase total by $200, if 500<x<600, increase by $50
            if (validcScore <= 500)
            {
                InsurancePremium += 200;
                // Trace Comment - Console.WriteLine($"The user has a credit score below 500 and so his insurance premium is {InsurancePremium} dollars"); //trace comment
            }

            else if (validcScore > 500 && validcScore <= 600)
            {
                InsurancePremium += 500;
                // Trace Comment - Console.WriteLine($"The user has a credit scor above 500, but below or equal to 600 and so his insurance premium is {InsurancePremium} dollars"); //trace comment
            }

            Console.WriteLine($"Final insurance premium is {InsurancePremium:c}"); //trace comment

            Main();
        }

    }
}


