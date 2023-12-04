class Product
{
    public string Name { get; }
    public int ProductId { get; }
    private decimal Price { get; }
    private int Quantity { get; }

    public Product(string name, int productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal CalculateTotalPrice()
    {
        return Price * Quantity;
    }
}


