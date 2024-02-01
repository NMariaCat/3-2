using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    public sealed class OneDimentionArr : Program
    {
        //private int[] array = new int[100];
        //public bool WayOfInputtingTheArray = false;
        public int[] array;
        //Initializ();
        Random rnd = new Random();
        public OneDimentionArr()
        {

        }

        public override void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public override void RandFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }

        public override void Initializ()
        {
            Console.WriteLine("Одномерные  массивы");
            Console.WriteLine("Введите количество элементов.");
            int ElementsNumber = int.Parse(Console.ReadLine());
            array = new int[ElementsNumber];
            Console.WriteLine("Хотите сами ввести массив? + = да, - = нет");
            //bool WayInpArr1D;

            if (Console.ReadLine() == "+")
            {
                UserFill();
            }
            else
            {
                RandFill();
            }
        }

        /*public void OneDimentionArrINP(bool WayOfInputtingTheArray)
        {
            if (WayOfInputtingTheArray == false)
            {
                
            }
            else
            {
                
            }
        }*/
        public override void Output()
        {
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public override void countAverage()
        {
            Console.WriteLine("Среднее значение в одномерном массиве:");
            int m = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                k += array[i];
                m++;
            }
            Console.WriteLine(k / m);
        }
    }
    }

   

        /*public string DeleteMoreThan100(int ElementsNumber)
        {
            string line = "";
            for (int i = 0; i < ElementsNumber; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    line += array[i].ToString();
                    line += " ";
                }
            }
            return line;
        }

        public string DeleteTheRepeating(int ElementsNumber)
        {
            int[] arr = new int[100];
            string line = "";
            int t = 0;
            int[] b = array;
            for (int i = 0; i < ElementsNumber; i++)
            {
                if (Check(arr, b[i]) == false)
                {
                    arr[t] = b[i];
                    t++;
                    line += b[i];
                    line += " ";
                }
            }
            return line;
        }

        bool Check(int[] arr, int k)

        {
            foreach (int i in arr)
            {
                if (i == k)
                    return true;
            }
            return false;
        }
    }*/

