using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using Intelect;

[Flags]
public enum Race : byte
{
    Negroid,
    Caucasion,
    Mongoloid,
    Multiracial = Negroid | Caucasion | Mongoloid
}

namespace ConsoleApplication1
{



    class Program
    {
        static void Main(string[] args)
        {
            NewEra newEra = new NewEra();



            newEra.passCentures();

            HomoSapiens h1 = new HomoSapiens(30, 242, "eg", 55, Race.Negroid);
            HomoSapiens h2 = new HomoSapiens(312, 242, "eg", 60, Race.Mongoloid);
            HomoSapiens h3 = new HomoSapiens(50, 242, "eg", 60, Race.Caucasion);
            HomoSapiens h4 = new HomoSapiens(50, 242, "eg", 60, Race.Negroid | Race.Mongoloid | Race.Caucasion);
            Console.WriteLine((Race.Negroid | Race.Caucasion | Race.Mongoloid).ToString() == Race.Multiracial.ToString());
            HomoSapiens.showDevelopedPeople();

            Console.WriteLine("Intelect: " + h1.getIntelect());
            Console.WriteLine("My Collection");
            MyCollection people = new MyCollection();
            people.add(h1);
            people.add(h2);
            people.add(h3);
            people.sortByAge();
            people.show();


            try
            {
                for (int i = 0; i < 4; i++)
                    Australopithecus.multiply();
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Args.Message);
            }

            Console.WriteLine("");
            Console.WriteLine("Xml serialization");
            Console.WriteLine("");

            MyXmlSerializer serializer = new MyXmlSerializer();
            serializer.xmlSerialize();
            serializer.xmlDeserialize();

            Console.WriteLine("");
            Console.WriteLine("Binary serialization");
            Console.WriteLine("");

            MyBinarySerializer binSerializer = new MyBinarySerializer();
            binSerializer.binarySerialize();
            binSerializer.binaryDeserialize();

            Console.WriteLine("GC start");
            Console.WriteLine("before garbage collection: " + GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("after garbage collection: " + GC.GetTotalMemory(true));
            HomoSapiens human1 = new HomoSapiens(30, 242, "eg", 55, Race.Negroid);
            HomoSapiens human2 = new HomoSapiens(312, 242, "eg", 60, Race.Mongoloid);
            HomoSapiens human3 = new HomoSapiens(50, 242, "eg", 60, Race.Caucasion);
            WeakReference wr = new WeakReference(new HomoSapiens(50, 242, "eg", 60, Race.Caucasion));

            human1 = null;
            human2 = null;

            Console.WriteLine("before garbage collection: " + GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("after garbage collection: " + GC.GetTotalMemory(true));

            Console.WriteLine("before garbage collection: " + GC.GetTotalMemory(false));
            Meat meat = new Meat("meat", 5);
            meat.Dispose();
            Console.WriteLine("after garbage collection: " + GC.GetTotalMemory(true));

            Console.WriteLine("GC end");

            Console.ReadKey();
        }
    }
}
