using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairExersice
{
    public class WordManager
    {
        public string[] GetArrayFromString(string input) 
        {
            if (string.IsNullOrWhiteSpace(input)) return null;
            string[] words = input.Split(' ');
            words.ToList().Sort();
            return words;
        }
    }
}
