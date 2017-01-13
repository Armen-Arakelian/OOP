using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HomoNeanderthalensis : HomoErectus, Religion, Fight
{

    private HomoNeanderthalensis(int age, double mass, String sex) : base(age, mass, sex) // This class has private constuctor becouse
    {                                                                                     // HomoNeanderthalensis is a stoped branch of 
                                                                                          // evolution and it's not possible to create
    }                                                                                     // new members of HomoNeanderthalensis now.

    public HomoNeanderthalensis makingNewOne(int year, int age, double mass, String sex)
    {
        if(year <=-2000 && year>= -4000)
        {
            HomoNeanderthalensis human = new HomoNeanderthalensis(age, mass, sex);
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