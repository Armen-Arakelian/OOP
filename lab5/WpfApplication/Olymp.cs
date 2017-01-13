using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication
{
    [Serializable]
    public class God
    {
        public string name { get; set; }
        public int ancientAge { get; set; }

        public God() { }

        public God(string name, int age)
        {
            this.name = name;
            this.ancientAge = age;
        }
    }

    [Serializable]
    public class Olymp
    {
        public int numOfGods;
        public List<God> gods;

        public Olymp() { }

        public Olymp(int numOfGods)
        {
            gods = new List<God>();
            this.numOfGods = numOfGods;
        }

        public void addGod(God god)
        {
            if (god != null)
            {
                gods.Add(god);
            }
        }
    }
}
