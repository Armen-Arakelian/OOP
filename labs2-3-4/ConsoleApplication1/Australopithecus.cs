using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Australopithecus : AbstractHuman,  Fighting, Eating
{
    private static long population = 11;


    protected String brains;
    protected String sex;

    public Australopithecus()
    {

    }

    static Australopithecus() 
    {
        population = 2;
    }

    public Australopithecus(int _age, double _mass, String sex) 
    {
        age = _age;
        mass = _mass;
        brains = "Nan";
        this.sex = sex;

    }

    public double massInFunts
    {
        get { return mass / 0.4; }
        set
        {
             mass = value * 0.4; 
        }
    }

    private static void throwPopulationExeption()
    {
        MyExceptionArgs args = new MyExceptionArgs("It's enought of you");
        throw new MyException(args);
    }

    public static void multiply()
    {
        const int maxPopulation = 10000;
        population = (long)Math.Pow(population, 2);
        if(population > maxPopulation) // magic constant replaced by const "maxPopulation"
        {
            throwPopulationExeption();
        }
    }


    override public void eat(Food food)
    {
        if (food.getEatable())
            Console.WriteLine("Om nom nom...");
    }

    private int iterate(int i)
    {
        i++;
        return i;
    }

    public int grow()
    {
        return iterate(age);
    }

    public int getAge()
    {
        return age;
    }

    public double getMass()
    {
        return mass;
    }

    public String getBrains()
    {
        return brains;
    }

    public String getSex()
    {
        return sex;
    }


    public void makingSounds()
    {
        Console.WriteLine("eeeeeeeee...");
    }

    override public void sleep()
    {

        Console.WriteLine("zzz..");
    }

    public void fight()
    {
        Console.WriteLine("UUUUUU UuU UU");
    }
}
