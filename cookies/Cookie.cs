public class Cookie {
    // atributes 

    private int _doughAmount;
    private string _friut;

    private bool _freeSugar;



    //constructor (real things)

    public Cookie(int doughAmount, string friut, bool freeSugar){
        _doughAmount = doughAmount;
        _friut=friut;
        _freeSugar=freeSugar;
    }


    //methods 
    public void Display(){
        Console.WriteLine(_doughAmount);
        Console.WriteLine(_friut);
        Console.WriteLine(_freeSugar);
        
    }

    public void otherFunction(){
        Console.WriteLine("I'm private");
    }

}
