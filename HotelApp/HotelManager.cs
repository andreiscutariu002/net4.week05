namespace HotelApp
{
    using System;
    using System.Collections.Generic;
    using Models;
    using Polymorphism01;

    public class HotelManager
    {
        private readonly ILogger log;
        private readonly List<Hotel> hotels;

        public HotelManager(ILogger log)
        {
            this.log = log;
            this.hotels = new List<Hotel>();
        }

        public void AddHotel(Hotel hotel1)
        {
            this.hotels.Add(hotel1);
        }

        public void DeleteHotelFromCity(string name, string city)
        {
            Hotel hotelToRemove = null;

            foreach (var hotel in this.hotels)
            {
                if (hotel.Name == name && hotel.City == city)
                {
                    var msg = $"Delete hotel {name} from {city}.";
                    this.log.Log(msg);

                    hotelToRemove = hotel;

                    break;
                }
            }

            if (hotelToRemove != null)
            {
                this.hotels.Remove(hotelToRemove);
            }
        }

        public void PrintHotels()
        {
            foreach (var hotel in this.hotels)
            {
                hotel.Print();
            }

            Console.WriteLine();
        }

        public void ShowRoomsBelow(int amount)
        {
            foreach (var hotel in this.hotels)
            {
                var rooms = hotel.FindRoomsBelow(amount);

                foreach (var room in rooms)
                {
                    Console.WriteLine("Find a room:");
                    hotel.Print();
                    room.Print();
                    Console.WriteLine();
                }
            }
        }
    }
}
