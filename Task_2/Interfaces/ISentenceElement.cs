using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Enum;

namespace Task_2.Interfaces
{
    public interface ISentenceElement
    {
        string Value { get;}
        SentenceElementType SentenceElementType { get; }
    }
}
