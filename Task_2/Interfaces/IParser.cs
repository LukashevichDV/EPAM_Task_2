using System.Collections.Generic;

namespace Task_2.Interfaces
{
    public interface IParser<T>
    {
        T Parse(List<string> str);
    }
}