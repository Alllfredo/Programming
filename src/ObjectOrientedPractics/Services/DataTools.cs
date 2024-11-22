using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит логику по обработке данных.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Фильтрация товаров по заданному методу критерия.
        /// </summary>
        /// <param name="items">Список товаров <see cref="List{Item}"/>.</param>
        /// <param name="compare">Метод критерия <see cref="Predicate{Item}"/>.</param>
        /// <returns>Отфильтрованный список товаров.</returns>
        public static List<Item> FilterItems(List<Item> items, Predicate<Item> compare)
        {
            var filteredItems = new List<Item>();

            foreach (var item in items)
            {
                if (compare(item))
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        /// <summary>
        /// Сортировка товаров по заданному методу критерия.
        /// </summary>
        /// <param name="items">Список товаров <see cref="List{Item}"/>.</param>
        /// <param name="compare">Метод критерия <see cref="Comparison{Item}"/>.</param>
        /// <returns>Отсортированный список товаров.</returns>
        public static List<Item> SortItems(List<Item> items, Comparison<Item> compare)
        {
            var sortedItems = new List<Item>(items);
            sortedItems.Sort(compare); // Используем стандартный метод Sort с Comparison<Item>

            return sortedItems;
        }
    }
}
