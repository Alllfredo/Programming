﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    internal class PointsDiscount: IDiscount, IComparable<PointsDiscount>

    {
        private int _points;

        /// <summary>
        /// Получает количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                _points = value;
            }
        }

        /// <summary>
        /// Информация о накопительных баллах.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов.";
            }
        }

        /// <summary>
        /// Вычисляет максимальную скидку на основе накопленных баллов и стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров, на которые будет применяться скидка.</param>
        /// <returns>Максимальная скидка, которую можно применить.</returns>
        public double Calculate(List<Item> items)
        {
            double totalCost = items.Sum(item => item.Cost);
            double maxDiscount = Math.Min(totalCost * 0.3, Points);
            return Math.Min(maxDiscount, totalCost);
        }

        /// <summary>
        /// Применяет скидку к списку товаров и обновляет количество накопленных баллов.
        /// </summary>
        /// <param name="items">Список товаров, на которые будет применяться скидка.</param>
        /// <returns>Сумма примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            double totalCost = items.Sum(item => item.Cost);
            double maxDiscount = Math.Min(totalCost * 0.3, Points);
            Points -= (int)maxDiscount;
            return Math.Min(maxDiscount, totalCost);
        }

        /// <summary>
        /// Обновляет количество накопленных баллов на основе стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров, стоимость которых влияет на количество баллов.</param>
        public void Update(List<Item> items)
        {
            double totalCost = items.Sum(item => item.Cost);
            Points += (int)Math.Ceiling(totalCost * 0.1);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PointsDiscount"/> с нулевым количеством баллов.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }

        /// <summary>
        /// Сравнивает исходный объект с передаваемым.
        /// </summary>
        /// <param name="other">Объект класса <see cref="PointsDiscount"/>.</param>
        /// <returns>
        /// 0 - Если баллы равны;
        /// 1 - Если у исходного объекта баллов больше;
        /// -1 - Если у передаваемого объекта баллов больше.
        /// </returns>
        public int CompareTo(PointsDiscount other)
        {
            if (this.Points == other.Points)
            {
                return 0;
            }
            else if (this.Points > other.Points)
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