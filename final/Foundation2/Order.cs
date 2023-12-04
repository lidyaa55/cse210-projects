
class Order
{
    public List<Product> Products { get; }
    public Customer Customer { get; }

    public Order(List<Product> products, Customer customer)
    {
        Products = products;
        Customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.CalculateTotalPrice();
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        // Implement packing label generation logic here
        return "Packing Label";
    }

    public string GetShippingLabel()
    {
        // Implement shipping label generation logic here
        return "Shipping Label";
    }
}
