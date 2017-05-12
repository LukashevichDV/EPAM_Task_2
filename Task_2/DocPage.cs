using System.Collections.Generic;

namespace Task_2
{
    public class DocPage
    {
        public int CurrentPageNumber { get; private set; }
        public List<string> Lines { get; private set; }
        public int NumberOfLines { get; private set; }


        public DocPage(int currentPageNumber, int numberOfLines = 40)
        {
            CurrentPageNumber = currentPageNumber;
            NumberOfLines = numberOfLines;
            Lines = new List<string>();
        }


        public void AddLine(string line)
        {
            Lines.Add(line);
        }
    }
}