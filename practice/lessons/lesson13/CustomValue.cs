using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_class.lessons.lesson13
{
    class CustomValue
    {
        public int data;

        public string dataStr;

        public CustomValue(int _data)
        {
            data = _data;
        }

        public CustomValue(string _data)
        {
            dataStr = _data;
        }

        public int GetValue(int value = 0)
        {
            return data;
        }

        public string GetValue(string value = "")
        {
            return dataStr;
        }
    }

    class CustomValueT<T>
    {
        public T data;

        public CustomValueT(T _data)
        {
            data = _data;
        }

        public T GetValue()
        {
            return data;
        }
    }
}
