using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    public class MyXmlSerializer
    {

        public void xmlSerialize()
        {
            God g1 = new God("Zevs", 342343467);
            God g2 = new God("Venera", 53453453);
            God g3 = new God("Upiter", 879798798);
            God g4 = new God("Aid", 353453);
            God g5 = new God("Appolon", 2342342);
            Olymp olymp = new Olymp(5);
            olymp.addGod(g1);
            olymp.addGod(g2);
            olymp.addGod(g3);
            olymp.addGod(g4);
            olymp.addGod(g5);

            XmlSerializer formatter = new XmlSerializer(typeof(Olymp));

            using (FileStream fs = new FileStream("C:\\Users\\ASA\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\ConsoleApplication1\\gods.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, olymp);
            }
        }

        public void xmlDeserialize()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Olymp));
            using (FileStream fs = new FileStream("C:\\Users\\ASA\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\ConsoleApplication1\\gods.xml", FileMode.OpenOrCreate))
            {
                Olymp newOlymp = (Olymp)formatter.Deserialize(fs);

                foreach (God god in newOlymp.gods)
                {
                    Console.WriteLine("name " + god.name + " " + "ancientAge " + god.ancientAge);
                }
            }
        }
    }

    public class MyBinarySerializer
    {

        public void binarySerialize()
        {
            God g1 = new God("Zevs", 342343467);
            God g2 = new God("Venera", 53453453);
            God g3 = new God("Upiter", 879798798);
            God g4 = new God("Aid", 353453);
            God g5 = new God("Appolon", 2342342);

            Olymp olymp = new Olymp(5);

            olymp.addGod(g1);
            olymp.addGod(g2);
            olymp.addGod(g3);
            olymp.addGod(g4);
            olymp.addGod(g5);

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("C:\\Users\\ASA\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\ConsoleApplication1\\gods.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, olymp);
            }
        }

        public void binaryDeserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("C:\\Users\\ASA\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\ConsoleApplication1\\gods.dat", FileMode.OpenOrCreate))
            {
                Olymp newOlymp = (Olymp)formatter.Deserialize(fs);

                if (newOlymp != null)
                {
                    foreach (God god in newOlymp.gods)
                    {
                        Console.WriteLine("name " + god.name + " " + "ancientAge " + god.ancientAge);
                    }
                }
            }
        }
    }

}
