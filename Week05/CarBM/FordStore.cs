using System;
using System.Collections.Generic;
using System.Linq;
using CarBM.Interfaces;

namespace CarBM
{
    public class FordStore : IStore
    {
        public FordStore()
        {
            Name = "Ford";
        }

        private List<IVehicle> cars = new List<IVehicle>
        {
            new Car(new Producer("Ford"), "Focus"),
            new Car(new Producer("Ford"), "Mondeo"),
            new Car(new Producer("Ford"), "Fiesta"),
        };

        private List<IOrder> orders = new List<IOrder>();

        public string Name { get; }

        public void Enter(IPerson person)
        {
            throw new System.NotImplementedException();
        }

        public IOrder Buy(IPerson person, string carName)
        {
            var currentCar = FindCar(carName);

            if (currentCar == null)
            {
                return null;
            }

            var order = new Order
            {
                Vehicle = currentCar,
                DeliveryDate = DateTime.Now.AddDays(28),
                StoreName = this.Name
            };

            orders.Add(order);
            
            return order;
        }

        public void CancelOrder(IPerson person, IOrder order)
        {
            throw new System.NotImplementedException();

            // todo - find order

            order.Cancel();
        }

        private IVehicle FindCar(string carToFind)
        {
            foreach (var car in cars)
            {
                if (car.Name == carToFind)
                {
                    return car;
                }
            }

            return null;
        }
    }
}