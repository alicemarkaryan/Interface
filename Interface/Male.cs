using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Male : Human, IAllDescreaption
    {
        public int SizeHair { get; set; }

        public Male(int sizeHair, string name, int age, string skinColour, 
            string hairColor, int iq, string think, int gym, string eating):base(name, age,  skinColour,  hairColor, 
               iq,  think, gym, eating)
        {
            this.SizeHair = sizeHair;
        }

        public override string HumanDescription()
        {
            return "Name is " + Name + " and " + Age + " years old";
        }

    }
}
