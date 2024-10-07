using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics
{
    internal class ItemFactory
    {
        // Список названий товаров
        private static readonly List<string> _names = new List<string>
        {
            "Смартфон", "Ноутбук", "Клавиатура", "Наушники", "Мышь", 
            "Монитор", "Принтер", "Колонка", "Планшет", "Фотоаппарат"
        };

        // Генератор случайных чисел
        private static Random random = new Random();

        /// <summary>
        /// Генерация случайного товара
        /// </summary>
        /// <returns>Случайный товар типа Item</returns>
        public static Item ItemGenerate()
        {
            return new Item(_names[random.Next(_names.Count)], "",
                Math.Round(random.NextDouble() * 99_000 + 1_000, 2));
        }
    }
}

