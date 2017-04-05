using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Math Facts App";
            int choice = 0;
            Addition addTable = new Addition();
            Multiplication timesTable = new Multiplication();
            do
            {
                MainAppTitle();
                Console.WriteLine();
                choice = MainMenu();

                if (choice == 1)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;

                    do
                    {
                        addTable.AdditionTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number: ");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number: ");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                            
                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                addTable.AdditionTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Your addition Table for {0} - {1}:", startNum, endNum);
                                Console.WriteLine("");
                                addTable.AdditionTable(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Would you like more addition facts? [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                            }
                            Console.ReadLine();
                            continueChoice = false;
                        }
                    } while (continueChoice == true);
                }

                if (choice == 2)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        timesTable.MultiplicationTitle();
                        try
                        {
                            Console.WriteLine("Enter your starting number:");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number:");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid number.");
                            Console.ReadLine();
                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                timesTable.MultiplicationTitle();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Your multiplication Table for {0} - {1}:", startNum, endNum);
                                Console.WriteLine("");
                                timesTable.MultiplicationTable(startNum, endNum);

                                Console.WriteLine("");

                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Would you like more multiplication facts? [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }

                            }
                        }
                    } while (continueChoice == true);
                }



            } while (choice != 3);
        }

        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select an option");
            Console.WriteLine("-----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: Addition Facts");
            Console.WriteLine("Option 2: Multiplication Facts");
            Console.WriteLine("Option 3: Leave Math Facts");
            choice = Int32.Parse(Console.ReadLine()); 
            return choice;
        }

        private static void MainAppTitle()
        {
            Console.Clear();
            string appTitle = @"
                   __    __          ____                 __             
 /'\_/`\          /\ \__/\ \        /\  _`\              /\ \__          
/\      \     __  \ \ ,_\ \ \___    \ \ \L\_\ __      ___\ \ ,_\   ____  
\ \ \__\ \  /'__`\ \ \ \/\ \  _ `\   \ \  _\/'__`\   /'___\ \ \/  /',__\ 
 \ \ \_/\ \/\ \L\.\_\ \ \_\ \ \ \ \   \ \ \/\ \L\.\_/\ \__/\ \ \_/\__, `\
  \ \_\\ \_\ \__/.\_\\ \__\\ \_\ \_\   \ \_\ \__/.\_\ \____\\ \__\/\____/
   \/_/ \/_/\/__/\/_/ \/__/ \/_/\/_/    \/_/\/__/\/_/\/____/ \/__/\/___/ 
                                                                         ";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
