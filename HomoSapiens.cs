using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HomoSapiens : HomoErectus, Fight, Eat
{

    public HomoSapiens(int age, double mass, String sex) : base(age, mass, sex)
    {

    }

    public string thinking()
    {
        Console.WriteLine("Hmmmmmm...");
        return "thougts";
    }

    override public void eat(Food food)
    {
        if (food.getEatable() && food.getEnergyValue() < 300)
        {
            Console.WriteLine("Coocking ", food.getName());
            Console.WriteLine("Set the table for ", food.getName());
            Console.WriteLine("Eating ", food.getName());
        }
    }

    public void fight()
    {
        Console.WriteLine("We are living in the peace");
    }
}