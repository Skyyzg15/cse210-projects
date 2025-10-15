using System;

class Product
{
    public string _productName;
    public int _productId;
    public int _price;
    public int _quantity;

    public Product(string productName, int productId, int price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
}