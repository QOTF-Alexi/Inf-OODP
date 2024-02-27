class CarFactory
{
    private int Limited;
    
    public CarFactory(int limitedAmount)
    {
        Limited = limitedAmount;
    }

    public LimitedEditionCar ProduceLimitedEditionCar()
    {
        return LimitedEditionCar.Counter < Limited ? new LimitedEditionCar() : null;
    }
}