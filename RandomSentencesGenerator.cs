namespace RandomSentencesGenerator
{
    using System;

    internal class RandomSentencesGenerator
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };

            Console.WriteLine("Hello, this is your first ramdom-generated sentence: ");


            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetail}.";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sentence);
                Console.ResetColor();

                Console.WriteLine("Click [Enter] to generate a new one.");

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