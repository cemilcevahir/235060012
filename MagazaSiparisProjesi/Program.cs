using System;

namespace MagazaSiparisProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Online Store System Started...\n");

            try
            {
                // 1. Create Real-life Objects
                Product laptop = new Product("Gaming Laptop", 15000, 10); // 10 in stock
                Product mouse = new Product("Wireless Mouse", 500, 50);
                
                // Buyer with 20000 TL balance, joined in 2020
                Buyer myUser = new Buyer("AliVeli", 20000, new DateTime(2020, 1, 15));

                Console.WriteLine($"User: {myUser.Username} (Member for {myUser.MembershipYears} years)");
                Console.WriteLine($"Balance: {myUser.WalletBalance} TL\n");
                
                Console.WriteLine($"Product: {laptop.Name}, Price: {laptop.Price}, Stock: {laptop.StockQuantity}");

                // 2. Perform a Meaningful Task (Buying an item)
                Console.WriteLine("\n--- Processing Order 1 ---");
                Order order1 = new Order(myUser, laptop, 1); // Buying 1 Laptop
                order1.ProcessOrder(); // Real Logic happens here

                // Check updates
                Console.WriteLine($"New Stock for Laptop: {laptop.StockQuantity}");

                // 3. Try to buy something expensive (Validation Test)
                Console.WriteLine("\n--- Processing Order 2 (Buying 2nd Laptop) ---");
                Order order2 = new Order(myUser, laptop, 1); 
                // This might fail if balance is too low after first purchase, or succeed if enough money.
                order2.ProcessOrder(); 

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Transaction Failed: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
