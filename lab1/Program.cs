using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            NewEra newEra = new NewEra();

            God_1 g1 = new God_1();
            God_2 g2 = new God_2();

            newEra.startingNewEra += g1.startNewEra;
            newEra.startingNewEra += g2.startNewEra;

            newEra.passingCenturys();
            try
            {
                for(int i =0; i<4; i++)
                Australopithecus.multiply();
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Args.Message);
            }

            Console.ReadKey();
        }
    }
}
