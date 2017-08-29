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
        public int Dimension { get; set; }

        public int GetDimension()
        {
            try
            {   
                using (StreamReader sr = new StreamReader("Dimension.txt"))
                {
                    Dimension = Convert.ToInt32(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return Dimension;
        }
    }
}
