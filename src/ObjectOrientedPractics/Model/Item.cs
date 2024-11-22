using System;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Счетчик для уникальных идентификаторов.
        /// </summary>
        private static int _countId = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private float _cost;

        public Category Category { get; set; }

        // События для изменений свойств
        public event EventHandler<EventArgs> NameChanged;
        public event EventHandler<EventArgs> InfoChanged;
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Возвращает и задает название товара. Длина строки не больше 200 символов.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringOnLength(value, 200, "Название товара");
                if (_name != value)  // Проверяем, изменилось ли значение
                {
                    _name = value;
                    NameChanged?.Invoke(this, EventArgs.Empty); // Вызываем событие при изменении
                }
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о товаре. Длина строки не больше 1000 символов.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                Validator.AssertStringOnLength(value, 1000, "Информация о товаре");
                if (_info != value)  // Проверяем, изменилось ли значение
                {
                    _info = value;
                    InfoChanged?.Invoke(this, EventArgs.Empty); // Вызываем событие при изменении
                }
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. Должна быть в пределах от 0 до 100 000.
        /// </summary>
        public float Cost
        {
            get { return _cost; }
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 100_000, "Цена");
                if (_cost != value)  // Проверяем, изменилось ли значение
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty); // Вызываем событие при изменении
                }
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, float cost, Category category)
        {
            _countId += 1;
            _id = _countId;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        public Item(int id)
        {
            _id = id;
        }

        /// <summary>
        /// Создает копию объекта <see cref="Item"/>.
        /// </summary>
        /// <returns>Копия объекта в <see cref="object"/>.</returns>
        public object Clone()
        {
            var item = new Item(this.Id);
            item.Name = this.Name;
            item.Info = this.Info;
            item.Cost = this.Cost;
            item.Category = this.Category;
            return item;
        }

        /// <summary>
        /// Проверяет равенство исходного объекта с передаваемым.
        /// </summary>
        /// <param name="other">Объект класса <see cref="Item"/>.</param>
        /// <returns>Возвращает булевое значение, равны ли объекты.</returns>
        public bool Equals(Item other)
        {
            if (other == null)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            return this.Id == other.Id;
        }

        /// <summary>
        /// Сравнивает исходный объект с передаваемым.
        /// </summary>
        /// <param name="other">Объект класса <see cref="Item"/>.</param>
        /// <returns>
        /// 0 - Если цены равны;
        /// 1 - Если у исходного объекта цена выше;
        /// -1 - Если у передаваемого объекта цена выше.
        /// </returns>
        public int CompareTo(Item other)
        {
            if (this.Cost == other.Cost)
            {
                return 0;
            }
            else if (this.Cost > other.Cost)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}

