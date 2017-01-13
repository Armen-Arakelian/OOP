abstract public class AbstractHuman
{
    protected int age;
    protected double mass;

    abstract public void eat(Food food);
    abstract public void sleep();
}

public interface Fighting  //interface "Fight" replaced by "Fighting"
{
    void fight();
}

public interface Religion   //interface "Eat" replaced by "Eating"
{
    string makingReligion(string religion);
}

public interface Eating
{
    void eat(Food food);
}

