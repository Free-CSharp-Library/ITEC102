using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_FINAL_CONSOLE_APP;

namespace ITEC_FINAL_CONSOLE_APP
{
    class HowToPlayMode
    {
        public static void HowToPlayStart()
        {
            for (; ; )
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Welcome to Quizards App!");
                Console.WriteLine();
                Console.WriteLine("1. This app allows you to answer questions, create your own quiz, and receive a score.");
                Console.WriteLine("2. This app will help you for reviewing.");
                Console.WriteLine("3. Always click the enter key after clicking your chosen mode or answers.");
                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("In the default mode, there are numbers that you can choose on what you want for this quiz app.");
                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1. Play Mode");
                Console.ResetColor();
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("you can only enter your answers in this mode.");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("2. Create Mode");
                Console.ResetColor();
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("you can create your own quiz by this mode..");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("3. How To Play");
                Console.ResetColor();
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("this will serve as your guide if you are confused on how to use this app.");
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("4. Quit");
                Console.ResetColor();
                Console.Write(" - ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("click this if you like to exit this app.");
                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Play Mode");
                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Click number 1 for identification and number 2 for true or false");
                Console.WriteLine("2. Choose a subject that you want to answer.");
                Console.WriteLine("3. Choose your preferred difficulty.");
                Console.WriteLine("4. Answer the following questions.");
                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Create mode");
                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Choose what type of quiz you want.");
                Console.WriteLine("2. Enter the number of questions you want to answer.");
                Console.WriteLine("3. Type your questions and answer key.");
                Console.WriteLine("4. Click yes to proceed.");
                Console.WriteLine("5. Click back to change the type of quiz.");
                Console.WriteLine("6. Click back to main menu if you change your mind.");
                Console.WriteLine("7. Click exit if you want to close the app.");
                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3.1: Read and understand the following instructions.");
                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("4.1: Enter number 4 to exit the app.");

                Console.WriteLine();

                userChoice("1", "Play Mode");
                userChoice("2", "Create Mode");
                userChoice("3", "How To Play");
                userChoice("4", "Quit");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    PlayMode.Play();
                }
                else if (option == "2")
                {
                    CreateMode.Create();
                    Console.Clear();
                }
                else if (option == "3")
                {
                    HowToPlayMode.HowToPlayStart();
                }
                else if (option == "4")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! \nEnter valid option!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
            }
        }

        public static void userChoice(string prefix, string message)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(prefix);
            Console.ResetColor();
            Console.WriteLine("] " + message);
        }
    }
}
