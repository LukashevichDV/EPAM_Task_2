using System.Collections.Generic;

namespace Task_2
{
    public class Word
    {
        public string Value { get; private set; }
        public int WordCount { get; private set; }
        public List<int> PageNumber { get; set; }


        public Word(string value, int wordCount, int numberOfPage)
        {
            PageNumber = new List<int>();
            Value = value;
            WordCount = wordCount;
            PageNumber.Add(numberOfPage);
        }

    }
}
