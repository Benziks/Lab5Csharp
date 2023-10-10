using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class CargoInfo
    {
        private CargoInfo[] _cargoInfo;
        private CargoCarrier _cargoCarrier;

        public CargoInfo[] CargoOrder => _cargoInfo;

        public CargoCarrier CargoCarrier => _cargoCarrier;

        public CargoInfo(double cargoCapacity, double price, string city, string destination, double cargoWeight)
        {
            _cargoCarrier = new CargoCarrier(cargoCapacity, price, city, destination, cargoWeight);
        }

        public CargoInfo()
        {
            _cargoInfo = new CargoInfo[0];
        }

        public void AddOrder(CargoInfo cargoInfo)
        {
            Array.Resize(ref _cargoInfo, _cargoInfo.Length + 1);
            _cargoInfo[_cargoInfo.Length - 1] = cargoInfo;
        }

        public void DeleteOrder(int orderNumber)
        {
            if (orderNumber >= 0 && orderNumber < _cargoInfo.Length)
            {
                Array.Copy(_cargoInfo, orderNumber + 1, _cargoInfo, orderNumber, _cargoInfo.Length - orderNumber - 1);
                Array.Resize(ref _cargoInfo, _cargoInfo.Length - 1);
                Console.WriteLine($"Заказ с номером {orderNumber} успешно удален.");
            }

        }

        public void EditOrder(int orderNumber, double newCargoCapacity, double newPrice, string newCity, string newDestination, double newCargoWeight)
        {
            if (orderNumber >= 0 && orderNumber < _cargoInfo.Length)
            {
                _cargoInfo[orderNumber].CargoCarrier.CargoCapacity = newCargoCapacity;
                _cargoInfo[orderNumber].CargoCarrier.Price = newPrice;
                _cargoInfo[orderNumber].CargoCarrier.City = newCity;
                _cargoInfo[orderNumber].CargoCarrier.Destination = newDestination;
                _cargoInfo[orderNumber].CargoCarrier.CargoWeight = newCargoWeight;
                Console.WriteLine($"Заказ с номером {orderNumber} успешно изменен.");
            }
            else
            {
                throw new FormatException("Неверно указан индекс");
            }
        }

        public override string ToString()
        {
            return $"Вместимость груза: {_cargoCarrier.CargoCapacity} тонн;\nЦена: {_cargoCarrier.Price} долларов;\nГород: {_cargoCarrier.City};\nПолучатель: {_cargoCarrier.Destination};\nВес груза: {_cargoCarrier.CargoWeight} килограмм;";
        }
    }
}
