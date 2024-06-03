using System;
namespace GroupEightAssignTwo
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Constructor holding product attributes
        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        // Method to increase stock
        public void IncreaseStock(int amount)
        {
            if (amount > 0)
            {
                Stock += amount;
            }
            else
            {
                Console.WriteLine("Increase amount must be greater than zero.");
            }
        }

        // Method to decrease stock
        public void DecreaseStock(int amount)
        {
            if (amount > 0 && amount <= Stock)
            {
                Stock -= amount;
            }
            else
            {
                Console.WriteLine("Decrease amount must be greater than zero and less than or equal to the current stock.");
            }
        }
    }
}

