using System;

public class NewEra
{
    private int years = 0;

    public delegate void newEra();
    public event newEra startingNewEra;

    private void passOneCentury()
    {
        if (years >= 10000)
            years = 0;
        years += 100;
    }

    public void passingCenturys()
    {
        while (true)
        {
            passOneCentury();
            if (years >= 2000)
            {
                if (startingNewEra != null)
                    startingNewEra();
                years = 0;
                break;
            }
        }
    }

    public void startNewEra()
    {
        years = 0;
        Console.WriteLine("New Era");
    }
}