﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanovSI.Sprint4.Review.V5.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Review.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "246813579";
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Иванов С. И. | РПСб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задания #7                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил: Иванов Семён Иванович | РПСб-23-1                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 246813579. Преобразуйте ее             *");
            Console.WriteLine("* в матрицу 3 на 3 и подсчитайте кол-во четных чисел.                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(string.Format("{0,5}", mtrx[i, j] = int.Parse(str.Substring(i * colums + j, 1))));
                }
                Console.WriteLine(); 
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Кол-во всех чётных элементов матрици = " + ds.Calculate(rows, colums, str));



            Console.ReadKey();
        }
    }
}
