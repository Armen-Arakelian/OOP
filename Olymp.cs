using System;

public class God_1
{
    public void startNewEra()
    {
        Console.WriteLine("It is time to start new era");
    }
}

public class God_2
{
    public void startNewEra()
    {
        Console.WriteLine("Really, it is...");
        NewEra newEra = new NewEra();
        newEra.startNewEra();
    }
}