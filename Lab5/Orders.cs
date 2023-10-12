using System;
using System.Text.RegularExpressions;

namespace Lab5
{
    /// <summary>
    /// Класс Orders содержит общую информацию о грузоперевозчике.
    /// </summary>
    internal class Orders
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
        /// Установка и получение поля CargoCapacity(Вместимость груза).
        /// Внутри происходит проверка на допустимую\возможную вместимость груза определенного транспортного средства.
        /// Если вместимость груза меньше чем минимальное допустимое значение (MIN_CargoCapacity), то допущена ошибка в составлении заказа, в таком случае покажет ошибку с конкретным текстом.
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

        /// <summary>
        /// Установка и получение поля Price(Цена).
        /// Внутри происходит проверка на минимальную цену доставки определенного транспортного средства.
        /// Если цена меньше чем минимальное допустимое значение (MIN_Price), то допущена ошибка в составлении заказа, в таком случае покажет ошибку с конкретным текстом.
        /// </summary>
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

        /// <summary>
        /// Установка и получение поля City(Город).
        /// Внутри происходит проверка на null, а так же на корректность написания города.
        /// Если в городе будет написано, что-то помимо букв(stringCheck.IsMatch(value)), то это значит что допущена ошибка в составлении заказа, в таком случае покажет ошибку с конкретным текстом.
        /// В обратном случае выведет город с удаленными пробелами(_city = value.Trim();).
        /// </summary>
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

        /// <summary>
        /// Установка и получение поля Destination(Адресат).
        /// Внутри происходит проверка на null, а так же на корректность написания имени Адресата.
        /// Если в имени Адресата будет написано, что-то помимо букв(stringCheck.IsMatch(value)), то это значит, что допущена ошибка в составлении заказа, в таком случае покажет ошибку с конкретным текстом.
        /// В обратном случае выведет имя Адресата с удаленными пробелами(_destination = value.Trim();).
        /// </summary>
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

        /// <summary>
        /// Установка и получение поля CargoWeight(Вес груза).
        /// Внутри происходит проверка на минимальный вес груза у определенного транспортного средства.
        /// Если вес меньше чем минимальное допустимое значение (MIN_CargoWeight), то допущена ошибка в составлении заказа, в таком случае покажет ошибку с конкретным текстом.
        /// </summary>
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
        /// Создает новый экземпляр класса CargoCarrier.
        /// </summary>
        /// <param name="cargoCapacity">Вместимость груза</param>
        /// <param name="price">Цена</param>
        /// <param name="city">Город</param>
        /// <param name="destination">Адресат</param>
        /// <param name="cargoWeight">Вес груза</param>
        public Orders(double cargoCapacity, double price, string city, string destination, double cargoWeight)
        {
            CargoCapacity = cargoCapacity;
            Price = price;
            City = city;
            Destination = destination;
            CargoWeight = cargoWeight;
        }


        public override string ToString()
        {
            return $"Вместимость груза: {CargoCapacity} тонн;\nЦена: {Price} долларов;\nГород: {City};\nПолучатель: {Destination};\nВес груза: {CargoWeight} килограмм;";
        }
    }
}
