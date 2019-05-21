using CarBM.Interfaces;

namespace CarBM
{
    public class Producer : IProducer
    {
        public Producer(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}