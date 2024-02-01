using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    public sealed class TwoDimentionArr : Program
    {
        public int[,] array;
        public bool WayOfInputtingTheArray = false;
        /*public TwoDimentionArr(int colomnsN, int linesM)
        {
            array = new int[colomnsN, linesM];
        }*/

        public override void Initializ()
        {
            Console.WriteLine("Двумерные  массивы");
            Console.WriteLine("Введите количество элементов в столбце.");
            int colomnsN = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество элементов в строке.");
            int linesM = int.Parse(Console.ReadLine());
            array = new int[colomnsN, linesM];
            Console.WriteLine("Хотите сами ввести массив? + = да, - = нет");
            if (Console.ReadLine() == "+")
            {
                UserFill();
            }
            else
            {
                RandFill();
            }
        }

        public override void UserFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        /*public void TwoDimentionArrINP(bool WayOfInputtingTheArray)
        {
            if (WayOfInputtingTheArray == false)
            {
                RandFill();
            }
            else
            {
                UserFill();
            }
        }*/

        public override void Output()
        {
            Console.WriteLine("Двумерный массив");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override void countAverage()
        {
            Console.WriteLine("Среднее значение в двумерном массиве:");
            int m = 0;
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    k += array[i, j];
                    m++;
                }
            }
            Console.WriteLine(k / m);
        }

        public override void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
        }


        /*public void PrintArrBackw(int colomnsN, int linesM)
        {
            for (int i = 0; i < colomnsN; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = linesM - 1; j >= 0; j--)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                else
                {
                    for (int j = 0; j < linesM; j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }*/
    }
}


