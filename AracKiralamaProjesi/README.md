# Car Rental Console Application

This is a simple C# console application to manage car rentals. I created this project to practice Object-Oriented Programming concepts like classes, properties, and encapsulation.

## How it works

The project has 3 main classes, each in its own file:

### 1. Vehicle.cs
This class represents the cars in the system. 
- I added a check in the DailyPrice property. If someone tries to set a negative price, the program throws an error. This ensures the data makes sense.
- The IsRented property is protected. It can't be changed directly from the main program; it only changes when the MarkAsRented() method is called.

### 2. Customer.cs
This class stores customer info.
- Instead of asking for Age directly, I store the BirthDate.
- The Age property calculates the age automatically using DateTime.Today. This meets the requirement of using meaningful properties.

### 3. RentalContract.cs
This class handles the logic. It connects a Customer and a Vehicle.
- The CalculateTotalCost method takes the number of days and calculates the price.
- It also checks the driver's age. If the customer is younger than 25, it adds 10% extra to the total price (simulating young driver insurance).
- When calculation is done, it marks the car as 'Rented'.

## How to Run
1. Open the project folder.
2. Run dotnet run in the terminal or start it via Visual Studio.
