using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HomoHabilis : Australopithecus
{
    HomoHabilis[] people = new HomoHabilis[100];
        //deleted unused variable countPeople

    public HomoHabilis(int age, double mass, String sex) : base(age, mass, sex)
    {

    }
    public void makingPrimitiveDevices()
    {
        Console.WriteLine("Making primitive devices...");
    }

    public void trySpeaking()
    {
        Console.WriteLine("eeee ee eee");
    }


}