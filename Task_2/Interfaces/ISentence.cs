﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Interfaces
{

    public interface ISentence
    {
        void AddElementToEnd(ISentenceElement element);
        int GetWordsCount();
        int GetElementsCount();
        ISentenceElement GetElementByIndex(int index);
        void DeleteWords(int wordLenght);
        void ReplaceWords(int wordLenght, string newValue);
    }
}