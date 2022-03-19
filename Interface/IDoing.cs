using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IDoing
    {
        string Think { get; set; }
        int Gym { get; set; }
        string Eating { get; set; }

        void Working(bool yesOrNo);

        bool Clever();


    }
}
