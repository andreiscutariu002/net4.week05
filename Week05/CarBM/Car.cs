using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBM.Interfaces;

namespace CarBM
{
    public class Car : IVehicle
    {
        public Car(IProducer producer, string name)
        {
            Producer = producer;
            Name = name;
        }

        public IProducer Producer { get; }

        public string Name { get; }
    }
}
