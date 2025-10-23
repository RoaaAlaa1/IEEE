using System;

namespace QuizGame
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Qs = new string[5]
            {
                "1. What was Frisk's soul power?",
                "2. What's Toriel's pie flavor?",
                "3. Who was Flowey?",
                "4. What was Asgore's weakness?",
                "5. Who was the first monster that Frisk had to fight?"
            };

            string[] As = new string[5]
            {
                "Determination",
                "Butterscotch",
                "Azriel",
                "Toriel's pie",
                "Froggit"
            };

            int correctCount = 0;
            Console.WriteLine(">>Welcome to my Undertale quiz game ^^ <<");
            Console.WriteLine("\nPlease answer the following questions: ");

            for (int i = 0; i < Qs.Length; i++)
            {
                Console.WriteLine($"\n{Qs[i]}");
                string userInput = Console.ReadLine();

                //Checking correct answers
                try
                {
                    bool answer = CheckAns(userInput, As[i]);
                    if (answer == true)
                    {
                        Console.WriteLine("\nThat's correct! you get a piece of Toriel's pie.");
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine($"\nThat's incorrect :(. The correct answer is {As[i]}. \nStay determined!");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }

            }
            //Checking correct answers count
            Console.WriteLine($"\nYou've answered {correctCount} questions out of {Qs.Length}");
            if (correctCount >= 3)
            {
                Console.WriteLine("\n\nYou have great determination enough to break the barrier! \nTake care of yourself, kid. \nCause someone really cares about you");
            }
            else
            {
                Console.WriteLine("\n\nDon't lose hope yet.. \nFrisk! \nStay determined.");
            }

        }
    

        

        private static bool CheckAns(string userInput, string As)
        {
            //raising an exception for empty input
            if (string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Answer cannot be empty");
                
            }


            if (userInput == As)
            {
                return true;
                
            }
            else
            {
                return false;
                
            }
        }
    }
}