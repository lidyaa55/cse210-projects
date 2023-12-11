class Running : Activity{
    private double distance;
    public Running(string date, int length, double distance) : base(date, length){
        type = "Running";
        this.distance = distance;
    }
    public override double getSpeed()
    {
        return (distance / length) * 0.62;
    }
    public override double getPace()
    {
        return length / distance;
    }

    public override double getDistance()
    {
        return distance;
    }
}