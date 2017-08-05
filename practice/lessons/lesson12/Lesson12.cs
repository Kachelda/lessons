using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson_class.UtilsForLessons;

namespace lesson_class.lessons.lesson12
{
    class Lesson12
    {
        const int counterForFinish = 10;
        const string wordForExit = "exit";// слово для выхода из игры

        Dictionary<string, IGrid> grids;
        
        List<List<string>> listfinal;
        List<string> list;
        List<string> listCharacters;
        List<string> listCharactersForRandom;
        
        int counter = 0;//счетчик правильных слов
        

        public Lesson12()
        {
            grids = new Dictionary<string, IGrid>();
            grids.Add(EnumGrid.column.ToString(), new Column());
            grids.Add(EnumGrid.row.ToString(), new Row());

            listfinal = new List<List<string>>();
            listCharacters = new List<string>();
            listCharactersForRandom = new List<string>();
            list = new List<string>
            { "сок", "сом", "кум", "ком", "кол", "кор", "сор",
              "сук", "мор", "мул", "мак", "мир", "лом", "лук",
              "лак", "рок", "ром", "рак", "рис", "аул", "оса"};
           
            initField();
            onRun();
        }

        private void initField()
        {
            //собираем буквы в список
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    if (Utils.CountContains(listCharactersForRandom, list[i][j].ToString()) == 0)
                    {
                        listCharactersForRandom.Add(list[i][j].ToString());
                    }
                }
            }

            //используем рандом
            for (int i = listCharactersForRandom.Count - 1; i >= 0; i--)
            {
                int ram = new Random().Next(0, i);
                listCharacters.Add(listCharactersForRandom[ram]);
                listCharactersForRandom.Remove(listCharactersForRandom[ram]);
            }

            //переносим в двумерный список
            int ind = 0;
            for (int i = 0; i < 3; i++)
            {
                listfinal.Add(new List<string>());

                for (int j = 0; j < 3; j++)
                {
                    listfinal[i].Add(listCharacters[ind]);
                    ind++;
                }
            }
        }

        private void onRun()
        {
            int lineNumber;
            string inputText;

            Utils.PrintTwoDimensional(listfinal);
            CheckWord();

            while (true)
            {
                Console.WriteLine("Введите 'row' или 'column' для изменения игрового поля, либо 'exit' для выхода из игры :");
                inputText = Console.ReadLine();

                if (inputText == wordForExit)
                {
                    Environment.Exit(0);
                }
                else if (inputText == EnumGrid.row.ToString() || inputText == EnumGrid.column.ToString())
                {
                    IGrid grid = grids[inputText];
                    Console.WriteLine("Введите номер <" + grid.getName() + "> от 0 до 2 :");

                    if (Int32.TryParse(Console.ReadLine(), out lineNumber) && lineNumber >= 0 && lineNumber <= 2)
                    {
                        Console.WriteLine("Введите направление " + grid.getBackwardName() + " или " + grid.getForwardName() + " :");
                        string direction = Console.ReadLine();

                        if (direction == EnumDirection.left.ToString() || direction == EnumDirection.down.ToString())
                        {
                            grid.Backward(listfinal, lineNumber);
                        }
                        else if (direction == EnumDirection.right.ToString() || direction == EnumDirection.up.ToString())
                        {
                            grid.Forward(listfinal, lineNumber);
                        }
                        else
                        {
                            Console.WriteLine("Повторите ввод!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Повторите ввод!");
                    }
                }
                else
                {
                    Console.WriteLine("Повторите ввод!");
                }

                Utils.PrintTwoDimensional(listfinal);
                CheckWord();
            }
        }

        private void CheckWord()
        {
            string str = listfinal[1][0] + listfinal[1][1] + listfinal[1][2];
            if (Utils.CountContains(list, str) == 1)
            {
                list.Remove(str);
                counter++;
                if (counter == counterForFinish)
                {
                    Console.WriteLine("Игра окончена!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Количество правильных слов = {0}", counter);
        }
        
        public enum EnumGrid
        {
            row,
            column
        }

        public enum EnumDirection
        {
            up,
            down,
            left,
            right
        }
    }
}
