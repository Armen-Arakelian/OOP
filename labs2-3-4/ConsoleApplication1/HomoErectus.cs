using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HomoErectus : HomoHabilis, Eating
{

    public HomoErectus(int age, double mass, String sex) : base(age, mass, sex)
    {

    }

    override public void eat(Food food)
    {
        if (food.getEatable())
            Console.WriteLine(" Trying coocking... Om nom nom...");
    }

    public String makingFire()
    {
        Console.WriteLine("PSHHHHHH (makinng fire)");
        return "Warm and light";
    }

    public void Speaking()
    {
        Console.WriteLine("bla bla bla");
    }

    public String hunting()
    {
        return "food";
    }
}