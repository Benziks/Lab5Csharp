﻿using System;

namespace Lab5
{
    /// <summary>
    /// Класс Train, содержит свойства Car, а также наследует свойства класса Orders
    /// </summary>
    internal class Car : Orders
    {
        private string _model;
        private double _fuel;
        private double _speed;
        private const byte MIN_FUEL = 0;
        private const byte MIN_SPEED = 0;


        /// <summary>
        /// Установка и получение поля Model(Модель).
        /// Внутри происходит проверка на null, а так же на корректность написания модели.
        /// Если в моделе будет null, то это значит что допущена ошибка в составлении заказа, в таком случае покажет ошибку с конкретным текстом.
        /// В обратном случае выведет город с удаленными пробелами(_model = value.Trim();).
        /// </summary>
        public string Model
        {
            get { return _model; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _model = value.Trim();
                }

                else
                {
                    throw new FormatException("Неверная модель машины");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля Fuel(Топливо).
        /// Внутри происходит проверка на минимальное кол-во топливо у машины.
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
        /// Внутри происходит проверка на скорость у машины.
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
        /// Создает новый экземпляр класса Car и наследует свойства Orders.
        /// </summary>
        /// <param name="cargoCapacity">Вместимость груза</param>
        /// <param name="price">Цена</param>
        /// <param name="city">Город</param>
        /// <param name="destination">Адресат</param>
        /// <param name="cargoWeight">Вес груза</param>
        /// <param name="flightRange">Дальность полета</param>
        /// <param name="fuel">Топливо</param>
        /// <param name="speed">Скорость</param>
        public Car(double cargoCapacity, double price, string city, string destination, double cargoWeight, string model, double fuel, double speed) : base(cargoCapacity, price, city, destination, cargoWeight)
        {
            Model = model;
            Fuel = fuel;
            Speed = speed;
        }

        public override string ToString()
        {
            return "Машина:\n" + base.ToString() + $"\nМодель: {Model};\nКоличество топлива: {Fuel} литров;\nСкорость: {Speed} км\\ч;\n\n";
        }
    }
}
