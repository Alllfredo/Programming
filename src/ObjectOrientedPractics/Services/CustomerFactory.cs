using System;
using System.Collections.Generic;
using ObjectOrientedPractics;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Класс <c>CustomerFactory</c> служит для генерации случайных данных о клиентах.
    /// </summary>
    internal class CustomerFactory
    {
        /// <summary>
        /// Список возможных имен клиентов.
        /// </summary>
        private static readonly List<String> _firstName = new List<String>
        {
            "Иван", "Егор", "Герасим", "Павел", "Валентин", "Валерий",
            "Марк", "Антон", "Александр", "Константин"
        };

        /// <summary>
        /// Список возможных фамилий клиентов.
        /// </summary>
        private static readonly List<String> _lastName = new List<String>
        {
            "Давыдкин", "Боварин", "Коротков", "Берестов",
            "Загряжский", "Козаков", "Дрёмин", "Огарков", "Завразин"
        };

        /// <summary>
        /// Список возможных городов для адресов клиентов.
        /// </summary>
        private static readonly List<String> _addressCity = new List<String>
        {
            "Самара", "Октябрьский", "Волжский", "Орск", "Балашиха",
            "Нижний Тагил", "Сергиев Посад", "Новороссийск"
        };

        /// <summary>
        /// Список возможных улиц для адресов клиентов.
        /// </summary>
        private static readonly List<String> _addressStreey = new List<String>
        {
            "Дзержинского", "Белорусская", "Южная", "Комсомольская",
            "Радужная", "Спортивная", "Весенняя", "Чапаева"
        };

        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Генерирует случайного клиента с использованием заранее определенных
        /// имен, фамилий и адресов.
        /// </summary>
        /// <returns>
        /// Возвращает объект типа <see cref="Customer"/> с случайно сгенерированными
        /// данными (ФИО и адрес).
        /// </returns>
        public static Customer CustomerGenerate()
        {
            return new Customer(_firstName[random.Next(_firstName.Count)] +
                " " + _lastName[random.Next(_lastName.Count)],
                "г. " + _addressCity[random.Next(_addressCity.Count)] +
                ", ул. " + _addressStreey[random.Next(_addressStreey.Count)] +
                ", д " + Convert.ToString(random.Next(0,100)));
        }
    }
}
