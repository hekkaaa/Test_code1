﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEduc_all1_6
{
    public class Homework2
    {

        public static (int,int,int,int) Task1()
        {
            // Задание 1

            const int mainNumber = 876;
            int number1 = mainNumber / 100;
            int number3 = mainNumber % 10;
            int number2 = (mainNumber % 100) / 10;
            
            return (mainNumber, number1, number2, number3);
            
        }

        public static bool Task2(double x1, double y1)
        {
            // Задание 2

            const int R = 40;
            bool shot = Math.Pow(x1, 2) + Math.Pow(y1, 2) <= Math.Pow(R, 2);
            return shot;
        }

        public static (int, bool) Task3(int number)
        {
            // Задание 3

            if(number.ToString().Length > 3 || number.ToString().Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            int numberFirst = number / 100;
            int numberCenter = (number % 100) / 10;
            int numberLast = number % 10;
            bool result = numberCenter <= numberFirst && numberCenter > numberLast;
            return (number, result);
           
        }

        public static (int,int) Task4 (int mainNumber)
        {
            // Задание 4


            if (mainNumber.ToString().Length > 3 || mainNumber.ToString().Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Разделяем цифры по одному.
            int number3 = mainNumber % 10;
            int number2 = (mainNumber % 100) / 10;
            int number1 = mainNumber / 100;
            int result = number3 * 100 + number2 * 10 + number1;
            return (mainNumber, result);

        }

        public static (double,bool) Task5()
        {
            // Задание 5
            // В задании условия запроса от пользователя нет. По этому хардкод.
            const double number = 156.0;
            bool res = number == (int)number;
            // Цифру 123.0 double обрезает 0 на выводе до целого числа.
            // И к сожаления не получается как в задании. 
            return (number, res);
        }
    }
}
