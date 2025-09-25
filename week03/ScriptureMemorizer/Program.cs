// I added a reset feature to show all the words again when the user types 'reset'.


using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("Moroni", 9, 6);
        Scripture scripture = new(reference, "And now, my beloved son, notwithstanding their hardness, let us labor diligently; for if we should cease to labor, we should be brought under condemnation; for we have a labor to perform whilst in this tabernacle of clay, that we may conquer the enemy of all righteousness, and rest our souls in the kingdom of God.");

        Console.WriteLine("");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press Enter to hide random words or type 'quit' to exit.");

        string input = Console.ReadLine();
        while (input.ToLower() != "quit")
        {
            if (input.ToLower() == "reset")
            {
                scripture.ResetWords();
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to hide random words, type 'reset' to show all the words, or type 'quit' to exit.");
                input = Console.ReadLine();
                continue;
            }

            if (!scripture.IsCompletelyHidden())
            {
                Console.Clear();

                int visibleWordsCount = scripture.GetVisibleWordCount();


                if (visibleWordsCount < 3)
                {
                    scripture.HideRandomWords(visibleWordsCount);
                }
                else
                {
                    scripture.HideRandomWords(3);
                }

                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to hide random words, type 'reset' to show all the words, or type 'quit' to exit.");
                input = Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("All words are hidden. Type 'reset' to show all the words, Press Enter or type 'quit' to exit.");
                input = Console.ReadLine();
                if (input.Length == 0 || input.ToLower() == "quit")
                {
                    break;
                }

            }
        }
    }
}