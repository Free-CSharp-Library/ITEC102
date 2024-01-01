using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_FINAL_CONSOLE_APP;

namespace ITEC_FINAL_CONSOLE_APP

{
    class IdentificationSubject
    {

        public static void userChoice1(string prefix, string message)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(prefix);
            Console.ResetColor();
            Console.WriteLine("] " + message);
        }


        public static void Subjects()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Quizards!");
            userChoice1("1", "English");
            userChoice1("2", "Science");
            userChoice1("3", "Philippinne History");
            userChoice1("4", "Filipino");
            userChoice1("5", "Back");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string userSubject = Console.ReadLine();
            Console.ResetColor();

            if (userSubject == "1")
            {

                MainEnglish.EnglishSubMode();

            }
            else if (userSubject == "2")
            {
                MainScience.ScienceSubMode();

            }
            else if (userSubject == "3")
            {
                MainPh.PhSubMode();

            }
            else if (userSubject == "4")
            {
                MainFilipino.FilipinoSubMode();

            }
            else if (userSubject == "5")
            {
                PlayMode.Play();

            }
            else
            {
                Console.WriteLine("iNVALID");

            }

        }

        class MainEnglish
        {
            public static void EnglishSubMode()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");

                userChoice1("1", "Easy");
                userChoice1("2", "Average");
                userChoice1("3", "Difficult");
                userChoice1("4", "Back To Subjects");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string userLevel = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                if (userLevel == "1")
                {
                    EnglishEasy();
                }
                else if (userLevel == "2")
                {
                    EnglishAverage();
                }
                else if (userLevel == "3")
                {
                    EnglishDifficult();
                }
                else if (userLevel == "4")
                {
                    Subjects();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }


            }
            public static void EnglishEasy()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");


                string[] questions = { "What is the correct plural form of \"child\"?\n",
                                        "Find the verb in the sentence: \"She dances gracefully.\n",
                                        "Locate the adjective in the sentence: \"The little puppy is very cute.\n",
                                        "Identify the preposition in the sentence: \"The cat is on the roof.\n",
                                        "Find the pronoun in the sentence: \"He likes to read books.\n",
                                        "Identify the figure of speech in the following phrase: \"As busy as a bee.\n",
                                        "Find the figure of speech in the sentence: \"Time is a thief.\"\n",
                                        "Identify the figure of speech in the sentence: \"The stars danced in the night sky.\"\n",
                                        "Find the figure of speech in the following statement: \"I'm so hungry, I could eat a horse.\"\n",
                                        "Identify the figure of speech in the phrase: \"Sally sells seashells by the seashore.\"\n"};
                string[] answers = { "Children", "Dances", "Little", "On", "He", "Simile", "Metaphor", "Personification", "Hyperbole", "Alliteration" };



                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

            public static void EnglishAverage()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");


                string[] questions = { "Punctuation Marks to Words: .\n",
                                       "Punctuation Marks to Words: ,\n",
                                       "Punctuation Marks to Words: !\n",
                                       "Punctuation Marks to Words: ;\n",
                                       "Punctuation Marks to Words: -\n",
                                       "Which literary device involves the repetition of sounds at the beginning of words?\n",
                                       "What is a phrase that combines contradictory terms?",
                                       "What do we call a mild or polite expression in place of a harsh or blunt one?\n",
                                       "Which literary device involves using a part to represent the whole?\n",
                                       "What is a figure of speech that makes an implied comparison?"};
                string[] answers = { "Period", "Comma", "Exclamation Mark", "Semicolon", "Hyphen", "Alliteration", "Oxymoron", "Euphemism", "Synecdoche", "Metaphor" };


                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

            public static void EnglishDifficult()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");


                string[] questions = { "Provide the adverb form of the adjective \"quick.\"\n",
                                       "Correct the sentence: \"I seen that movie last night.\"\n",
                                       "Identify a literary device used to compare two unlike things without using \"like\" or \"as.\"\r\n",
                                       "Add the necessary punctuation to this sentence: \"She shouted out the answer she was so excited.\n",
                                       "Correct the spelling of the word: \"acommodate.\"\n",
                                       "Identify the type of sentence: \"Although it was raining, we decided to go for a walk.\"\n",
                                       "Correct the spelling of the word: \"exagerate.\n",
                                       "Find the verb: \"The children happily played in the park.\"\n",
                                       "Find the noun:  \"The colorful flowers bloomed in the garden.\"\n",
                                       "Find the verb: \"The team of athletes practices diligently for the upcoming tournament.\"\n"};
                string[] answers = { "Quickly",
                                     "I saw that movie last night.",
                                     "Metaphor",
                                     "She shouted out the answer; she was so excited.",
                                     "accommodate",
                                     "Complex Sentence",
                                     "exaggerate",
                                     "played",
                                     "flowers",
                                     "practices" };


                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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




        class MainScience
        {

            public static void ScienceSubMode()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");

                userChoice1("1", "Easy");
                userChoice1("2", "Average");
                userChoice1("3", "Difficult");
                userChoice1("4", "Back To Subjects");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string userLevel = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                if (userLevel == "1")
                {
                    ScienceEasy();
                }
                else if (userLevel == "2")
                {
                    ScienceAverage();
                }
                else if (userLevel == "3")
                {
                    ScienceDifficult();
                }
                else if (userLevel == "4")
                {
                    Subjects();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }


            }
            public static void ScienceEasy()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");
                string[] questions = { "What is the primary sense responsible for detecting flavors in food?\n",
                                        "What sense do you use when you listen to your favorite music?\n",
                                        "Which sense helps you enjoy the aroma of a freshly baked cake?\n",
                                        "When you pet a soft kitten, which sense are you using to feel its fur?\n",
                                        "What sense do you use to see the colors of a rainbow?\n",
                                        "In which state of matter do particles have the least amount of energy and are closely packed together?\n",
                                        "What is the term for the state of matter that has a definite volume but takes the shape of its container?\n",
                                        "In which state of matter do particles have the most energy and move freely, taking the shape and volume of their container?\n",
                                        "When a gas turns back into a liquid, what is this change of state called?\n",
                                        "What is the process by which a liquid, such as water, transforms into a gas by gaining heat energy from its surroundings?\n"};
                string[] answers = { "Taste", "Hearing", "Smell", "Touch", "Seeing", "Solid", "Liquid", "Gas", "Condensation", "Evaporation" };



                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

            public static void ScienceAverage()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");
                string[] questions = {  "What gas do plants absorb during photosynthesis?\n",
                                        "Which planet is known as the 'Red Planet'?\n",
                                        "What is the chemical symbol for water?\n",
                                        "What is the fundamental unit of life, consisting of a cell membrane, cytoplasm, and genetic material?\n",
                                        "What is the process by which plants make their own food?\n",
                                        "What is the term for the force that attracts two objects with mass towards each other?\n",
                                        "Which subatomic particle carries a negative electric charge?\n",
                                        "What is the outermost layer of the Earth's atmosphere called, where weather phenomena occur?\n",
                                        "Which famous scientist formulated the laws of motion and universal gravitation?\n",
                                        "What term is used to describe the smallest particle of an element that retains its chemical properties?\n"

                };
                string[] answers = { "Carbon Dioxide", "Mars", "H2O", "Cell", "Photosynthesis", "Gravity", "Electron", "Troposphere", "Sir Isaac Newton", "Atom" };




                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

            public static void ScienceDifficult()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");


                string[] questions = { "Subatomic particle with no charge?\n",
                                       "Study of fossils?\n",
                                       "Law stating entropy always increases?\n",
                                       "Smallest subatomic particle?\n",
                                       "Theoretical physics pioneer, \"Black Holes and Baby Universes\" author?\n",
                                       "Neurotransmitter for muscle contraction?\n",
                                       "Physics theory unifying forces?\n",
                                       "Organic compound functional group -OH?\n",
                                       "Acid found in citrus fruits?\n",
                                       "Unit of luminous intensity?\n"};
                string[] answers = { "Neutrino",
                                     "Paleontology",
                                     "Second Law.",
                                     "Quark",
                                     "Hawking",
                                     "Acetylcholine",
                                     "Grand Unified Theory",
                                     "Hydroxyl",
                                     "Citric",
                                     "Candela" };


                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

        class MainPh
        {

            public static void PhSubMode()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");

                userChoice1("1", "Easy");
                userChoice1("2", "Average");
                userChoice1("3", "Difficult");
                userChoice1("4", "Back To Subjects");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string userLevel = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                if (userLevel == "1")
                {
                    PhEasy();
                }
                else if (userLevel == "2")
                {
                    PhAverage();
                }
                else if (userLevel == "3")
                {
                    PhDifficult();
                }
                else if (userLevel == "4")
                {
                    Subjects();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }


            }
            public static void PhEasy()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");
                string[] questions = {
                                 "National hero of the Philippines?\n",
                                 "Philippine national flower?\n",
                                 "Date of Philippine Independence Day?\n",
                                 "First President of the Philippines?\n",
                                 "Site of the declaration of Philippine independence?\n",
                                 "Longest-reigning Philippine president?\n",
                                 "Iconic People Power Revolution year?\n",
                                 "Philippine national hero who led the Katipunan?\n",
                                 "Name of the indigenous people of the Cordillera region?\n",
                                 "Location of the UNESCO World Heritage site 'Rice Terraces of the Philippine Cordilleras'?\n" };

                string[] answers = {
                                    "Jose Rizal",
                                    "Sampaguita",
                                    "June 12, 1898",
                                    "Emilio Aguinaldo",
                                    "Kawit, Cavite",
                                    "Ferdinand Marcos",
                                    "1986",
                                    "Andres Bonifacio",
                                    "Igorot",
                                    "Banaue" };
                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

            public static void PhAverage()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");
                string[] questions = {
                                        "Who was the first President of the Philippines?\n",
                                        "What is the official residence of the President of the Philippines?\n",
                                        "In what year did Ferdinand Magellan arrive in the Philippines?\n",
                                        "Which Philippine president declared martial law in 1972?\n",
                                        "What event is commemorated on February 25th in the Philippines?\n",
                                        "Who is known as the 'Father of Philippine Revolution'?\n",
                                        "What is the longest river in the Philippines?\n",
                                        "What is the currency of the Philippines?\n",
                                        "Who was the first woman president of the Philippines?\n",
                                        "Which island is known as the 'Pearl of the Orient Sea'?\n" };

                string[] answers = {
                                        "Emilio Aguinaldo",
                                        "Malacañang Palace",
                                        "1521",
                                        "Ferdinand Marcos",
                                        "EDSA People Power Revolution",
                                        "Andres Bonifacio",
                                        "Cagayan River",
                                        "Philippine Peso",
                                        "Corazon Aquino",
                                        "Luzon"};
                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

            public static void PhDifficult()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");

                string[] questions = {
                                        "Who was the leader of the Magdalo faction during the Philippine Revolution?\n",
                                        "In what year did the Battle of Mactan take place?\n",
                                        "What was the name of Lapu-Lapu's weapon during the Battle of Mactan?\n",
                                        "Who served as the first Chief Justice of the Supreme Court of the Philippines?\n",
                                        "What was the pseudonym of the revolutionary intellectual Graciano Lopez Jaena?\n",
                                        "In what year did the 'Cry of Balintawak' mark the start of the Philippine Revolution?\n",
                                        "Who was the Filipino hero and revolutionary leader who was exiled to Guam by the American authorities?\n",
                                        "What was the name of the secret society founded by Andres Bonifacio that aimed to achieve Philippine independence from Spanish colonization?\n",
                                        "Which Philippine president declared Martial Law in 1972?\n",
                                        "In what year did the Philippine Congress ratify the Philippines' independence from the United States?\n"};

                string[] answers = {
                                        "Emilio Aguinaldo",
                                        "1521",
                                        "Kampilan",
                                        "Cayetano Arellano",
                                        "Diego Silang",
                                        "1896",
                                        "Apolinario Mabini",
                                        "Katipunan",
                                        "Ferdinand Marcos",
                                        "1946" };

                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

        class MainFilipino
        {

            public static void FilipinoSubMode()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");

                userChoice1("1", "Easy");
                userChoice1("2", "Average");
                userChoice1("3", "Difficult");
                userChoice1("4", "Back To Subjects");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                string userLevel = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                if (userLevel == "1")
                {
                    FilipinoEasy();
                }
                else if (userLevel == "2")
                {
                    FilipinoAverage();
                }
                else if (userLevel == "3")
                {
                    FilipinoDifficult();
                }
                else if (userLevel == "4")
                {
                    Subjects();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }


            }
            public static void FilipinoEasy()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");
                string[] questions = {
                                        "Ano ang tawag sa bahagi ng pahayagan o magasin na naglalaman ng opinyon ng mga mambabasa?\n",
                                        "Ano ang pangalan ng batang babae sa kwento ni Ibong Adarna?\n",
                                        "Saan kilala ang Bulkang Mayon?\n",
                                        "Ano ang tawag sa pangunahing tauhan sa isang kwento o nobela?\n",
                                        "Ano ang tawag sa anyo ng tula na may lalim at may sukat?\n",
                                        "Ano ang uri ng pang-abay na naglalarawan ng kilos?\n",
                                        "Sino ang nagsusulat ng mga teksto sa dula o entablado?\n",
                                        "Ano ang tawag sa pag-uugma ng tunog sa hulihan ng salita?\n",
                                        "Aling letra sa alpabeto ang wala sa wikang Filipino?\n",
                                        "Ano ang tawag sa maikling pangungusap na naglalahad ng pangyayari o ideya?\n" };

                string[] answers = {
                                        "Editoryal",
                                        "Maria Blanca",
                                        "Bicol",
                                        "Protagonista",
                                        "Balagtasan",
                                        "Pang-uri",
                                        "Dramaturgo",
                                        "Rhyme",
                                        "X",
                                        "Paksa"};




                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

            public static void FilipinoAverage()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");
                string[] questions = {
                                        "Ano ang tawag sa uri ng pang-uring naglalarawan ng damdamin o emosyon?\n",
                                        "Sino ang tanyag na makata na kilala sa paggamit ng tula bilang protesta?\n",
                                        "Ano ang wika ng epikong 'Hinilawod'?\n",
                                        "Ano ang tawag sa pagsasanib-pwersa ng mga salita na nagtataglay ng parehong tunog?\n",
                                        "Saan isinilang si Francisco Balagtas?\n",
                                        "Ano ang tawag sa pagbibigay ng buhay o katangian sa mga bagay na hindi tao?\n",
                                        "Sino ang may-akda ng 'Noli Me Tangere'?\n",
                                        "Ano ang wika ng epikong 'Ibalon'?\n",
                                        "Ano ang tawag sa paggamit ng mga salitang may parehong tunog ngunit magkaibang kahulugan?\n",
                                        "Saan isinagawa ang unang pagtatanghal ng 'Florante at Laura' ni Balagtas?\n" };

                string[] answers = {
                                        "Pang-uring Pamilang",
                                        "Lourd de Veyra",
                                        "Hiligaynon",
                                        "Aliterasyon",
                                        "Bigaa, Bulacan",
                                        "Personipikasyon",
                                        "Jose Rizal",
                                        "Bikol",
                                        "Kasindak-sindak",
                                        "Casa Real, Binondo" };

                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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

            public static void FilipinoDifficult()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Quizards!");


                string[] questions = {
                                        "Ano ang tawag sa sining ng paghahabi ng tela?\n",
                                        "Sino ang makata ng tanyag na 'Pag-ibig sa Tinubuang Lupa'?\n",
                                        "Ano ang wika ng epikong 'Kudaman'?\n",
                                        "Ano ang tawag sa paggamit ng pang-uring naglalarawan na may pag-uyam o pambabatikos?\n",
                                        "Sino ang may-akda ng 'El Filibusterismo'?\n",
                                        "Ano ang wika ng epikong 'Labaw Donggon'?\n",
                                        "Ano ang tawag sa anyo ng tula na may limang taludtod at 12 pantig bawat taludtod?\n",
                                        "Sino ang tinaguriang 'Hari ng Balagtasan'?\n",
                                        "Ano ang wika ng epikong 'Maragtas'?\n",
                                        "Ano ang tawag sa pagtatanghal ng mga tauhan na nagpapakita ng nangyari sa kanilang sariling pagkatao?\n" };

                string[] answers = {
                                        "Paghabi",
                                        "Andres Bonifacio",
                                        "Kinaray-a",
                                        "Satiriko",
                                        "Jose Rizal",
                                        "Hiligaynon",
                                        "Dalit",
                                        "Jose Corazon de Jesus",
                                        "Kinaray-a",
                                        "Monologo" };

                int numberofQuestions = questions.Length;

                string userChoiceTry;
                List<TimeSpan> leaderboard = new List<TimeSpan>();


                do
                {
                    Console.WriteLine("Do you want to take the quiz?");
                    userChoice1("1", "YES");
                    userChoice1("2", "Back To Subjects");
                    userChoice1("3", "Back To Main Menu");
                    userChoice1("4", "Exit");
                    userChoiceTry = Console.ReadLine();

                    if (userChoiceTry == "1")
                    {
                        Random random = new Random();
                        for (int i = numberofQuestions - 1; i > 0; i--)
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

                        int score = 0;

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        for (int i = 0; i < numberofQuestions; i++)
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
                        Console.WriteLine($"Quiz completed. Your score: {score} out of {numberofQuestions}");
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
                        Subjects();
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











        class MainMenu1
        {
            public static void writeLogo()
            {
                string logo = @"  ______                     _____                           _ 
 |  ____|                   |  __ \                         | |
 | |__    __ _  ___  _   _  | |__) | ___   _   _  _ __    __| |
 |  __|  / _` |/ __|| | | | |  _  / / _ \ | | | || '_ \  / _` |
 | |____| (_| |\__ \| |_| | | | \ \| (_) || |_| || | | || (_| |
 |______|\__,_||___/ \__, | |_|  \_\\___/  \__,_||_| |_| \__,_|
                      __/ |                                    
                     |___/                                     ";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(logo);
                Console.ResetColor();
            }

            public static void averageRound()
            {
                string logo = @"                                                _____                           _ 
     /\                                        |  __ \                         | |
    /  \ __   __ ___  _ __  __ _   __ _   ___  | |__) | ___   _   _  _ __    __| |
   / /\ \\ \ / // _ \| '__|/ _` | / _` | / _ \ |  _  / / _ \ | | | || '_ \  / _` |
  / ____ \\ V /|  __/| |  | (_| || (_| ||  __/ | | \ \| (_) || |_| || | | || (_| |
 /_/    \_\\_/  \___||_|   \__,_| \__, | \___| |_|  \_\\___/  \__,_||_| |_| \__,_|
                                   __/ |                                          
                                  |___/                                           ";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(logo);
                Console.ResetColor();
            }
            public static void difficultRound()
            {
                string logo = @"  _____   _   __   __  _               _  _     _____                           _ 
 |  __ \ (_) / _| / _|(_)             | || |   |  __ \                         | |
 | |  | | _ | |_ | |_  _   ___  _   _ | || |_  | |__) | ___   _   _  _ __    __| |
 | |  | || ||  _||  _|| | / __|| | | || || __| |  _  / / _ \ | | | || '_ \  / _` |
 | |__| || || |  | |  | || (__ | |_| || || |_  | | \ \| (_) || |_| || | | || (_| |
 |_____/ |_||_|  |_|  |_| \___| \__,_||_| \__| |_|  \_\\___/  \__,_||_| |_| \__,_|
                                                                                  
                                                                                  ";
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(logo);
                Console.ResetColor();
            }


        }




    }
}

