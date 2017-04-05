using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Multiplication
    {
        public void MultiplicationTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @"___    __                ___                    
 /'\_/`\         /\_ \  /\ \__  __        /\_ \                   
/\      \  __  __\//\ \ \ \ ,_\/\_\  _____\//\ \      __    ____  
\ \ \__\ \/\ \/\ \ \ \ \ \ \ \/\/\ \/\ '__`\\ \ \   /'__`\ /',__\ 
 \ \ \_/\ \ \ \_\ \ \_\ \_\ \ \_\ \ \ \ \L\ \\_\ \_/\  __//\__, `\
  \ \_\\ \_\ \____/ /\____\\ \__\\ \_\ \ ,__//\____\ \____\/\____/
   \/_/ \/_/\/___/  \/____/ \/__/ \/_/\ \ \/ \/____/\/____/\/___/ 
                                       \ \_\                      
                                        \/_/                      ";
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 - 10.");
            Console.WriteLine("Next you will see the numbers between these selections be added.");
            Console.WriteLine("to numbers 1-10");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number between 1 - 10");
        }

        public void MultiplicationTable(int startNum, int endNum)
        {
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                {
                    Console.Write(String.Format("{0, 6}", "n")); //{0, 6} is the spacing; 6 spaces
                }
                else
                {
                    Console.Write(String.Format("{0, 6}", i));
                }
            }

            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(String.Format("{0, 6}", i));
                for (int b = startNum; b < endNum; b++)
                {
                    string output = String.Format("{0, 6}", i * b);
                    Console.Write(output);
                }
                Console.WriteLine("");
            }



        }
    }
}