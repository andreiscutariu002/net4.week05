using System;

namespace CarBM.Interfaces
{
    public interface IOrder
    {
        string RefNumber { get; set; }

        string StoreName { get; set; }

        IVehicle Vehicle { get; set; }

        DateTime DeliveryDate { get; set; }

        void Cancel();
    }
}