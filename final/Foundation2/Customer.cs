class Customer{
    private string name;
    private Address address;
    public Customer(string name, Address address){
        this.name = name;
        this.address = address;
    }

    public bool fromUSA(){
        if (this.address.isUSA() == true){
            return true;
        }
        return false;
    }

    public string getName(){
        return name;
    }

    public string getAddress(){
        return address.getAddress();
    }

}