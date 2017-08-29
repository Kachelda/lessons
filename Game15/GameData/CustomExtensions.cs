using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    public static class CustomExtensions
    {
        public static List<int> Shuffle(this List<int> list)
        {
            Random r = new Random();
            int n = list.Count;
            while (n > 1)
            {
                int k = r.Next(n--);
                int temp = list[k];
                list[k] = list[n];
                list[n] = temp;
            }
            return list;
        }
    }
}
