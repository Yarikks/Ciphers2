using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reshetka
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 4;
            string[] buf = new string[SIZE] { "на_к", "арті", "1000", "0грн" };
            char[,] resh = new char[SIZE, SIZE];
            int[,] grid = new int[SIZE, SIZE]
            {
                          {1, 0, 1, 0},
                          {0, 0, 0, 0},
                          {0, 1, 0, 1},
                          {0, 0, 0, 0}
            };

            // вывод зашифрованного сообщения
            //for (int i = 0; i < SIZE; i++)
            //{
            //    Console.WriteLine(buf[i]);
            //}
            //Console.WriteLine("");
            int k1 = 0, k2 = 0;
            // прямой обход решетки
            Console.WriteLine("0 route:");
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        Console.Write(buf[k1][k2]);
                        resh[i, j] = buf[k1][k2];
                        k2++;
                        if (k2 == 4)
                        {
                            if (i > 0)
                            {
                                k1++;
                                k2 = 0;
                            }
                        }
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            // поворот решетки вокруг оси у
            grid = new int[SIZE, SIZE]
            {
                          {0, 1, 0, 1},
                          {0, 0, 0, 0},
                          {1, 0, 1, 0},
                          {0, 0, 0, 0}
            };
            Console.WriteLine("1 route:");
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        Console.Write(buf[k1][k2]);
                        resh[i, j] = buf[k1][k2];
                        k2++;
                        if (k2 == 4)
                        {
                            if (i > 0)
                            {
                                k1++;
                                k2 = 0;
                            }
                        }
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            // поворот решетки вокруг оси х
            grid = new int[SIZE, SIZE]
            {
                          {0, 0, 0, 0},
                          {1, 0, 1, 0},
                          {0, 0, 0, 0},
                          {0, 1, 0, 1}
            };
            Console.WriteLine("2 route:");
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        Console.Write(buf[k1][k2]);
                        resh[i, j] = buf[k1][k2];
                        k2++;
                        if (k2 == 4)
                        {
                            if (i > 0)
                            {
                                k1++;
                                k2 = 0;
                            }
                        }
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            // поворот решетки вокруг оси у
            grid = new int[SIZE, SIZE]
        {
                          {0, 0, 0, 0},
                          {0, 1, 0, 1},
                          {0, 0, 0, 0},
                          {1, 0, 1, 0}
        };
            Console.WriteLine("3 route:");
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        Console.Write(buf[k1][k2]);
                        resh[i, j] = buf[k1][k2];
                        k2++;
                        if (k2 == 4)
                        {
                            if (i > 0)
                            {
                                k1++;
                                k2 = 0;
                            }
                        }
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(resh[i, j] + " ");
                }
            }

            Console.ReadKey();

        }
    }
}
