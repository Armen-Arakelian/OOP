using System;
using System.Text;

public interface GenerateEnergy
{
    int generateEnergy();
}

public class Grass: GenerateEnergy
{
    string name;
    int energyValue;
    public Grass(string name, int energyValue)
    {
        this.name = name;
        this.energyValue = energyValue;
    }
    public int generateEnergy()
    {
        return energyValue;
    }
}

public class Meat : GenerateEnergy , IDisposable
{
    string name;
    int energyValue;
    private System.IO.StreamWriter _sw = null;
    private bool _disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }
        if (disposing)
        {
            Close();
        }
        _disposed = true;
    }

    public void Close()
    {
        _sw.Dispose();
    }

    public Meat(string name, int energyValue)
    {
        this.name = name;
        this.energyValue = 5 * energyValue;
        _sw = new System.IO.StreamWriter(energyValue + ".log", true, Encoding.UTF8);
    }

    public int generateEnergy()
    {
        return energyValue;
    }
}

public class Food
{

    string name;
    bool eatable;
    int energyValue;
    public Food(string name, bool eatable, int energyValue)
    {
        this.name = name;
        this.eatable = eatable;
        this.energyValue = energyValue;
    }

    public bool getEatable()
    {
        return eatable;
    }

    public string getName()
    {
        return name;
    }
    public int getEnergyValue()
    {
        return energyValue;
    }
}

public class OrganicMaterial<T> where T : GenerateEnergy
{
    public int generateEnergy(T food)
    {
        return food.generateEnergy();
    }
}