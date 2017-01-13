using System;

public class NewEra
{
    static private int years = 0;

    public void passCentures()
    {
        while (true)
        {
            passOneCentury();
            if (years >= 2000)
            {
                startingNewEra();
                break;
            }
        }
    }

    Action startingNewEra = () =>
    {
        startNewEra();
    };

    private static void passOneCentury()
    {
        if (years >= 10000)
            years = 0;
        years += 100;
    }
    

    private static void startNewEra()
    {
        years = 0;
        Console.WriteLine("New Era");
    }
}

