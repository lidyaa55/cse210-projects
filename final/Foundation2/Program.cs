
class Program
{
    static void Main()
    {
        // Example usage
        Address address = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer customer = new Customer("John Doe", address);

        List<Product> products = new List<Product>
        {
            new Product("Product1", 1, 10.99m, 2),
            new Product("Product2", 2, 5.99m, 3)
        };

        Order order = new Order(products, customer);

        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
        Console.WriteLine($"Is Customer in USA? {order.Customer.IsInUSA()}");
        Console.WriteLine($"Formatted Address: {order.Customer.CustomerAddress.GetFormattedAddress()}");
    }
}
