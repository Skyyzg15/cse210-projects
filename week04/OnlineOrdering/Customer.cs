using System;
using System.Collections.Generic;

public class Customer 
{
    public string _name;
    public Address _address;

    public Customer(string name, Address address)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty.");
    }
}