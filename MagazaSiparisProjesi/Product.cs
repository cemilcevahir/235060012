using System;

namespace MagazaSiparisProjesi
{
    public class Product
    {
        public string Name { get; set; }
        
        // Stock can only be changed via methods (Encapsulation)
        public int StockQuantity { get; private set; } 

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                // Logic: Price cannot be negative
                if (value < 0)
                {
                    throw new ArgumentException("Product price cannot be negative.");
                }
                _price = value;
            }
        }

        public Product(string name, decimal price, int initialStock)
        {
            Name = name;
            Price = price;
            
            if (initialStock < 0) throw new ArgumentException("Stock cannot be negative.");
            StockQuantity = initialStock;
        }

        // Meaningful method to reduce stock
        public void ReduceStock(int amount)
        {
            if (amount > StockQuantity)
            {
                throw new InvalidOperationException("Not enough stock available.");
            }
            StockQuantity -= amount;
        }
    }
}
