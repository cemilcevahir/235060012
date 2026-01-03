using System;

namespace AracKiralamaProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Rental App Started...\n");
            
            try
            {
                // Creating sample objects
                Vehicle car1 = new Vehicle("Toyota", "Corolla", 1000);
                Vehicle car2 = new Vehicle("BMW", "320i", 2500);

                // Customer 1 is older than 25
                Customer c1 = new Customer("Ahmet Yilmaz", "E-12345", new DateTime(1990, 5, 20));
                
                // Customer 2 is younger (will trigger extra fee)
                Customer c2 = new Customer("Ayse Demir", "B-98765", new DateTime(2005, 1, 1)); 

                Console.WriteLine($"Customer: {c1.FullName} (Age: {c1.Age})");
                Console.WriteLine($"Car: {car1.Brand} {car1.Model} - {car1.DailyPrice} TL/Day");

                // Testing the contract logic
                RentalContract contract1 = new RentalContract(c1, car1);
                decimal cost1 = contract1.CalculateTotalCost(5); // 5 days

                Console.WriteLine($"Total Cost for 5 days: {cost1} TL");
                Console.WriteLine($"Car Rented Status: {car1.IsRented}");

                Console.WriteLine("\n----------------------------");
                Console.WriteLine("Testing Young Driver Fee:");
                
                RentalContract contract2 = new RentalContract(c2, car2);
                decimal cost2 = contract2.CalculateTotalCost(3); // 3 days
                
                Console.WriteLine($"Customer: {c2.FullName} (Age: {c2.Age})");
                Console.WriteLine($"Total Cost (with 10% fee): {cost2} TL");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to close.");
            Console.ReadKey();
        }
    }
}
