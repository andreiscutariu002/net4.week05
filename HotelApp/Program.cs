namespace HotelApp
{
    using System;
    using Polymorphism01;

    public class Program
    {
        private static void Main(string[] args)
        {
            //ILogger log = new FileLogger("log.txt");
            ILogger log = new ConsoleLogger();

            var hotelCreator = new HotelCreator();
            var hotelManager = new HotelManager();

            // add hotels
            var hotel1 = hotelCreator.CreateAHotel();
            hotelManager.AddHotel(hotel1);

            log.Log($"Am citit hotel {hotel1.Name}");

            //var hotel2 = hotelCreator.CreateAHotel();
            //hotelManager.AddHotel(hotel2);

            //var hotel3 = hotelCreator.CreateAHotel();
            //hotelManager.AddHotel(hotel3);

            // delete hotel
            hotelManager.PrintHotels();
            hotelManager.DeleteHotelFromCity(hotel1.Name, hotel1.City);
            hotelManager.PrintHotels();

            log.Log("Am sters un hotel");

            // rooms below amount
            //Console.Write("Enter the min amount for rooms: ");
            //int amount = int.Parse(Console.ReadLine());
            //hotelManager.ShowRoomsBelow(amount);
        }
    }
}
