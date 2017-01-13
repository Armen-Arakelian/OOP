using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApplication1
{
    class MyCollection : IEnumerable
    {
        class myCollectionEnumerator : IEnumerator
        {
            private int position = -1;
            private MyCollection humans;

            public myCollectionEnumerator(MyCollection humans)
            {
                this.humans = humans;
            }

            public bool MoveNext()
            {
                if (position < humans.humans.Count - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }

            public object Current
            {
                get
                {
                    return humans.humans[position];
                }
            }
        }

        public List<HomoSapiens> humans;

        public MyCollection()
        {
            humans = new List<HomoSapiens>();
        }


        public void add(HomoSapiens human)
        {
            if(human != null)
                humans.Add(human);
        }

        public HomoSapiens remove(HomoSapiens human)
        {
            if(human != null)
                humans.Remove(human);
            return human;
        }

        private HomoSapiens getHomoSapiens(double soshialSkills)
        {
            foreach (var h in humans)
            {
                if (h.getSoshialSkills() == soshialSkills)
                    return h;
            }
            return null;
        }

        public HomoSapiens this[double soshialSkills]
        {
            get { return getHomoSapiens(soshialSkills); }
            set { add(value); }
        }

        public IEnumerator GetEnumerator()
        {
            return new myCollectionEnumerator(this);
        }

        public void sortByAge()
        {
            humans.Sort();
        }

        public void show()
        {
            foreach(var human in humans)
            {
                Console.WriteLine("Human, age:" + human.getAge());
            }
        }

    }


}
// all "elements" - name of elements in collection replaced by "humans"

