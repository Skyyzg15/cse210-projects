using System;

class Program
{
    static void Main(string[] args)
    {
        var address = new Address("123 Main St", "Anytown", "CA", "USA");
        var customer = new Customer("John Doe", address);
        var order = new Order(customer);
        order.AddProduct(new Product(1,"Laptop", 1000, 1));
        order.AddProduct(new Product(2,"Mouse", 30, 2));
        order.Print();
    }
}