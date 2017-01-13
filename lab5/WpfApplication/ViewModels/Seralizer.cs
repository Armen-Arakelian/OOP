using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WpfApplication
{

    class MyXmlSerializer
    {

        public void xmlSerialize(Olymp olymp)
        {

            XmlSerializer formatter = new XmlSerializer(typeof(Olymp));

            using (FileStream fs = new FileStream("C:\\Users\\ASA\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\ConsoleApplication1\\gods.xml", FileMode.Create))
            {
                formatter.Serialize(fs, olymp);
            }
        }
        public Olymp xmlDeserialize()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Olymp));

            using (FileStream fs = new FileStream("C:\\Users\\ASA\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\ConsoleApplication1\\gods.xml", FileMode.Open))
            {
                Olymp newOlymp = (Olymp)formatter.Deserialize(fs);

                foreach (God god in newOlymp.gods)
                {
                    Console.WriteLine("name " + god.name + " " + "ancientAge " + god.ancientAge);
                }
                return newOlymp;
            }
        }
    }

    public class BinarySerializer
    {
        public void BinarySerialize(Olymp olymp)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("C:\\Users\\ASA\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\ConsoleApplication1\\gods.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, olymp);

            }
        }

        public Olymp BinaryDesserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\ASA\\Documents\\Visual Studio 2015\\Projects\\ConsoleApplication1\\ConsoleApplication1\\gods.dat", FileMode.OpenOrCreate))
            {
                Olymp olymp = (Olymp)formatter.Deserialize(fs);

                foreach (God god in olymp.gods)
                {
                    Console.WriteLine("name " + god.name + " " + "ancientAge " + god.ancientAge);
                }
                return olymp;
            }
        }
    }
}
   
