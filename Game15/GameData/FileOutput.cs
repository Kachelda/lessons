using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
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
                using (StreamWriter sw = new StreamWriter("Game15.txt", false))
                {
                    sw.WriteLine(board.Dimension);

                    foreach (Row row in board.Rows)
                    {
                        foreach (ICell cell in row.Cells)
                        {
                            if (cell.Data == String.Empty)
                            {
                                sw.Write("0" + " ");
                            }
                            else
                            {
                                sw.Write(cell.Data + " ");
                            }
                        }
                    }
                    sw.WriteLine();

                    foreach (Row row in board.Rows)
                    {
                        sw.WriteLine(GetLine(board.Dimension));
                        sw.WriteLine(GetEmptyLine(board.Dimension));
                        string g1 = "|";
                        string g2 = "  ";
                        string g3 = "   |";

                        foreach (var cell in row.Cells)
                        {
                            if (cell.GetType() == typeof(Cell))
                            {
                                g1 = g1 + g2 + ((Cell)cell).Data + g3.Substring(((Cell)cell).Data.ToString().Length);
                            }
                            else if (cell.GetType() == typeof(EmptyCell))
                            {
                                g1 = g1 + g2 + ((EmptyCell)cell).Data.ToString() + g3;
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
