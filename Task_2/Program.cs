using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BuffReader reader = new BuffReader();
            String[] text = reader.Read(@"C:\Users\Lukas\Documents\Visual Studio 2015\Projects\TextParser\Text.txt");

            Concordance concordance1 = new Concordance();
            concordance1.AddWordsToDictionary(text);

            Console.ReadLine();
        }
    }
}