using System;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BuffReader reader = new BuffReader();
            String[] text = reader.Read(@"C:\Users\Lukas\Documents\Visual Studio 2015\Projects\TextParser\Text.txt");

            Concordance concordance = new Concordance();
            concordance.AddWordsToDictionary(text);
            concordance.ShowResult();

            Console.ReadLine();
        }
    }
}