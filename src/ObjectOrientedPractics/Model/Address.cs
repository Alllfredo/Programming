using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет адрес клиента, включая индекс, страну, город, улицу, здание и квартиру.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        /// <summary>
        /// Хранит индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Хранит страну.
        /// </summary>
        private string _country;

        /// <summary>
        /// Хранит город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Хранит улицу.
        /// </summary>
        private string _street;

        /// <summary>
        /// Хранит номер здания.
        /// </summary>
        private string _building;

        /// <summary>
        /// Хранит номер квартиры.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Событие при обновлении любого поля объекта <see cref="Address"/>.
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Возвращает и задает индекс. Значение должно быть в диапазоне от 100000 до 999999.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (_index != value)
                {
                    Validator.AssertOnPositiveValue(value, 100_000, 999_999, nameof(value));
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);  // Срабатывает событие при изменении
                }
            }
        }

        /// <summary>
        /// Возвращает и задает страну. Длина строки не должна превышать 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    Validator.AssertStringOnLength(value, 50, "Страна");
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);  // Срабатывает событие при изменении
                }
            }
        }

        /// <summary>
        /// Возвращает и задает город. Длина строки не должна превышать 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    Validator.AssertStringOnLength(value, 50, "Город");
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);  // Срабатывает событие при изменении
                }
            }
        }

        /// <summary>
        /// Возвращает и задает улицу. Длина строки не должна превышать 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                if (_street != value)
                {
                    Validator.AssertStringOnLength(value, 100, "Улица");
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);  // Срабатывает событие при изменении
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер здания. Длина строки не должна превышать 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                if (_building != value)
                {
                    Validator.AssertStringOnLength(value, 10, "Номер здания");
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);  // Срабатывает событие при изменении
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры. Длина строки не должна превышать 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                if (_apartment != value)
                {
                    Validator.AssertStringOnLength(value, -1, 10, "Квартира");
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);  // Срабатывает событие при изменении
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> с заданными параметрами.
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <param name="country">Страна</param>
        /// <param name="city">Город</param>
        /// <param name="street">Улица</param>
        /// <param name="building">Здание</param>
        /// <param name="apartment">Квартира</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создает копию объекта <see cref="Address"/>.
        /// </summary>
        /// <returns>Копия объекта в <see cref="object"/>.</returns>
        public object Clone()
        {
            return new Address(
                this.Index,
                this.Country,
                this.City,
                this.Street,
                this.Building,
                this.Apartment);
        }

        /// <summary>
        /// Проверяет равенство исходного объекта с передаваемым.
        /// </summary>
        /// <param name="other">Объект класса <see cref="Address"/>.</param>
        /// <returns>Возвращает булевое значение, равны ли объекты.</returns>
        public bool Equals(Address other)
        {
            if (other == null)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            var result = this.Index == other.Index;
            result &= this.Country == other.Country;
            result &= this.City == other.City;
            result &= this.Street == other.Street;
            result &= this.Building == other.Building;
            result &= this.Apartment == other.Apartment;
            return result;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> без параметров.
        /// </summary>
        public Address() { }
    }
}
