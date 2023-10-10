using System;

namespace Lab5
{
    /// <summary>
    /// Класс Train, содержит свойства Train, а также наследует свойства класса CargoInfo
    /// </summary>
    internal class Train : CargoInfo
    {
        private int _quantityOfCarriage;
        private string _model;
        private double _speed;
        private const byte MIN_SPEED = 0;
        private const byte MIN_QuantityOfCarriage = 0;

        /// <summary>
        /// Установка и получение поля _quantityOfCarriage, _model и _speed.
        /// </summary>
       
        public int QuantityOfCarriage
        {
            get { return _quantityOfCarriage; }
            set {
                if (value >= MIN_QuantityOfCarriage)
                {
                    _quantityOfCarriage = value;
                }
                else
                {
                    throw new FormatException("Количество вагонов не может быть отрицательным значением");
                }
            }
        }

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
                    throw new FormatException("Неверная модель поезда");
                }
            }
        }

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
        /// Создает новый экземпляр класса Train и наследует свойства CargoInfo.
        /// </summary>
        /// <param name="cargoCapacity">Вместимость груза</param>
        /// <param name="price">Цена</param>
        /// <param name="city">Город</param>
        /// <param name="destination">Адресат</param>
        /// <param name="cargoWeight">Вес груза</param>
        /// <param name="flightRange">Дальность полета</param>
        /// <param name="fuel">Топливо</param>
        /// <param name="speed">Скорость</param>
        public Train(double cargoCapacity, double price, string city, string destination, double cargoWeight, int quantityOfCarriage,string model, double speed) : base(cargoCapacity, price, city, destination, cargoWeight)
        {
            QuantityOfCarriage = quantityOfCarriage;
            Model = model;
            Speed = speed;
        }

        public override string ToString()
        {
            return "Поезд:\n" + base.ToString() + $"\nКоличество вагонов: {QuantityOfCarriage};\nМодель: {Model};\nСкорость: {Speed} км\\ч;\n\n";
        }
    }
}
