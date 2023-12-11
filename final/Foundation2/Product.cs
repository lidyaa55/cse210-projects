using System.Data.Common;

class Product{
    private string name;
    private int id;
    private double price;
    private int quantity;

    public Product(string name, int id, double price, int quantity){
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public double getTotalPrice(){
        return price * quantity;
    }

    public string getName(){
        return name;
    }

    public int getId(){
        return id;
    }
}