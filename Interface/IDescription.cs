using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IDescription
    {
        int Iq { get; set; }
        string SkinColour { get; set; }
        string HairColour { get; set; }

        bool Armenian();

        bool Clever();
    }
}
