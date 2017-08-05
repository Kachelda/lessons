using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson12
{
    class Row : BaseGrid, IGrid
    {
        const string name = "row";

        public void Backward(List<List<string>> list, int lineNumber)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (i == lineNumber)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i][j + 1];
                        list[i][j + 1] = k;
                    }
                }
            }
        }

        public void Forward(List<List<string>> list, int lineNumber)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = list.Count - 1; j > 0; j--)
                {
                    if (i == lineNumber)
                    {
                        string k = list[i][j].ToString();
                        list[i][j] = list[i][j - 1];
                        list[i][j - 1] = k;
                    }
                }
            }
        }

        public string getBackwardName()
        {
            return "left";
        }

        public string getForwardName()
        {
            return "right";
        }

        override public string getName()
        {
            return name;
        }
    }
}
