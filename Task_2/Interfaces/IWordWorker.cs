namespace Task_2.Interfaces
{

    public interface IWordWorker
    {
        int GetWordLength(ISentenceElement element);
        bool FirstLetterIsConsonant(ISentenceElement element);
        void ReplaceValue(int wordLenght, ISentenceElement element, string newValue);
    }
}
