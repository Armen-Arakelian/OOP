using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



public class HomoSapiens : HomoErectus, Fighting, Eating, IComparable<HomoSapiens>
{

    double soshialSkills;
    Race race;

    static List<HomoSapiens> developed = new List<HomoSapiens>();

    public HomoSapiens(int age, double mass, String sex, double soshialSkills, Race race) : base(age, mass, sex)
    {
        this.soshialSkills = soshialSkills;
        if (soshialSkills >= 50)
            developed.Add(this);
        this.race = race;
    }

    public static void showDevelopedPeople()
    {
        foreach (var i in developed)
        {
            Console.WriteLine("person with soshialskills = " + i.soshialSkills);
        }
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

    public Func<double, string> Comunicatable = (soshialSkills) =>
      {
          if (soshialSkills >= 50)
              return "enought to live in society";
          else
              return "need more comuniation";
      };

    public void fight()
    {
        Console.WriteLine("We are living in the peace");
    }

    public int CompareTo(HomoSapiens obj)
    {
        if (this.age > obj.age)
            return 1;
        else
            if (this.age < obj.age)
            return -1;
        else
            return 0;
    }
    public Race getRace()
    {
        return race;
    }
    public double getSoshialSkills()
    {
        return soshialSkills;
    }
}