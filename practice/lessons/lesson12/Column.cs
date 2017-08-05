using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson12
{
    class Column : BaseGrid, IGrid
    {
        const string name = "column";

        public void Backward(List<List<string>> list, int lineNumber)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (j == lineNumber)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i - 1][j];
                        list[i - 1][j] = k;
                    }
                }
            }
        }

        public void Forward(List<List<string>> list, int lineNumber)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (j == lineNumber)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i + 1][j];
                        list[i + 1][j] = k;
                    }
                }
            }
        }

        public string getBackwardName()
        {
            return "down";
        }

        public string getForwardName()
        {
            return "up";
        }

        override public string getName()
        {
            return name;
        }
    }
}
