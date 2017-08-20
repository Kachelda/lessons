using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson13
{
    class CustomValue
    {
        private int dataInt;

        private string dataStr;

        public CustomValue(int _data)
        {
            dataInt = _data;
        }

        public CustomValue(string _data)
        {
            dataStr = _data;
        }

        public int GetDataInt()
        {
            return dataInt;
        }

        public string GetDataStr()
        {
            return dataStr;
        }
    }
}
