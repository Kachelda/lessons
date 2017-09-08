using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    class CustomType
    {
        public Type Type { get; set; }

        public Object Value { get; set; }

        public Object GetValue(Type Type)
        {
            if (Type == typeof(Cell))
            {
                Value = (int) Value;
            }
            else if (Type == typeof(EmptyCell))
            {
                Value = (string) Value;
            }
            return Value;
        }
    }
}
