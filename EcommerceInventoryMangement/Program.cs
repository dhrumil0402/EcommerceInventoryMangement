using System;

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add a new product");
            Console.WriteLine("2. List all products");
            Console.WriteLine("3. Remove a product by ID");
            Console.WriteLine("4. Modify a product");
            Console.WriteLine("5. Search for a product");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter product price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter product quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    inventory.AddProduct(name, price, quantity);
                    break;

                case "2":
                    inventory.ListProducts();
                    break;

                case "3":
                    Console.Write("Enter product ID to remove: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    inventory.RemoveProduct(removeId);
                    break;

                case "4":
                    Console.Write("Enter product ID to modify: ");
                    int modifyId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter new product name: ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter new product price: ");
                    double newPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter new product quantity: ");
                    int newQuantity = Convert.ToInt32(Console.ReadLine());
                    inventory.ModifyProduct(modifyId, newName, newPrice, newQuantity);
                    break;

                case "5":
                    Console.Write("Enter product name to search: ");
                    string searchName = Console.ReadLine();
                    inventory.SearchProduct(searchName);
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}