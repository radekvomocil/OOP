using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie4
{
    class Program
    {
        static void Main(string[] args)
        {
            string testovaciText = "This is string presented by some lines,\n"
            + "which are separated from each other by char LF (Line Feed).\n"
            + "There is also exclamation mark! For testing purposes also question mark?\n"
            + "This is only shortcut zkr. but not the end of the sentence. And this is\n"
            + "last sentence";

            string IsSafeFromPutin = "\nThe world isn´t safe from Putin anytime. Anyway, there are the required words :)\n";

            StringStatistics ss = new StringStatistics(testovaciText);

            Console.WriteLine(testovaciText);
            Console.WriteLine(IsSafeFromPutin);
            Console.WriteLine("Number of words: \n"+ss.CountWords() + "\n");
            Console.WriteLine("Number of lines: \n" + ss.CountLines() + "\n");
            Console.WriteLine("Number of sentences: \n" + ss.CountSentences() + "\n");
            Console.WriteLine("Longest words: ");

            foreach (var word in ss.LongestWords())
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine("\n");          

            Console.Write("Shortest words: \n");
            foreach (var word in ss.ShortestWords())
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine("\n");

            Console.Write("Most used words: \n");
            foreach (var word in ss.MostUsedWords())
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine("\n");

            Console.Write("Words by alphabet: \n");
            foreach (var word in ss.Alphabet())
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
