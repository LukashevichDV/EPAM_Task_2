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


        public Document(string fileName, int numberOfLinesOnPage = 40)
        {
            NumberOfLinesOnPage = numberOfLinesOnPage;
            FileName = fileName;
        }


        public Document(string fileName, List<DocPage> pages)
        {
            FileName = fileName;
            Pages = pages;
        }


        private void ReadData()
        {
            StreamReader = new StreamReader(FileName);
            Pages = new List<DocPage>();

            string line;
            int currentCountLine = 1;
            int currentPageNumber = 1;
            Page = new DocPage(currentPageNumber, NumberOfLinesOnPage);

            while ((line = StreamReader.ReadLine()) != null)
            {
                if (currentCountLine > NumberOfLinesOnPage)
                {
                    Pages.Add(Page);
                    currentPageNumber++;
                    Page = new DocPage(currentPageNumber, NumberOfLinesOnPage);
                    currentCountLine = 1;
                }
                Page.AddLine(line);
                currentCountLine++;
            }
            Pages.Add(Page);
            StreamReader.Close();
        }

        public Document CreateDocument()
        {
            ReadData();
            return new Document(FileName, Pages);
        }
    }
}
