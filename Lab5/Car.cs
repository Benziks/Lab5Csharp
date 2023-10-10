using System;

namespace Lab5
{
    internal class Car : CargoInfo
    {
        private string _model;
        private double _fuel;
        private double _speed;
        private const byte MIN_FUEL = 0;
        private const byte MIN_SPEED = 0;
       
        
        public string Model
        {
            get { return _model; }
            set {
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
        
        public double Fuel 
        { 
            get { return _fuel; }
            set {
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
