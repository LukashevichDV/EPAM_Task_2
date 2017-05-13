using System;
using System.IO;

namespace Task_2
{
    public class BuffReader
    {

        public string[] Read(String path)
        {

            string[] lines = { };
            try
            {
                lines = File.ReadAllLines(path: path);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lines;
        }




    }
}