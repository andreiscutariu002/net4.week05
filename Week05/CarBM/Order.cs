using System;
using CarBM.Interfaces;

namespace CarBM
{
    public class Order : IOrder
    {
        public string RefNumber { get; set; }

        public string StoreName { get; set; }

        public IVehicle Vehicle { get; set; }

        public DateTime DeliveryDate { get; set; }

        public void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}