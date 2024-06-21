using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class InventoryItem
    {
        // Properties
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        // Constructor
        public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
        {
            
            ItemName = itemName;
            ItemId = itemId;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        // Methods

        // Update the price of the item
        public void UpdatePrice(double newPrice)
        {
            // Update the item's price with the new price
            Price = newPrice;
        }

        // Restock the item
        public void RestockItem(int additionalQuantity)
        {
            // Increase the item's stock quantity by the additional quantity
            QuantityInStock += additionalQuantity;
        }

        // Sell an item
        public void SellItem(int quantitySold)
        {
            // Decrease the item's stock quantity by the quantity sold
            // Make sure the stock doesn't go negative
            if (QuantityInStock >= quantitySold)
            {
                QuantityInStock -= quantitySold;
            }
            else
            {
                Console.WriteLine("Not enough stock to sell.");
            }
        }

        // Check if an item is in stock
        public bool IsInStock()
        {
            // Return true if the item is in stock (quantity > 0), otherwise false
            return QuantityInStock > 0;
        }

        // Print item details
        public void PrintDetails()
        {
            // Print the details of the item (name, id, price, and stock quantity)
            Console.WriteLine($"Item Name: {ItemName}");
            Console.WriteLine($"Item ID: {ItemId}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
        }
    }
}
