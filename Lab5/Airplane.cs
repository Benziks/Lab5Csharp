using System;

namespace Lab5
{
    /// <summary>
    /// Класс Airplane, содержит свойства Airplane, а также наследует свойства класса Orders
    /// </summary>
    internal class Airplane : Orders
    {
        private double _flightRange;
        private double _fuel;
        private double _speed;
        private const byte MIN_FUEL = 0;
        private const byte MIN_SPEED = 0;
        private const byte MIN_FlightRange = 0;


        /// <summary>
        /// Установка и получение поля FlightRange(Дальность полета ).
        /// Внутри происходит проверка на минимальную дальность полета у самолета.
        /// Если значение меньше чем минимальное допустимое значение (MIN_FlightRange), то допущена ошибка в составлении заказа, в таком случае покажет ошибку с конкретным текстом.
        /// </summary>
        public double FlightRange
        {
            get { return _flightRange; }
            set
            {
                if (value >= MIN_FlightRange)
                {
                    _flightRange = value;
                }
                else
                {
                    throw new FormatException("Дальность полета не может быть с отрицательным значением");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля Fuel(Топливо).
        /// Внутри происходит проверка на минимальное кол-во топливо у самолета.
        /// Если значение меньше чем минимальное допустимое значение (MIN_FUEL), то допущена ошибка в составлении заказа, в таком случае покажет ошибку с конкретным текстом.
        /// </summary>
        public double Fuel
        {
            get { return _fuel; }
            set
            {
                if (value >= MIN_FUEL)
                {
                    _fuel = value;
                }
                else
                {
                    throw new FormatException("Топливо не может быть отрицательным");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля Speed(Скорость).
        /// Внутри происходит проверка на скорость у самолета.
        /// Если значение меньше чем минимальное допустимое значение (MIN_SPEED), то допущена ошибка в составлении заказа, в таком случае покажет ошибку с конкретным текстом.
        /// </summary>
        public double Speed
        {
            get { return _speed; }
            set
            {
                if (value >= MIN_SPEED)
                {
                    _speed = value;
                }
                else
                {
                    throw new FormatException("Скорость не может быть с минусовым значением");
                }
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса Airplane и наследует свойства Orders.
        /// </summary>
        /// <param name="cargoCapacity">Вместимость груза</param>
        /// <param name="price">Цена</param>
        /// <param name="city">Город</param>
        /// <param name="destination">Адресат</param>
        /// <param name="cargoWeight">Вес груза</param>
        /// <param name="flightRange">Дальность полета</param>
        /// <param name="fuel">Топливо</param>
        /// <param name="speed">Скорость</param>
        public Airplane(double cargoCapacity, double price, string city, string destination, double cargoWeight, double flightRange, double fuel, double speed) : base(cargoCapacity, price, city, destination, cargoWeight)
        {
            FlightRange = flightRange;
            Fuel = fuel;
            Speed = speed;
        }

        public override string ToString()
        {
            return "Самолет:\n" + base.ToString() + $"\nДальность полета: {FlightRange} километров;\nКоличество топлива: {Fuel} литров;\nСкорость: {Speed} км\\ч;\n\n";
        }
    }
}
