using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_2
{
    public class Concordance
    {
        public Dictionary<string, WordInfo> concordanceDictionary = new Dictionary<string, WordInfo>();


        public void AddWordsToDictionary(string[] lines)
        {
            int i = 0;
            int StringsInPage = 5;// In one page will be 5 strings

            foreach (var line in lines)
            {
                foreach (string word in SplitWords(line.ToLower()))
                {
                    if (!concordanceDictionary.ContainsKey(word))
                    {
                        concordanceDictionary.Add(word, new WordInfo(word, i / StringsInPage + 1));
                        if (concordanceDictionary.ContainsKey(""))
                        {
                            concordanceDictionary.Remove("");
                        }
                    }
                    else
                    {
                        concordanceDictionary[word].WordCount++;
                        if (!concordanceDictionary[word].PageNumber.Contains(i / StringsInPage + 1))
                        {
                            concordanceDictionary[word].PageNumber.Add(i / StringsInPage + 1);
                        }
                    }
                }
                i++;
            }
        }

        public void ShowResult()
        {
            List<WordInfo> sortedWordInfo = concordanceDictionary.Values.OrderBy(x => x.Word).ToList();

            string temp2 = "";
            foreach (var pair in sortedWordInfo)
            {
                Console.WriteLine("\n");

                string temp = pair.Word.Substring(0, 1).ToUpper();
                if (temp != temp2)
                    Console.WriteLine("[{0}]", pair.Word.Substring(0, 1).ToUpper());

                temp2 = pair.Word.Substring(0, 1).ToUpper();

                Console.Write(pair.Word + " " + pair.WordCount + ":.......");
                foreach (int lineNumber in pair.PageNumber)
                {
                    Console.Write("{0},", lineNumber);
                }
            }
        }


        public static string[] SplitWords(string s)
        {
            return Regex.Split(s, @"\W+");
        }
    }
}