using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Australopithecus : AbstractHuman,  Fight, Eat
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

    public static void multiply()
    {
        population = (long)Math.Pow(population, 2);
        if(population > 10000)
        {
            MyExceptionArgs args = new MyExceptionArgs("It's enought of you");
            throw new MyException(args);
        }
    }

    override public void eat(Food food)
    {
        if (food.getEatable())
            Console.WriteLine("Om nom nom...");
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

    private int iterate(int i)
    {
        i++;
        return i;
    }

    public void fight()
    {
        Console.WriteLine("UUUUUU UuU UU");
    }
}
