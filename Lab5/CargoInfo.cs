using System;

namespace Lab5
{
    internal class CargoInfo
    {
        private CargoInfo[] _cargoInfo;
        private CargoCarrier _cargoCarrier;

        public CargoInfo[] CargoOrder => _cargoInfo;

        public CargoCarrier CargoCarrier => _cargoCarrier;

        /// <summary>
        /// Создает новый экземпляр класса CargoInfo и наследует свойства CargoCarrier.
        /// </summary>
        /// <param name="cargoCapacity">Вместимость груза</param>
        /// <param name="price">Цена</param>
        /// <param name="city">Город</param>
        /// <param name="destination">Адресат</param>
        /// <param name="cargoWeight">Вес груза</param>

        public CargoInfo(double cargoCapacity, double price, string city, string destination, double cargoWeight)
        {
            _cargoCarrier = new CargoCarrier(cargoCapacity, price, city, destination, cargoWeight);
        }

        public CargoInfo()
        {
            _cargoInfo = new CargoInfo[0];
        }

        /// <summary>
        /// Добавление объекта в массив.
        /// </summary>
        /// <param name="cargoInfo">Экземпляр класса CargoInfo или производных от него классов.</param>
        public void AddOrder(CargoInfo cargoInfo)
        {
            Array.Resize(ref _cargoInfo, _cargoInfo.Length + 1);
            _cargoInfo[_cargoInfo.Length - 1] = cargoInfo;
        }

        /// <summary>
        /// Удаление объекта из массива.
        /// </summary>
        /// <param name="orderNumber">Индекс элемента который необходимо удалить.</param>
        public void DeleteOrder(int orderNumber)
        {
            if (orderNumber >= 0 && orderNumber < _cargoInfo.Length)
            {
                Array.Copy(_cargoInfo, orderNumber + 1, _cargoInfo, orderNumber, _cargoInfo.Length - orderNumber - 1);
                Array.Resize(ref _cargoInfo, _cargoInfo.Length - 1);
                Console.WriteLine($"Заказ с номером {orderNumber} успешно удален.");
            }

        }

        /// <summary>
        /// Редактирование массива
        /// </summary>
        /// <param name="orderNumber">Индекс элемента который необходимо заменить.</param>
        /// <param name="newCargoCapacity">Новый элемент CargoCapacity.</param>
        /// <param name="newPrice">Новый элемент Price</param>
        /// <param name="newCity">Новый элемент City</param>
        /// <param name="newDestination">Новый элемент Destination</param>
        /// <param name="newCargoWeight">Новый элемент CargoWeight</param>
        /// <exception cref="FormatException"></exception>
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
