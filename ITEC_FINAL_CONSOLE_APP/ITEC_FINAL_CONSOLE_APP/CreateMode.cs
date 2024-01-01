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
    class CreateMode
    {
        public static void userChoice2(string prefix, string message)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(prefix);
            Console.ResetColor();
            Console.WriteLine("] " + message);
        }
        public static void Create()
        {
            Console.Clear();
            MainMenu2.writeLogo();
            Console.WriteLine();
            Console.WriteLine("What type of Quiz (Identification / True or False)\n");
            userChoice2("1", "Identification");
            userChoice2("2", "True Or False");
            userChoice2("3", "Back To Main Menu");
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
                TrueorFale.RunTrueOrFalse();
            }
            else if (quizType.Equals("3"))
            {
                Program.Main();
            }
            else
            {
                Console.WriteLine("Error! Enter valid option!");
                Thread.Sleep(150);
                CreateMode.Create();

            }
        }

        class MainMenu2
        {
            public static void writeLogo()
            {
                string logo = @"   ____                         _              __  __               _        
  / ___|  _ __    ___    __ _  | |_    ___    |  \/  |   ___     __| |   ___ 
 | |     | '__|  / _ \  / _` | | __|  / _ \   | |\/| |  / _ \   / _` |  / _ \
 | |___  | |    |  __/ | (_| | | |_  |  __/   | |  | | | (_) | | (_| | |  __/
  \____| |_|     \___|  \__,_|  \__|  \___|   |_|  |_|  \___/   \__,_|  \___|
                                                                             ";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(logo);
                Console.ResetColor();
            }
        }
        class Identification
        {
            public static void RunIdentification()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Welcome to the Quiz Game!\n");
                Console.ResetColor();

                // Get the number of questions from the user
                Console.Write("Enter the number of questions: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                int numberOfQuestions = int.Parse(Console.ReadLine());
                Console.ResetColor();

                // Initialize arrays to store questions and answers
                string[] questions = new string[numberOfQuestions];
                string[] answers = new string[numberOfQuestions];

                // Populate the arrays with user input
                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.Write($"Enter question #{i + 1}: ");
                    questions[i] = Console.ReadLine();

                    Console.Write($"Enter the answer for question #{i + 1}: ");
                    answers[i] = Console.ReadLine();
                }
                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();
                do
                {
                    Console.WriteLine("\nDo you want to take the quiz?");
                    userChoice2("1", "YES");
                    userChoice2("2", "Back");
                    userChoice2("3", "Back To Main Menu");
                    userChoice2("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberOfQuestions - 1; i > 0; i--)
                        {
                            int j = random.Next(0, i + 1);
                            // Swap questions and answers
                            string tempQuestion = questions[i];
                            questions[i] = questions[j];
                            questions[j] = tempQuestion;

                            string tempAnswer = answers[i];
                            answers[i] = answers[j];
                            answers[j] = tempAnswer;
                        }

                        Console.WriteLine("\nQuiz created successfully! Let's start the quiz.\n");
                        Console.Clear();

                        // Initialize score
                        int score = 0;
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        // Display shuffled questions and check answers
                        for (int i = 0; i < numberOfQuestions; i++)
                        {
                            Console.WriteLine($"Question #{i + 1}: {questions[i]}");
                            Console.Write("Your answer: ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            string userAnswer = Console.ReadLine();
                            Console.ResetColor();
                            // Check the answer
                            if (userAnswer.Equals(answers[i], StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Correct!\n");
                                score++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Incorrect! ");
                                Console.ResetColor();
                                Console.Write("The correct answer is: ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(answers[i] + "\n");
                                Console.ResetColor();
                            }
                        }
                        stopwatch.Stop();

                        TimeSpan elapsed = stopwatch.Elapsed;
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberOfQuestions}");

                        Console.WriteLine($"Time spent on this completion: {elapsed.TotalSeconds} seconds");
                        leaderboard.Add(elapsed);


                        Console.WriteLine("\nLeaderboard:");
                        for (int i = 0; i < leaderboard.Count; i++)
                        {
                            Console.WriteLine($"Attempt #{i + 1}: {leaderboard[i].TotalSeconds} seconds\n");

                        }


                    }
                    else if (userChoiceTry == "2")
                    {
                        Create();
                    }
                    else if (userChoiceTry == "3")
                    {
                        Program.Main();
                    }
                    else if (userChoiceTry == "4")
                    {
                        Console.WriteLine("EXISTING");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("iNVALID");
                    }
                } while (userChoiceTry != "4");
            }
        }

        class TrueorFale
        {
            public static void RunTrueOrFalse()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quiz Game!");

                // Get the number of questions from the user
                Console.Write("Enter the number of questions: ");
                int numberOfQuestions = Convert.ToInt32(Console.ReadLine());

                string[] questions = new string[numberOfQuestions];
                bool[] answers = new bool[numberOfQuestions];

                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.Write($"Enter true/false question #{i + 1}: ");
                    questions[i] = Console.ReadLine();

                    Console.Write($"Enter the correct answer (true/false) for question #{i + 1}: ");
                    try
                    {
                        answers[i] = Convert.ToBoolean(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter true or false.\n");
                        i--;
                        continue;
                    }
                }

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();
                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice2("1", "YES");
                    userChoice2("2", "Back");
                    userChoice2("3", "Back To Main Menu");
                    userChoice2("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberOfQuestions - 1; i > 0; i--)
                        {
                            int j = random.Next(0, i + 1);

                            string tempQuestions = questions[i];
                            questions[i] = questions[j];
                            questions[j] = tempQuestions;

                            bool tempAnswer = answers[i];
                            answers[i] = answers[j];
                            answers[j] = tempAnswer;
                        }

                        Console.WriteLine("\nQuiz created successfully! Let's start the quiz.\n");
                        Console.Clear();
                        int score = 0;
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberOfQuestions; i++)
                        {
                            Console.WriteLine($"Question #{i + 1}: {questions[i]}");
                            Console.Write("Your answer (True/False): ");

                            // Set user input color to yellow
                            Console.ForegroundColor = ConsoleColor.DarkYellow;

                            bool userAnswer;
                            try
                            {
                                userAnswer = Convert.ToBoolean(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter true or false.\n");
                                i--;
                                continue;
                            }
                            finally
                            {
                                Console.ResetColor();
                            }

                            if (userAnswer == answers[i])
                            {
                                Console.WriteLine("Correct\n");
                                score++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Incorrect ");
                                Console.ResetColor();
                                Console.Write("The correct answer is: ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(answers[i] + "\n");
                                Console.ResetColor();
                            }
                        }
                        stopwatch.Stop();

                        TimeSpan elapsed = stopwatch.Elapsed;
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberOfQuestions}");

                        Console.WriteLine($"Time spent on this completion: {elapsed.TotalSeconds} seconds");
                        leaderboard.Add(elapsed);


                        Console.WriteLine("\nLeaderboard:");
                        for (int i = 0; i < leaderboard.Count; i++)
                        {
                            Console.WriteLine($"Attempt #{i + 1}: {leaderboard[i].TotalSeconds} seconds");
                        }


                    }
                    else if (userChoiceTry == "2")
                    {
                        Create();
                    }
                    else if (userChoiceTry == "3")
                    {
                        Program.Main();
                    }
                    else if (userChoiceTry == "4")
                    {
                        Console.WriteLine("EXISTING");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("iNVALID");
                    }
                } while (userChoiceTry != "4");
            }
        }
    }
}
