class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven)
    {
        int result = ExpectedMinutesInOven() - minutesInOven;
        return result;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        return numberOfLayers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int numberOfMinutes)
    {
        int preparationTime = PreparationTimeInMinutes(numberOfLayers);
        return numberOfMinutes + preparationTime;
    }
}
