using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    class CustomValue
    {
        private int _dataInt;

        private string _dataStr;

        public CustomValue(int data)
        {
            _dataInt = data;
        }

        public CustomValue(string data)
        {
            _dataStr = data;
        }

        public int GetDataInt()
        {
            return _dataInt;
        }

        public string GetDataStr()
        {
            return _dataStr;
        }
    }
}
