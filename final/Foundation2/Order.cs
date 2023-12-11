class Order{
    private List<Product> listOfProducts = new List<Product>();
    private Customer customer;
   
    private int shippingCost;

    public Order(Customer customer){
        this.customer = customer;

        if (this.customer.fromUSA() == true){
            shippingCost = 5;
        }
        else{
            shippingCost = 35;
        }
    }

    public void packingLabel(){
        foreach (Product product in listOfProducts){
            Console.WriteLine($"{product.getName()} - {product.getId()}");
        }
    }

    public void shippingLabel(){
        Console.WriteLine($"{customer.getName()} - {customer.getAddress()}");
    }

    public void addProduct(Product product){
        listOfProducts.Add(product);
    }

    public double getTotalPrice(){
        double totalCost = 0;
        foreach (Product product in listOfProducts){
            totalCost += product.getTotalPrice();
        }
        return totalCost+shippingCost;
    }
}