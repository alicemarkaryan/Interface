using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("Mardu anuny", 100, "mashki guyny", "mazeri guyny", 50, "unaka mtacelu", 0, "normal utum a");
            Male m = new Male(10,"Aram",24,"spitakamashk","Xartyash",70,"Ayo",1,"snvum a normal");
            Female f = new Female(10, "Ani", 25, "corenamashk", "Xartyash", 70, "Ayo", 1, "snvum a normal");
            Console.WriteLine(m.Clever());
            Console.WriteLine(m.HumanDescription());
            Console.WriteLine(m.Armenian());
            m.Working(true);
            Console.WriteLine(f.Clever());
            Console.WriteLine(f.HumanDescription());
            Console.WriteLine(f.Armenian());
            f.Working(true);
            Human h1 =  m;
            Console.WriteLine(h1.Name);
            IDescription id = h;
            Console.WriteLine(id.SkinColour);
            Human h2 = (Human)id;
            Console.WriteLine(h2.Name);
            IDescription i2 = f as IDescription;
            Console.WriteLine(i2.HairColour);
            Console.WriteLine(f.Age);



        }
    }
}
