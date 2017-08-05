using System.Collections.Generic;

namespace lesson_class.lessons.lesson12
{
    internal interface IGrid
    {
        string getName();

        string getForwardName();

        string getBackwardName();

        void Forward(List<List<string>> list, int lineNumber);

        void Backward(List<List<string>> list, int lineNumber);
    }
}