using CarBM;

namespace CarBusinessModel
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var store = new FordStore();

            var client = new Client("Andrei");

            store.Enter(client);

            var order = store.Buy(client, "Focus");
            store.CancelOrder(client, order);
        }
    }
}