using System;

namespace Lab5
{
    internal class Airplane : CargoInfo
    {
        private double _flightRange;
        private double _fuel;
        private double _speed;
        private const byte MIN_FUEL = 0;
        private const byte MIN_SPEED = 0;
        private const byte MIN_FlightRange = 0;

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
