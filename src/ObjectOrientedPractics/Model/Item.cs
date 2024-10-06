using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о товарах
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// счетсик-поле
        /// </summary>
        private static int _countId = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Название товара
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре
        /// </summary>
        private string _info;

        /// <summary>
        /// Информация о стоимости товара
        /// </summary>
        private double _cost;


        /// <summary>
        ///  Возвращает и задает название товара. Длина строки не больше 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }

        /// <summary>
        ///  Возвращает и задает информация о товаре. Длина строки не больше 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                Validator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. Длина строки не больше 1000 символов.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                Validator.AssertOnPositiveValue(value, 100_000, "Cost");
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор для всех объектов данного класса
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="info"></param>
        /// <param name="cost"></param>
        public Item(string name, string info, double cost)
        {
            _countId += 1;
            _id = _countId;
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
