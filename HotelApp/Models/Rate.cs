namespace HotelApp.Models
{
    public class Rate
    {
        public Rate(int amount, string currencyCode)
        {
            this.Amount = amount;
            this.CurrencyCode = currencyCode;
        }

        public int Amount { get; set; }

        public string CurrencyCode { get; set; }
    }
}
