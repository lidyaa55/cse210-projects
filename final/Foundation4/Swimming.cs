class Swimming : Activity{
    private double laps;
    public Swimming(string date, int length, double laps) : base(date, length){
        type = "Swimming";
        this.laps = laps;
    }
    public override double getDistance()
    {
        return laps * 50 / 1000 * 0.62;
    }
    public override double getSpeed()
    {
        double distance = laps * 50 / 1000 * 0.62;
        return (distance / length) * 60;
    }
    public override double getPace()
    {
        return 60 / getSpeed();
    }
}