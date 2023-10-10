using System;

namespace Lab5
{
    internal class Train : CargoInfo
    {
        private int _quantityOfCarriage;
        private string _model;
        private double _speed;
        private const byte MIN_SPEED = 0;
        private const byte MIN_QuantityOfCarriage = 0;
        

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
