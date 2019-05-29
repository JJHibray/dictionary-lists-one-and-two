using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        /*
        Create a dictionary with key value pairs to
        represent words (key) and its definition (value)
        */
        // Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

        // // Add several more words and their definitions
        // wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
        // wordsAndDefinitions.Add("Groovy", "The feeling of learning code in the 70's");
        // wordsAndDefinitions.Add("Kalabunga", "Ninja Turtle speak for hells yeah!");
        // wordsAndDefinitions.Add("Hi", "a word used to greet another");


        // /*
        // Use square bracket lookup to get the definition two
        // words and output them to the console
        // */

        //       Console.WriteLine(wordsAndDefinitions["Groovy"]);
        //       Console.WriteLine(wordsAndDefinitions["Kalabunga"]);



        // /*
        // Loop over dictionary to get the following output:
        // The definition of [WORD] is [DEFINITION]
        // The definition of [WORD] is [DEFINITION]
        // The definition of [WORD] is [DEFINITION]
        // */
        // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
        //     {
        //         Console.WriteLine($"The definition of {word.Key} is {word.Value}");
        //         Console.WriteLine();
        //     }



// List of dictionaries about words

// Make a new list
List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

/*
    You want to track the following about each word:
        word, definition, part of speech, example sentence

    Example of one dictionary in the list:
    {
        "word": "excited",
        "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
        "part of speech": "adjective",
        "example sentence": "I am excited to learn C#!"
    }
*/

// Create dictionary to represent a few word

// Add each of the 4 bits of data about the word to the Dictionary

 Dictionary<string, string> music = new Dictionary<string, string>(){
                {"Word", "Music"},
                {"Definition", "organized sound for listening pleasure"},
                {"part of speech", "Noun"},
                {"example", "I was listening to music to help relax at the end of a long day"}
            };

            Dictionary<string, string> car = new Dictionary<string, string>(){
                {"Word", "car"},
                {"Definition", "Machine on wheels that is used for transportation"},
                {"part of speech", "Noun"},
                {"example", "I drove my car to school"}
            };


// Add Dictionary to your `dictionaryOfWords` list
dictionaryOfWords.Add(music);

// create another Dictionary and add that to the list\
dictionaryOfWords.Add(car);


/*
    Iterate your list of dictionaries and output the data

    Example output for one word in the list of dictionaries:
        word: excited
        definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
        part of speech: adjective
        example sentence: I am excited to learn C#!
*/




// Iterate the List of Dictionaries
    foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
 // Iterate the KeyValuePairs of the Dictionary
            foreach (KeyValuePair<string, string> kvp in word)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }



            }

        }
    }

}