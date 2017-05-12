using System.Collections.Generic;
using System.IO;

namespace Task_2
{
    public class Document
    {
        private StreamReader StreamReader;
        private List<DocPage> Pages;
        private DocPage Page;
        private int NumberOfLinesOnPage;
        private string FileName;
        private string BufLine = string.Empty;

        public Document(string fileName, int numberOfLinesOnPage = 40)
        {
            NumberOfLinesOnPage = numberOfLinesOnPage;
            FileName = fileName;
        }
        private void ReadFileContent()
        {
            StreamReader = new StreamReader(FileName);
            Pages = new List<DocPage>();

            string line;
            int countLines = 1;
            int pageNumber = 1;
            Page = new DocPage(pageNumber, NumberOfLinesOnPage);

            while ((line = _streamReader.ReadLine()) != null)
            {
                //When all lines of page are filled adding filled page to list of pages
                //Creating new page and start filling it again. Counting of lines is starting again
                if (countLines > _numberOfLinesPerPage)
                {
                    _pages.Add(_page);
                    pageNumber++;
                    _page = new Page(pageNumber, _numberOfLinesPerPage);
                    countLines = 1;
                }

                //if page isn't filled continue to filling it and counting lines
                _page.AddLine(line);
                countLines++;
            }
            //Adding last page to page list
            _pages.Add(_page);

            //Closing Stream
            _streamReader.Close();
        }
    }
}
}