using System;

namespace AracKiralamaProjesi
{
    public class RentalContract
    {
        public Customer Renter { get; set; }
        public Vehicle RentedVehicle { get; set; }
        public int DurationDays { get; set; }

        public RentalContract(Customer renter, Vehicle vehicle)
        {
            Renter = renter;
            RentedVehicle = vehicle;
        }

        public decimal CalculateTotalCost(int days)
        {
            if (days < 1) 
            {
                throw new ArgumentException("Days must be at least 1.");
            }
            
            decimal priceMultiplier = 1.0m;
            
            // If driver is under 25, add 10% insurance fee
            if (Renter.Age < 25) 
            {
                priceMultiplier = 1.10m; 
            }

            DurationDays = days;
            
            // Update the car status
            RentedVehicle.MarkAsRented();

            return (RentedVehicle.DailyPrice * days) * priceMultiplier;
        }
    }
}
