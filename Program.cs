using System;
using System.Collections.Generic;

namespace Dictionary_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>()
            {
                { "Testing", "The act of pissing someone off"},
            };

            // Add several more words and their definitions

            wordsAndDefinitions.Add("Chundering", "Aussie slang for violent ejection of matter from the stomach through the mouth");
            wordsAndDefinitions.Add("Rekt", "A term for the word meaning something got completely destroyed");
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"{word.Key}: {word.Value})");
            }

        }
    }
}