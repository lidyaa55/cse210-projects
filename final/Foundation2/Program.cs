using System;

class Program
{
    static void Main(string[] args)
    {
        Address michealAddress = new Address("1012 Longview Rd","Panem","TX","USA");
        Customer michealJackson = new Customer("Micheal Jackson",michealAddress);
        Order firstOrder = new Order(michealJackson);
        firstOrder.addProduct(new Product("Toilet Paper",1,2.99,4));
        firstOrder.addProduct(new Product("Soap",2,0.99,2));
        firstOrder.addProduct(new Product("Towel",3,4.99,1));
        Console.WriteLine("First Order:");
        firstOrder.packingLabel();
        firstOrder.shippingLabel();
        Console.WriteLine($"Total Price: ${firstOrder.getTotalPrice()}");
        Console.WriteLine();

        Address jamesAddress = new Address("323 Villas Del Sol","Michoacan","Mexico","MEX");
        Customer jamesMartinez = new Customer("James Martinez",jamesAddress);
        Order secondOrder = new Order(jamesMartinez);
        secondOrder.addProduct(new Product("Tortillas",1,1.99,1));
        secondOrder.addProduct(new Product("Oil",2,1.99,2));
        secondOrder.addProduct(new Product("Large pan",3,10.99,1));
        Console.WriteLine("Second Order:");
        secondOrder.packingLabel();
        secondOrder.shippingLabel();
        Console.WriteLine($"Total Price: ${secondOrder.getTotalPrice()}");
        Console.WriteLine();
    }
}
