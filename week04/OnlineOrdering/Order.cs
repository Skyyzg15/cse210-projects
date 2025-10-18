using System;
using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; private set; }
    public Customer Customer { get; private set; }
    public Order(Customer customer)
    {
        Customer = customer ?? throw new ArgumentNullException(nameof(customer));
        Products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        Products.Add(product ?? throw new ArgumentNullException(nameof(product)));
    }

    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
    }

    public int TotalPrice => Products.Sum(p => p._quantity * p._price);
    public void Print()
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine(Customer.ToString());
        Console.WriteLine("Products:");
        foreach (var product in Products)
        {
            Console.WriteLine($"- ID: {product._productId}, {product._productName}:${product._price}x {product._quantity} = ${product._quantity * product._price}");
        }
        Console.WriteLine($"Total: ${TotalPrice}");
    }
}