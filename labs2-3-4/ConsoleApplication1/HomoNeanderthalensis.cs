using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HomoNeanderthalensis : HomoErectus, Religion, Fighting
{
    public struct HomoNeanderthalensisStruct
    {
        public int age;
        public double mass;
        public String sex;
    } 
    // added struct HomoNeanderthalensisStruct to make less arguments in function "makingNewOne" 

    private HomoNeanderthalensis(int age, double mass, String sex) : base(age, mass, sex) 
    {                                                                                     
                                                                                          
    }                                                                                     // deleted old not valid now comment

    public HomoNeanderthalensis makingNewOne(int year, HomoNeanderthalensisStruct someHuman)
    {
        const int minYears = -4000;
        const int maxYears = -2000;
        if(year <=maxYears && year>= minYears) // magic constants replaced with constants
        {
            HomoNeanderthalensis human = new HomoNeanderthalensis(someHuman.age, someHuman.mass, someHuman.sex);
            return human;
        }
        return null;
    }

    public string primitiveComunication()
    {
        Console.WriteLine("Comunication...");
        return "Primitive society";
    }
    public string makingReligion(string religion)
    {
        Console.WriteLine("let " , religion , " be alive");
        Console.WriteLine("worship...");
        return "gods";
    }
    void fight()
    {
        Console.WriteLine("making primitive veapon then fighting");
    }
}