using System;

namespace Bank_Project
{
    internal class Program
    {
        static void Main()
        {
            //Display Title
            Console.WriteLine("************* Z Bank *************");
            Console.WriteLine();
            Console.WriteLine("::lOGIN  PAGE::");

            //Declare variables to store username and password
            string userName, password = null;

            //Read userNmae from keyboard
            Console.WriteLine("Username: ");
            userName = Console.ReadLine();

            //Read password from keyboard
            if(userName != "")
            {
                Console.WriteLine("Password: ");
                password = Console.ReadLine();
            }
            //Cheack userName and password
            if (userName == "system" && password == "manager") 
            {
                int mainMenuChoise;

                do
                {
                    Console.WriteLine("\n:::::::::::::: Main menu :::::::::::::: ");
                    Console.WriteLine(); 
                    Console.WriteLine("1. Costomer ");
                    Console.WriteLine("2. Account ");
                    Console.WriteLine("3. Funds Transfer ");
                    Console.WriteLine("4. Funds Transfer Statement ");
                    Console.WriteLine("5. Account Statement ");
                    Console.WriteLine("0. Exit ");

                    Console.WriteLine();
                    Console.Write("Enter your choise: ");
                    mainMenuChoise = int.Parse(Console.ReadLine());

                    //switch case to check the menu

                    switch (mainMenuChoise)
                    {
                        case 1: CostomersMenu();
                            break;
                        case 2: AccountsMenu();
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;

                    }
                }while(mainMenuChoise != 0);
                
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please, try again.");
            }

            //Exit
            Console.WriteLine("Tank you! Visit again.");
            Console.ReadKey();
        
        }

         static void CostomersMenu()
        {
            int costomersMenuChoise;

            do
            {
                Console.WriteLine();
                Console.WriteLine("\n::: Contomer Menu :::");
                Console.WriteLine();

                Console.WriteLine("1. Add Costomer ");
                Console.WriteLine("2. Delete Costomer ");
                Console.WriteLine("3. View Costomers ");
                Console.WriteLine("0. Back to Main Menu ");

                Console.Write("Enter choise: ");
                costomersMenuChoise = Convert.ToInt32(Console.ReadLine());

            }while(costomersMenuChoise != 0);
        }

        static void AccountsMenu()
        {
            int accountsMenuChoise;

            do
            {
                Console.WriteLine();
                Console.WriteLine("\n::: Accounts Menu :::");
                Console.WriteLine();

                Console.WriteLine("1. Add Account ");
                Console.WriteLine("2. Delete Account ");
                Console.WriteLine("3. View Accounts ");
                Console.WriteLine("0. Back to Main Menu ");

                Console.Write("Enter choise: ");
                accountsMenuChoise = Convert.ToInt32(Console.ReadLine());

            } while (accountsMenuChoise != 0);
        }
    }
}
