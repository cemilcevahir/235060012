# Online Store Order System

I created this console application to simulate a simple e-commerce backend. The goal was to practice C# class design, encapsulation, and method interactions as requested in the final project guidelines.

## How it works

The project consists of 3 classes representing real-world objects:

### 1. Product.cs
Represents an item for sale.
- **Validation:** The Price property checks input. If a negative price is entered, it throws an error.
- **State Protection:** The StockQuantity cannot be changed directly from outside. It must be modified using the ReduceStock() method, which ensures we don't sell more items than we have.

### 2. Buyer.cs
Represents the customer.
- **Calculated Property:** Instead of manually updating a 'YearsOfMembership' variable, I used a read-only property MembershipYears. It calculates the value dynamically based on the MembershipDate and today's date.

### 3. Order.cs
Handles the transaction logic.
- It doesn't just print text; it actually modifies the other objects.
- ProcessOrder() checks if the user has enough money and if the product has enough stock.
- If everything is okay, it deducts money from the Buyer's wallet and decreases the Product's stock.

## Usage
Run the program to see a simulation of a user buying a laptop. The console will show the balance and stock updates in real-time.
