using Inventory;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Print details of all items
        Console.WriteLine("Initial Inventory:");
        item1.PrintDetails();
        Console.WriteLine();
        item2.PrintDetails();
        Console.WriteLine();

        // Sell some items and then print the updated details
        Console.WriteLine("Selling 3 Laptops:");
        item1.SellItem(3);
        item1.PrintDetails();
        Console.WriteLine();

        // Restock an item and print the updated details
        Console.WriteLine("Restocking 5 Smartphones:");
        item2.RestockItem(5);
        item2.PrintDetails();
        Console.WriteLine();

        // Check if an item is in stock and print a message accordingly
        Console.WriteLine("Checking stock status:");
        Console.WriteLine($"{item1.ItemName} is in stock: {item1.IsInStock()}");
        Console.WriteLine($"{item2.ItemName} is in stock: {item2.IsInStock()}");
    }
}