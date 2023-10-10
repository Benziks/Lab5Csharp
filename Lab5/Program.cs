using System;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Airplane airplane = new Airplane(5, 400, "New York", "Свиридов Илья", 200, 5200, 150000, 750);
            Airplane airplane2 = new Airplane(5, 400, "New Yorksss", "Верозуб Александр", 200, 5200, 150000, 750);
            Train train = new Train(5, 400, "New York", "Богаченко Максим", 200, 10, "Shinkansen N700", 320);
            Car car = new Car(5, 400, "New York", "Выходец Роман", 200, "Toyota Camry", 120, 60);
            Car car1 = new Car(5, 400, "New York", "Романюк Иван", 200, "Toyota Camry", 120, 60);


            CargoInfo cargoOrder = new CargoInfo();

            cargoOrder.AddOrder(airplane);
            cargoOrder.AddOrder(train);
            cargoOrder.AddOrder(airplane2);
            cargoOrder.AddOrder(car1);
            cargoOrder.AddOrder(car);

            foreach (var order in cargoOrder.CargoOrder)
            {
                Console.WriteLine(order);
            }

            Console.WriteLine("-----------------------------------------------------------");

            cargoOrder.DeleteOrder(2);
           
            foreach (var order in cargoOrder.CargoOrder)
            {
                Console.WriteLine(order);
            }


            Console.WriteLine("-----------------------------------------------------------");

            cargoOrder.AddOrder(airplane2);
            cargoOrder.AddOrder(car1);


            foreach (var order in cargoOrder.CargoOrder)
            {
                Console.WriteLine(order);
            }

            Console.WriteLine("-----------------------------------------------------------");
           
            cargoOrder.EditOrder(2, 10, 800, "Los Angeles", "Данил Табаков", 250);

            foreach (var order in cargoOrder.CargoOrder)
            {
                Console.WriteLine(order);
            }

            Console.ReadLine();

        }
    }
}
