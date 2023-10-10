using System;
using System.Text.RegularExpressions;


namespace Lab5
{
    /// <summary>
    /// Класс CargoCarrier содержит общую информацию о школе.
    /// </summary>
    internal class CargoCarrier
    {
        private double _cargoCapacity;
        private double _price;
        private string _city;
        private string _destination;
        private double _cargoWeight;
        private const byte MIN_CargoCapacity = 0;
        private const byte MIN_Price = 1;
        private const byte MIN_CargoWeight = 0;
        private readonly Regex stringCheck = new Regex("[0-9@#$%^&*()_+={};':\",./<>?\\[\\]~`|\\\\-]");

        /// <summary>
        /// Установка и получение поля _cargoCapacity, _price и _city,_destination,_cargoWeight.
        /// </summary>

        public double CargoCapacity
        {
            get { return _cargoCapacity; }
            set
            {
                if (value >= MIN_CargoCapacity)
                {
                    _cargoCapacity = value;
                }
                else
                {
                    throw new FormatException("Вместимость груза не может быть отрицательной");
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= MIN_Price)
                {
                    _price = value;
                }
                else
                {
                    throw new FormatException("Цена не может быть равна 0 или меньше");
                }
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !stringCheck.IsMatch(value))
                {
                    _city = value.Trim();
                }

                else
                {
                    throw new FormatException("Неверное название города");
                }
            }
        }
        public string Destination
        {
            get { return _destination; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !stringCheck.IsMatch(value))
                {
                    _destination = value.Trim();
                }

                else
                {
                    throw new FormatException("Неверное имя получателя");
                }
            }
        }

        public double CargoWeight
        {
            get { return _cargoWeight; }
            set
            {
                if (value >= MIN_CargoWeight)
                {
                    _cargoWeight = value;
                }
                else
                {
                    throw new FormatException("Вес не может быть меньше 0");
                }
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса Airplane и наследует свойства CargoInfo.
        /// </summary>
        /// <param name="cargoCapacity">Вместимость груза</param>
        /// <param name="price">Цена</param>
        /// <param name="city">Город</param>
        /// <param name="destination">Адресат</param>
        /// <param name="cargoWeight">Вес груза</param>
       
        public CargoCarrier(double cargoCapacity, double price, string city, string destination, double cargoWeight)
        {
            CargoCapacity = cargoCapacity;
            Price = price;
            City = city;
            Destination = destination;
            CargoWeight = cargoWeight;
        }

    }
}
