using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairExersice
{
    public class WordManager
    {
        public string[] GetSortedsArrayFromString(string input) 
        {
            if (string.IsNullOrWhiteSpace(input)) return new string[0];
            string[] words = input.Split(' ');
            Array.Sort(words, CompareByLastLetter);
            return words;
        }

        public int CompareByLastLetter(string wordX, string wordY) => wordX.Last().CompareTo(wordY.Last());
    }
}
