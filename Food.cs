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