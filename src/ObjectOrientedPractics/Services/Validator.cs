﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Выполняет провекрку данных
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что длинна строки меньше указанного значения
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <param name="propertyName"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertStringOnLength
            (string value, int maxLength, string propertyName)
        {
            if (value.Length < 0 || value.Length > maxLength)
                throw new ArgumentException(string.Format
                    ("{0} должен быть меньше {1} символов.", propertyName, maxLength));
        }


        /// <summary>
        ///  Проверяет, что значение находится в заданом диапозоне
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxValue"></param>
        /// <param name="propertyName"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, int maxValue, string propertyName)
        {
            if (value < 0 || value > maxValue)
            {
                throw new ArgumentException(string.Format
                    ("{0} должен быть в диапозоне от 0 до {1}.", propertyName, maxValue));
            }
        }
    }
}