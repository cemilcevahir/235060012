using System;

namespace AracKiralamaProjesi
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool IsRented { get; private set; } // Can only be changed inside this class
        
        private decimal _dailyPrice;

        public decimal DailyPrice
        {
            get { return _dailyPrice; }
            set
            {
                // Simple validation to prevent negative prices
                if (value <= 0) 
                {
                    throw new ArgumentException("Price cannot be zero or negative.");
                }
                _dailyPrice = value;
            }
        }

        public Vehicle(string brand, string model, decimal dailyPrice)
        {
            Brand = brand;
            Model = model;
            DailyPrice = dailyPrice;
            IsRented = false;
        }

        // Method to change status
        public void MarkAsRented()
        {
            if (IsRented)
            {
                throw new InvalidOperationException("Car is already rented out.");
            }
            IsRented = true;
        }

        public void MarkAsAvailable()
        {
            IsRented = false;
        }
    }
}
