using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_Object_Oriented_Practice_Problem
{
    class WordReverser
    {
        public string ReverseWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] wordChars = words[i].ToCharArray();
                Array.Reverse(wordChars);
                words[i] = new string(wordChars);
            }

            return string.Join(" ", words);
        }
    }
}
