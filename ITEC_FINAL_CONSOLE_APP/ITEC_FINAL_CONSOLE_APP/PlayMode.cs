using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using ITEC_FINAL_CONSOLE_APP;

namespace ITEC_FINAL_CONSOLE_APP
{
    class PlayMode
    {
        public static void Play()
        {
            Console.Clear();
            MainMenu1.writeLogo();
            Console.WriteLine();
            Console.WriteLine("What type of Quiz (Identification / True or False)\n");
            UserChoice("1", "Identification");
            UserChoice("2", "True Or False");
            UserChoice("3", "Back To Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string quizType = Console.ReadLine();
            Console.ResetColor();

            if (quizType.Equals("1"))
            {
                Thread.Sleep(500);
                Identification.RunIdentification();
            }
            else if (quizType.Equals("2"))
            {
                Thread.Sleep(500);
                TrueOrFalse.RunTrueOrFalse();

            }
            else if (quizType.Equals("3"))
            {
                Program.Main();
            }
            else
            {
                Console.WriteLine("Error! Enter valid option!");
                Thread.Sleep(150);
                PlayMode.Play();

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
        class MainMenu1
        {
            public static void writeLogo()
            {
                string logo = @"  ____  _               __  __           _      
 |  _ \| | __ _ _   _  |  \/  | ___   __| | ___ 
 | |_) | |/ _` | | | | | |\/| |/ _ \ / _` |/ _ \
 |  __/| | (_| | |_| | | |  | | (_) | (_| |  __/
 |_|   |_|\__,_|\__, | |_|  |_|\___/ \__,_|\___|
                |___/                           ";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(logo);
                Console.ResetColor();
            }
        }
        static void UserChoice(string choice, string label)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(choice);
            Console.ResetColor();
            Console.WriteLine("] " + label);
        }
        class Identification
        {
            public static void RunIdentification()
            {

                IdentificationSubject.Subjects();



            }

        }

        class TrueOrFalse
        {
            public static void RunTrueOrFalse()
            {

                TrueOrFalseSubject.Subjects();

            }
        }










    }
}



