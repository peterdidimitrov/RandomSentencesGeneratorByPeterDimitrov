namespace RandomSentencesGenerator
{
    using System;

    internal class RandomSentencesGenerator
    {
        static void Main(string[] args)
        {
            //Initialising the arrays of words
            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };
            
            //The program displays greeting
            Console.WriteLine("Hello, this is your first ramdom-generated sentence: ");


            while (true)
            {
                //Simplifying the code by creating a method, which chooses the random word
                //Declaring the variables for different part of the sentence
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);
                
                //Creating a random sentence
                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetail}.";

                //Displaying the sentence in green colour
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sentence);
                Console.ResetColor();

                //The program restarts and generates another sentence by pressing ENTER button
                Console.WriteLine("Click [ENTER] to generate a new one.");

                Console.ReadLine();
            }
        }

        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int ranndomIndex = random.Next(words.Length);
            string word = words[ranndomIndex];
            return word;
        }
    }
}
