class Cycling : Activity{
    private double speed;
    public Cycling(string date, int length, double speed) : base(date,length){
        type = "Cycling";
        this.speed = speed;
    }
    public override double getDistance()
    {
        return speed / 60 * length;
    }
    public override double getPace()
    {
        return 60 / speed;
    }
    public override double getSpeed()
    {
        return speed;
    }
}