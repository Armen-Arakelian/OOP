abstract public class AbstractHuman
{
    protected int age;
    protected double mass;

    abstract public void eat(Food food);
    abstract public void sleep();
}
public interface Fight
{
    void fight();
}

public interface Religion
{
    string makingReligion(string religion);
}

public interface Eat
{
    void eat(Food food);
}

