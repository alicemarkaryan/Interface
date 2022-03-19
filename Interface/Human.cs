using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Human : IAllDescreaption
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Think { get; set; }
        public int Gym { get; set; }
        public string Eating { get; set; }
        public int Iq { get; set; }
        public string SkinColour { get; set; }
        public string HairColour { get; set; }

        public Human(string name, int age,string skinColour, string hairColor, int iq, string think, int gym, string eating)
        {
            this.Name = name; this.Age = age; this.SkinColour = skinColour; this.HairColour = hairColor; this.Iq = iq; this.Gym = gym; this.Eating = eating;
        }

        public bool Armenian()
        {
            return true;
        }

        public void Working(bool a)
        {
            if (a == true)
            {
                Console.WriteLine("working");
            }
            else
            {
                Console.WriteLine("non working");
            }
        }

        public virtual string HumanDescription()
        {
            return "Name is " + Name + " and " + Age + " years old";
        }


       public  bool Clever()
        {
            return true;
        }
    }
}
