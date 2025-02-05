using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private List<Product> products = new List<Product>();
    private int nextId = 1;

    public void AddProduct(string name, double price, int quantity)
    {
        Product newProduct = new Product(nextId++, name, price, quantity);
        products.Add(newProduct);
        Console.WriteLine("Product added successfully.");
    }

    public void RemoveProduct(int id)
    {
        var product = products.Find(p => p.Id == id);
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine("Product removed successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void ListProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products in inventory.");
            return;
        }

        Console.WriteLine("Products in Inventory:");
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
        }
    }

    public void ModifyProduct(int id, string newName, double newPrice, int newQuantity)
    {
        var product = products.Find(p => p.Id == id);
        if (product != null)
        {
            product.Name = newName;
            product.Price = newPrice;
            product.Quantity = newQuantity;
            Console.WriteLine("Product modified successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void SearchProduct(string name)
    {
        var matchingProducts = products.Where(p => p.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        if (matchingProducts.Count == 0)
        {
            Console.WriteLine("No matching products found.");
            return;
        }

        Console.WriteLine("Matching Products:");
        foreach (var product in matchingProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
        }
    }
}