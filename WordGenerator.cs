using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGenerator
{
    class WordGenerator
    {
        private List<string> Words { get; set; }
        public WordGenerator() { Words = new List<string>(); }
        public WordGenerator(IEnumerable<string> words)
        {
            Words = new List<string>();
            AddWords(words);
        }
        public WordGenerator AddWord(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                if (!Words.Contains<string>(word))
                    Words.Add(word);
            }
            else
                throw new ArgumentException("Word can not be null or empty");
            return this;
        }
        public WordGenerator AddWords(IEnumerable<string> words)
        {
            foreach(string word in words)
            {
                AddWord(word);
            }
            return this;
        }
        public WordGenerator DeleteWord(string word)
        {
            if (Words.Contains<string>(word))
                Words.Remove(word);
            else
                throw new ArgumentException();
            return this;
        }
        public string GenerateWord()
        {
            Random rnd = new Random();
            return GenerateWord(rnd);
        }
        public string GenerateWord(Random rnd)
        {
            if (Words.Count > 0)
                return Words[rnd.Next(0, Words.Count)];
            else
                return null;
        }
    }
}
