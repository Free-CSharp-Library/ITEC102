using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_FINAL_CONSOLE_APP;

namespace ITEC_FINAL_CONSOLE_APP
{
    class TrueOrFalseSubject
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
                                        "Jane Austen is the author of '1984.'\n",
                                        "Charles Dickens wrote 'Pride and Prejudice.'\n",
                                        "Agatha Christie created the character Sherlock Holmes.\n",
                                        "George Orwell's 'Animal Farm' is a dystopian novel.\n",
                                        "Metaphor involves the repetition of sounds.\n",
                                        "Shakespeare's play 'Romeo and Juliet' is a tragedy.\n",
                                        "Jane Austen's 'Pride and Prejudice' is set in the 19th century.\n",
                                        "Charles Dickens wrote 'A Christmas Carol.'\n",
                                        "Agatha Christie's 'Murder on the Orient Express' features Hercule Poirot.\n",
                                        "George Orwell's '1984' is a novel about a dystopian society.\n"};

                bool[] answers = { false, false, false, false, false, false, true, true, true, true };
                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
    "Alliteration involves the repetition of vowel sounds.\n",
    "Oxymoron is a figure of speech that makes an implied comparison.\n",
    "Euphemism uses harsh or blunt expressions instead of mild ones.\n",
    "Synecdoche involves using a part to represent the whole.\n",
    "Metaphor involves a direct comparison between two unrelated things.\n",
    "'To Kill a Mockingbird' features Atticus Finch as a lawyer defending Tom Robinson.\n",
    "'Pride and Prejudice' is a novel written by Jane Austen.\n",
    "George Orwell's 'Animal Farm' serves as an allegory of the Russian Revolution.\n",
    "J.K. Rowling is renowned as the author of the 'Harry Potter' series.\n",
    "The term 'stream of consciousness' is connected to Virginia Woolf's writing.\n",
    "'The Catcher in the Rye' is a novel written by Harper Lee.\n",
    "F. Scott Fitzgerald wrote 'The Great Gatsby' during the Roaring Twenties.\n",
    "In '1984,' the government is led by a figure known as Big Brother.\n",
    "Ray Bradbury's 'Fahrenheit 451' envisions a dystopian future without books.\n",
    "Herman Melville authored 'Moby-Dick,' a novel about Captain Ahab and a white whale.\n"
};

                bool[] answers = {
    false,
    false,
    false,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    false,
    true,
    true,
    true,
    true
};

                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
    "Virginia Woolf's 'Mrs Dalloway' takes place in a single day.\n",
    "Gabriel Garcia Marquez's 'One Hundred Years of Solitude' is considered a work of magical realism.\n",
    "T.S. Eliot's poem 'The Waste Land' is known for its fragmented structure and allusions.\n",
    "Dante Alighieri's 'Inferno' is the first part of his epic poem 'The Divine Comedy'.\n",
    "Kurt Vonnegut's 'Slaughterhouse-Five' explores the concept of time as experienced by its protagonist.\n",
    "Zora Neale Hurston's 'Their Eyes Were Watching God' is a novel set in the American South.\n",
    "The term 'postmodernism' is often associated with authors like Italo Calvino and Thomas Pynchon.\n",
    "'Brave New World' by Aldous Huxley depicts a dystopian future where people are controlled through pleasure.\n",
    "Salman Rushdie's 'Midnight's Children' explores the events surrounding India's independence.\n",
    "The literary term 'bildungsroman' refers to a novel that focuses on the moral and psychological growth of its protagonist.\n",
    "Wole Soyinka, a Nigerian playwright, was the first African to be awarded the Nobel Prize in Literature.\n",
    "Clarice Lispector, a Brazilian novelist, is known for her experimental and introspective writing.\n",
    "The 'Lost Generation' is a term used to describe American writers who lived through World War I and explored its disillusionment.\n",
    "Jean-Paul Sartre's philosophical novel 'Nausea' delves into existentialist themes.\n",
    "Edgar Allan Poe's 'The Masque of the Red Death' is an allegorical tale about the inevitability of death.\n"
};

                bool[] answers = {
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
};


                int numberOfQuestions = questions.Length;
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
                    // EnglishDifficult();
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
                                      "Gravity pulls things upward.\n",
                                      "Water boils at a temperature of 50 degrees Celsius.\n",
                                      "Oxygen is not essential for human survival.\n",
                                      "Plants perform photosynthesis at night.\n",
                                      "Sound travels faster in a vacuum than in air.\n",
                                      "Photosynthesis is the process by which plants make their own food.\n",
                                      "The chemical symbol for gold is Au.\n",
                                      "Pluto is considered a dwarf planet.\n",
                                      "Matter can exist in four states: solid, liquid, gas, and plasma.\n",
                                      "A force called gravity keeps planets in orbit around the sun.\n" };

                bool[] answers = { false, false, false, false, false, true, true, true, true, true };





                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {      "The process of turning a gas into a liquid is called condensation.\n",
                                            "In the periodic table, 'Na' represents the element Nickel.\n",
                                            "Fungi are classified as plants.\n",
                                            "The speed of light is faster than the speed of sound.\n",
                                            "The human skeleton is made up of more than 300 bones.\n",
                                            "The ozone layer is located in the troposphere.\n",
                                            "All planets in our solar system revolve around the Sun in a clockwise direction.\n",
                                            "Mars is known as the 'Blue Planet.'\n",
                                            "A light year measures time, not distance.\n",
                                            "The Earth's core is primarily composed of iron and nickel.\n",
                                            "The process of converting food into energy is called respiration.\n",
                                            "DNA stands for Deoxyribonucleic acid.\n",
                                            "Antibiotics are effective against viruses.\n",
                                            "Spiders are insects.\n",
                                            "Water is a good conductor of electricity.\n" };

                bool[] answers = { true, false, false, true, false, false, false, false, false, true, false, true, false, false, false };

                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
                                        "The phenomenon of time dilation occurs according to Newtonian physics.\n",
                                        "Dark matter makes up the majority of the universe's mass.\n",
                                        "Black holes emit light, making them visible in telescopes.\n",
                                        "RNA can replicate itself without the help of DNA.\n",
                                        "The Heisenberg Uncertainty Principle states that both the position and momentum of a particle can be precisely determined simultaneously.\n",
                                        "Mitochondria are the powerhouse of plant cells.\n",
                                        "The concept of parallel universes is supported by the Many-Worlds Interpretation of quantum mechanics.\n",
                                        "The human brain is the largest brain relative to body size among all animals.\n",
                                        "The Richter scale measures the intensity of hurricanes.\n",
                                        "Protons are smaller than electrons.\n",
                                        "The Casimir effect is a gravitational force between two closely placed masses.\n",
                                        "Venus rotates on its axis in the opposite direction compared to most planets.\n",
                                        "In quantum entanglement, information is transmitted faster than the speed of light.\n",
                                        "Cherenkov radiation is responsible for the blue glow in nuclear reactors.\n",
                                        "Dark energy is responsible for the accelerating expansion of the universe.\n"};

                bool[] answers = { false, false, false, false, false, false, true, false, false, false, false, false, false, true, true };

                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
    "Andres Bonifacio was the first president of the Philippines.\n",
    "The Battle of Mactan occurred in 1898.\n",
    "Emilio Aguinaldo declared Philippine independence on June 12, 1898.\n",
    "The 'Cry of Pugad Lawin' marked the beginning of the Philippine Revolution in 1896.\n",
    "Jose Rizal wrote 'Noli Me Tangere' and 'El Filibusterismo.'\n",
    "The Philippines gained independence from the United States in 1946.\n",
    "The People Power Revolution in 1986 led to the ousting of President Ferdinand Marcos.\n",
    "The first Philippine President was Manuel L. Quezon.\n",
    "The Bataan Death March occurred during World War II.\n",
    "The Philippine national hero, Jose Rizal, was executed in Intramuros.\n"
};

                bool[] answers = {
    false,
    false,
    false,
    false,
    true,
    false,
    true,
    false,
    false,
    false
};

                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
    "Apolinario Mabini was known as the 'Brains of the Katipunan.'\n",
    "The Treaty of Paris in 1898 marked the end of the Spanish-American War and ceded the Philippines to the United States.\n",
    "The First Philippine Republic was formally established on January 23, 1899.\n",
    "General Antonio Luna was assassinated during the Philippine-American War.\n",
    "The Moro Rebellion occurred in the early 20th century in Mindanao and Sulu.\n",
    "The Commonwealth of the Philippines was established in 1935.\n",
    "The Battle of Leyte Gulf in 1944 was one of the largest naval battles in history.\n",
    "President Ferdinand Marcos declared martial law in 1972.\n",
    "The assassination of Benigno Aquino Jr. in 1983 triggered widespread protests against the Marcos regime.\n",
    "The People Power Revolution in 1986 resulted in the exile of Ferdinand Marcos.\n",
    "The Philippines is composed of 7,107 islands.\n",
    "The 'Balangiga Massacre' refers to the killing of Filipino civilians by American soldiers in 1901.\n",
    "Corazon Aquino was the first female president of the Philippines.\n",
    "The Manila Galleon Trade was a maritime route between Manila and Acapulco, Mexico.\n",
    "The Ifugao Rice Terraces are often referred to as the 'Eighth Wonder of the World.'\n"
};

                bool[] answers = {
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true,
    true
};






                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
    "The 'Jabidah Massacre' refers to the killing of Muslim recruits in 1968.\n",
    "The Manila-Acapulco Galleon Trade lasted for more than 200 years.\n",
    "The 'Cry of Pugad Lawin' marked the beginning of the Philippine Revolution in 1896.\n",
    "The longest-serving Philippine president was Ferdinand Marcos.\n",
    "Emilio Aguinaldo was the first and only president of the First Philippine Republic.\n",
    "The Basi Revolt was a rebellion against the Spanish colonial government's monopoly on the production of basi (sugarcane wine).\n",
    "The Magellan's Cross in Cebu City houses the original cross planted by Ferdinand Magellan in 1521.\n",
    "The 'Lavandera Ko' is a term associated with the propaganda movement during the Spanish colonial period.\n",
    "The 'Treaty of Paris' in 1898 resulted in the cession of the Philippines to the United States by Spain.\n",
    "President Diosdado Macapagal officially changed the celebration of Independence Day from July 4 to June 12.\n",
    "The 'Cordillera Administrative Region' (CAR) was officially established in 1987.\n",
    "The Balangiga Bells were returned to the Philippines by the United States in 2018.\n",
    "Dr. Jose Protacio Rizal Mercado y Alonzo Realonda was the full name of Jose Rizal.\n",
    "The 'Kurit-Lagting' is a traditional courtship dance in the Philippines.\n",
    "The 'Battle of Tirad Pass' is associated with the heroism of Gregorio del Pilar.\n",
};

                bool[] answers = {
    true,
    true,
    true,
    true,
    false,
    true,
    false,
    false,
    true,
    true,
    true,
    true,
    true,
    false,
    true,
    true
};






                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
    "Itinatag ni Andres Bonifacio ang Katipunan.\n",
    "Si Emilio Aguinaldo ang huling pangulo ng Pilipinas.\n",
    "Si Melchora Aquino ay kilala bilang 'Bayani ng Mactan.'\n",
    "Si Lapu-Lapu ang nanguna sa EDSA Revolution.\n",
    "Ang Sigaw ng Pugad Lawin ay nangyari noong 1898.\n",
    "Ang Unibersidad ng Santo Tomas ang pinakamatandang unibersidad sa Pilipinas.\n",
    "Si Jose Rizal ang sumulat ng 'Noli Me Tangere' at 'El Filibusterismo.'\n",
    "Ang mga titik ng pambansang awit ng Pilipinas ay mula sa 'Bayang Magiliw.'\n",
    "Ang Puerto Princesa Subterranean River ay matatagpuan sa Luzon.\n",
    "Si Manuel L. Quezon ay ipinanganak sa Baler, Tayabas.\n"
};

                bool[] answers = {
    true,
    true,
    false,
    false,
    false,
    true,
    true,
    false,
    false,
    true
};






                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
    "Ang Labanan sa Mactan ay nangyari noong 1521.\n",
    "Ang Rebolusyon sa EDSA ay naganap noong 1896.\n",
    "Ang 'Kamay Ni Hesus' ay isang bundok na itinuturing na sagrado.\n",
    "Puerto Princesa ang kabisera ng Palawan.\n",
    "Ang Krus ni Magellan sa Cebu ay ipinangalan sa isang lokal na lider.\n",
    "Si Emilio Aguinaldo ang nagdeklara ng kasarinlan noong 1898.\n",
    "Ang 'Tinikling' ay isang tradisyonal na sayaw sa Pilipinas.\n",
    "Ang Bulkang Taal ay matatagpuan sa lalawigan ng Batangas.\n",
    "Ang mga sakit na dengue at malaria ay dulot ng parehong lamok.\n",
    "Si Apolinario Mabini ay tinaguriang 'Dakilang Utak ng Rebolusyon.'\n",
    "Ang unang pambansang watawat ng Pilipinas ay may tatlong pula at dalawang puting bituin.\n",
    "Ang Banaue Rice Terraces ay kilala bilang 'The Eighth Wonder of the World.'\n",
    "Ang bayang Kawit, Cavite, ang naging unang kabisera ng Pilipinas.\n",
    "Ang kasaysayan ng 'Flores de Mayo' ay konektado sa relihiyosong pagdiriwang ng mga Katoliko.\n",
    "Si Gregorio Del Pilar ay tinatawag na 'Boy General' sa kasaysayan ng Pilipinas.\n"
};

                bool[] answers = {
    false,
    false,
    true,
    true,
    false,
    true,
    false,
    true,
    false,
    true,
    false,
    true,
    true,
    false,
    true
};






                int numberOfQuestions = questions.Length;
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
                Console.WriteLine("Welcome to the Quiz Game!");



                string[] questions = {
    "Si Gregorio del Pilar ang naging heneral sa Labanang Tirad Pass.\n",
    "Ang Impeachment ay isang proseso para alisin ang Pangulo sa pwesto.\n",
    "Ang 'La Solidaridad' ay isang aklat na isinulat ni Marcelo H. del Pilar.\n",
    "Ang Bundok Makiling ay matatagpuan sa lalawigan ng Laguna.\n",
    "Ang tawag sa pagsusulat ng tula na nagsasaad ng malungkot na damdamin ay 'balak.'\n",
    "Ang Republika ng Biak-na-Bato ay itinatag noong 1896.\n",
    "Si Ramon Magsaysay ay kilala bilang 'Champion of Democracy.'\n",
    "Ang Misa de Gallo ay isang tradisyonal na okasyon sa Pilipinas tuwing Pasko.\n",
    "Ang salitang 'Bayanihan' ay nangangahulugang pagsasama-sama ng mga tao sa isang barangay.\n",
    "Ang 'Filipino Time' ay kilala sa maagang pagdating sa mga okasyon.\n"
};

                bool[] answers = {
    false,
    true,
    false,
    true,
    true,
    true,
    true,
    true,
    true,
    false,
    false,
    true,
    true,
    false,
    false,
    true,
    false,
    false,
    true,
    false,
    true
};






                int numberOfQuestions = questions.Length;
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
    }

}
