using System;

namespace MagazaSiparisProjesi
{
    public class Order
    {
        public Buyer Customer { get; set; }
        public Product Item { get; set; }
        public int Quantity { get; set; }

        public Order(Buyer customer, Product item, int quantity)
        {
            Customer = customer;
            Item = item;
            Quantity = quantity;
        }

        // Meaningful Task: Processes the transaction
        public void ProcessOrder()
        {
            if (Quantity <= 0)
            {
                throw new ArgumentException("Order quantity must be at least 1.");
            }

            decimal totalCost = Item.Price * Quantity;

            // Business Logic: Check balance
            if (Customer.WalletBalance < totalCost)
            {
                throw new InvalidOperationException("Insufficient funds in wallet.");
            }

            // Perform the actions
            Item.ReduceStock(Quantity);      // Decrease stock
            Customer.WalletBalance -= totalCost; // Deduct money

            Console.WriteLine($"Order Successful! Cost: {totalCost} TL. Remaining Balance: {Customer.WalletBalance} TL");
        }
    }
}
