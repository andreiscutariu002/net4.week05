using System;

namespace CarBM.Interfaces
{
    public interface IStore
    {
        string Name { get; }

        void Enter(IPerson person);

        IOrder Buy(IPerson person, string carName);

        void CancelOrder(IPerson person, IOrder order);
    }
}