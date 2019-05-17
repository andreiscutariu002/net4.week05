namespace HotelApp.Models
{
    using System;

    public class Room
    {
        public Room(int number, int adults, int children, Rate rate)
        {
            this.Number = number;
            this.Adults = adults;
            this.Children = children;
            this.Rate = rate;
        }

        public int Number { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public Rate Rate { get; set; }

        public void Print()
        {
            Console.WriteLine($"Number {this.Number}, Adults: {this.Adults}, Children: {this.Children}, Amount {this.Rate.Amount} [{this.Rate.CurrencyCode}]");
        }

        public bool IsBelow(int amount)
        {
            if (this.Rate.Amount < amount)
            {
                return true;
            }

            return false;
        }
    }
}
