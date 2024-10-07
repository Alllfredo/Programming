using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ObjectOrientedPractics
{
    /// <summary>
    /// Хранит данные о клиентах
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// поле-счетчик
        /// </summary>
        private static int _countId;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса
        /// </summary>
        private int _id;

        /// <summary>
        /// ФИО
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адресс
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задает ФИО. Длина небольше 200 символов
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                Validator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адресс. Длина небольше 500 символов
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
        /// <summary>
        /// Возвращает уникальный идентификатор для всех объектов данного класса
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">ФИО, длина небольше 200 смиволов</param>
        /// <param name="address">Адресс, длина небольше 500 смиволов</param>
        public Customer(string fullname, Address address)
        {
            _countId += 1;
            _id = _countId;
            Fullname = fullname;
            Address = address;
        }
    }
}
