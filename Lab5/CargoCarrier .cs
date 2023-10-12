using System;
using System.Text.RegularExpressions;


namespace Lab5
{
    /// <summary>
    /// Класс CargoCarrier содержит общую информацию о грузоперевозчике, а так же содержит массив который хранит заказы.
    /// </summary>
    internal class CargoCarrier
    {
        private Orders[] _orders;

        public CargoCarrier()
        {
            _orders = new Orders[0];
        }

        /// <summary>
        /// Добавление объекта в массив.
        /// </summary>
        /// <param name="orders">Экземпляр класса CargoInfo или производных от него классов.</param>
        public void AddOrder(Orders orders)
        {
            Array.Resize(ref _orders, _orders.Length + 1);
            _orders[_orders.Length - 1] = orders;
        }

        /// <summary>
        /// Удаление объекта из массива.
        /// </summary>
        /// <param name="orderNumber">Индекс элемента который необходимо удалить.</param>
        public void DeleteOrder(int orderNumber)
        {
            if (orderNumber >= 0 && orderNumber < _orders.Length)
            {
                Array.Copy(_orders, orderNumber + 1, _orders, orderNumber, _orders.Length - orderNumber - 1);
                Array.Resize(ref _orders, _orders.Length - 1);
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
            if (orderNumber >= 0 && orderNumber < _orders.Length)
            {
                _orders[orderNumber].CargoCapacity = newCargoCapacity;
                _orders[orderNumber].Price = newPrice;
                _orders[orderNumber].City = newCity;
                _orders[orderNumber].Destination = newDestination;
                _orders[orderNumber].CargoWeight = newCargoWeight;
                Console.WriteLine($"Заказ с номером {orderNumber} успешно изменен.");
            }
            else
            {
                throw new FormatException("Неверно указан индекс");
            }
        }
        public Orders[] Orders => _orders;
    }
}
