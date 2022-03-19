using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class AbsractClass
    {

        public abstract int g { get; set; }
        public int a = 75;
        public  void Fabs()
        {
            Console.WriteLine(a);
        }

        public abstract void AA();

    }

     class Exersice:AbsractClass
    {
        public override int g { get; set; }
        public override void AA()
        {
            Console.WriteLine("Alo");
        }
        public  void Exe()
        {
            Fabs();
        }
    }
}
