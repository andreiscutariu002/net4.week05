namespace HotelApp
{
    using System;
    using Models;

    public class HotelCreator
    {
        public Hotel CreateAHotel()
        {
            Console.Write("Enter hotel name: ");
            var name = Console.ReadLine();

            Console.Write("Enter hotel city: ");
            var city = Console.ReadLine();

            Console.Write($"Enter number of rooms for {name}: ");
            var nr = int.Parse(Console.ReadLine());

            Hotel hotel = new Hotel(name, city);

            for (int i = 0; i < nr; i++)
            {
                var roomNumber = i;

                Console.Write($"Adults for room {roomNumber}: ");
                var adults = int.Parse(Console.ReadLine());

                Console.Write($"Children for room {roomNumber}: ");
                var children = int.Parse(Console.ReadLine());

                Console.Write($"Amount for room {roomNumber}: ");
                var amount = int.Parse(Console.ReadLine());

                var room = new Room(roomNumber, adults, children, new Rate(amount, "USD"));
                hotel.AddRoom(room);
            }

            Console.WriteLine();

            return hotel;
        }
    }
}