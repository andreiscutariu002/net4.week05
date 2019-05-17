namespace HotelApp.Models
{
    using System;
    using System.Collections.Generic;

    public class Hotel
    {
        public Hotel(string name, string city)
        {
            this.Name = name;
            this.City = city;

            this.Rooms = new List<Room>();
        }

        public string Name { get; set; }

        public string City { get; set; }

        public List<Room> Rooms { get; } // do not expose setter (is private). just from inside hotel class create a new instance of rooms list.

        public void AddRoom(Room room)
        {
            // code that validates data for Hotel class, should be inside the Hotel
            if (room.Adults == 0)
            {
                Console.WriteLine("## Every room should have at least an adult!");

                return;
            }

            this.Rooms.Add(room);
        }

        public void Print()
        {
            Console.WriteLine($"Hotel {this.Name}, City {this.City}");
        }

        public IList<Room> FindRoomsBelow(int amount)
        {
            var list = new List<Room>();

            foreach (var room in this.Rooms)
            {
                if (room.IsBelow(amount))
                {
                    list.Add(room);
                }
            }

            return list;
        }
    }
}
