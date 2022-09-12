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
            string[] words = input.Split(' ');
            ReverseWordsInArray(words);
            words.ToList().Sort();
            ReverseWordsInArray(words);
            return words;
        }

        public string[] ReverseWordsInArray(string[] inputArray) 
        {
            char[] chars;
            for (int i = 0; i < inputArray.Length; i++)
            {
                chars = inputArray[i].ToCharArray();
                Array.Reverse(chars);
                inputArray[i] = new string(chars);
            }
            return inputArray;
        }
    }
}
