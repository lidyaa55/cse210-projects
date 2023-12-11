
class Activity{
    protected string date;
    protected int length;
    protected string type;
    public Activity(string date, int length){
        this.date = date;
        this.length = length;
    }
    public void getSunmmary(){
        Console.WriteLine($"{date} {type} ({length} min) - Distance: {getDistance():0.0} miles , Speed {getSpeed():0.0} mph, Pace: {getPace():0.0} min per mile");
    }
    public virtual double getDistance(){
        return 0.0;
    }

    public virtual double getSpeed(){
        return 0.0;
    }

    public virtual double getPace(){
        return 0.0;
    }
}
