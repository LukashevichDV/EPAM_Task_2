using System.Collections.Generic;

namespace Task_2
{
    public class WordInfo
    {
        public string Word { get; set; }
        public int WordCount { get; set; }
        public List<int> PageNumber { get; set; }


        public WordInfo(string word, int firstPageNumber)
        {
            this.Word = word;
            this.WordCount = 1;
            this.PageNumber = new List<int>() { firstPageNumber };
        }
    }
}

