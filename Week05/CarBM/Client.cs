using CarBM.Interfaces;

namespace CarBM
{
    public class Client : IPerson
    {
        public Client(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}