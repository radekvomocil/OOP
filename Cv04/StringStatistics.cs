using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cvicenie4
{
    public class StringStatistics
    {
        string text;
        string textNoSpecialChars;
        public StringStatistics(string text) {
            this.text = text;
            textNoSpecialChars = text.Replace(".", "").Replace(",", "")
                .Replace("?", "").Replace("!", "")
                .Replace("\n", " ").Replace("(", "").Replace(")", "");
        }

        public int CountWords()
        {
            var count = textNoSpecialChars.Split(' ').Length;

            return count;
        }

        public int CountLines()
        {
            var count = text.Split('\n').Length;

            return count;
        }

        public int CountSentences()
        {
            var st = text.Replace("\n", " ").Replace(",", "").Replace("(", "").Replace(")", "");
            string[] splitSentences = Regex.Split(st, @"(?<=['""A-Za-z0-9][\.\!\?])\s+(?=[A-Z])");

            return splitSentences.Length;
        }

        public List<string> LongestWords()
        {
            string[] stringOfWords = textNoSpecialChars.Split(' ');

            var ordered = stringOfWords.OrderBy(x => x.Length).ToList<string>();

            ordered.Reverse();

            var finalList = new List<string>();

            var len = 0;

            foreach (var word in ordered)
            {
                if (word.Length >= len)
                {
                    len = word.Length;
                    finalList.Add(word);
                }
            }

            return finalList;
        }

        public List<string> ShortestWords()
        {
            string[] stringOfWords = textNoSpecialChars.Split(' ');

            var ordered = stringOfWords.OrderBy(aux => aux.Length).ToList<string>();

            var finalList = new List<string>();

            var len = 15;

            foreach (var word in ordered)
            {
                if (word.Length <= len)
                {
                    len = word.Length;
                    finalList.Add(word);
                }
            }

            return finalList;
        }

        public string[] MostUsedWords()
        {
            string[] stringOfWords = textNoSpecialChars.Split(' ');
            var nameGroup = stringOfWords.GroupBy(x => x);
            var maxCount = nameGroup.Max(g => g.Count());
            var mostCommons = nameGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToArray();

            return mostCommons;
        }

        public List<string> Alphabet()
        {
            string[] stringOfWords = textNoSpecialChars.Split(' ');

            var list = new List<string>();
            foreach (var word in stringOfWords)
            {
                list.Add(word);
            }
            list.Sort();
            return list;
        }
    }
}
