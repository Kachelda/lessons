using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15.GameData
{
    class FileInput: IInput
    {
        public int GetDimension()
        {
            int dimension = 0;
            try
            {   
                using (StreamReader sr = new StreamReader("Dimension.txt"))
                {
                    dimension = Convert.ToInt32(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return dimension;
        }
    }
}
