class Customer
{
    public string Name { get; }
    public Address CustomerAddress { get; }

    public Customer(string name, Address address)
    {
        Name = name;
        CustomerAddress = address;
    }

    public bool IsInUSA()
    {
        return CustomerAddress.IsInUSA();
    }
}

