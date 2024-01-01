using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using ITEC_FINAL_CONSOLE_APP;

class Program
    {
        public static void Main()
        {
            for (; ; )
            {
                Console.Clear();
                MainMenu.writeLogo();
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
                    Console.WriteLine("Error! \nEnter valid option!");
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



        class MainMenu
        {
            public static void writeLogo()
            {
                string logo = @"   ___            _                            _       
  / _ \   _   _  (_)  ____   __ _   _ __    __| |  ___ 
 | | | | | | | | | | |_  /  / _` | | '__|  / _` | / __|
 | |_| | | |_| | | |  / /  | (_| | | |    | (_| | \__ \
  \__\_\  \__,_| |_| /___|  \__,_| |_|     \__,_| |___/
                                                       ";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(logo);
                Console.ResetColor();
            }
        }











    }


