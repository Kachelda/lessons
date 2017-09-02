using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Game15.GameData
{
    class FileOutput: IOutput
    {
        public void OutputBoard(Board board)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Game15.txt", true))
                {
                    
                    
                    foreach (Row row in board.Rows)
                    {
                        sw.WriteLine(GetLine(board.Dimension));
                        sw.WriteLine(GetEmptyLine(board.Dimension));
                        string g1 = "|";
                        string g2 = "  ";
                        string g3 = "   |";

                        foreach (Cell cell in row.Cells)
                        {
                            switch (cell.TypeValue())
                            {
                                case Cell.ReturnValue.INT:
                                    g1 = g1 + g2 + cell.GetValue() + g3.Substring(cell.GetValue().ToString().Length);
                                    break;
                                case Cell.ReturnValue.STRING:
                                    g1 = g1 + g2 + ((EmptyCell)cell).GetValue() + g3;
                                    break;
                            }
                        }
                        sw.WriteLine(g1);
                        sw.WriteLine(GetEmptyLine(board.Dimension));
                    }
                    sw.WriteLine(GetLine(board.Dimension));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string GetLine(int dimension)
        {
            string str = "";
            string str1 = "+-----";
            for (int i = 0; i < dimension; i++)
            {
                str += str1;
            }
            str = str + "+";
            return str;
        }

        public string GetEmptyLine(int dimension)
        {
            string str = "";
            string str1 = "|     ";
            for (int i = 0; i < dimension; i++)
            {
                str += str1;
            }
            str = str + "|";
            return str;
        }
    }
}
